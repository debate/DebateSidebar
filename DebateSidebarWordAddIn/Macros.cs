using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Word.Application;
using Clipboard = System.Windows.Clipboard;
using DataFormats = System.Windows.DataFormats;
using MessageBox = System.Windows.MessageBox;
using RichTextBox = System.Windows.Controls.RichTextBox;

/*
 





 */

namespace DebateSidebarWordAddIn
{
    internal class Macros
    {
        private static Application a = Globals.ThisAddIn.Application;
        public static bool EscToggle = true;

        public static bool HighlightModeOn = false;

        public static int ReadModeLevel = 1;

        //Sidebar hide and show
        public static void toggleSidebar()
        {
            try
            {
                foreach (CustomTaskPane CTP in Globals.ThisAddIn.CustomTaskPanes)
                    if (CTP != null && CTP.Window != null
                        && Globals.ThisAddIn.Application.ActiveDocument != null
                        && CTP.Window.Equals(Globals.ThisAddIn.Application.ActiveDocument.ActiveWindow))
                    {

                        CTP.Visible = !CTP.Visible;

                        if (CTP.Visible)
                            ((Sidebar)CTP.Control).populateDoc();
                        return;
                    }

            }

            catch (Exception err) { Debug.WriteLine(err); }

        }




        //refresh sidebar on click on heading
        public static void refreshDoc()
        {
            int nowTime = DateTime.Now.Minute * 60 + DateTime.Now.Second;

            Sidebar c = null;

            foreach (CustomTaskPane CTP in Globals.ThisAddIn.CustomTaskPanes)
                if (CTP.Window != null
                    && CTP.Window.Equals(Globals.ThisAddIn.Application.ActiveDocument.ActiveWindow))
                {
                    c = (Sidebar)CTP.Control;
                    break;
                }

            c.populateDoc();
        }

        public static void EscPressed()
        {
            EscToggle = true;
        }

        public static void Underline()
        {
            EscToggle = !EscToggle;

            while (EscToggle == false)
            {
                Cursor.Current = Cursors.Cross;
                System.Windows.Forms.Application.DoEvents();

                if ((int)a.Selection.Type > 1)
                {
                    if (a.Selection.Range.Underline == WdUnderline.wdUnderlineNone)
                    {
                        a.Selection.Range.Underline = WdUnderline.wdUnderlineSingle;
                        a.Selection.Range.Font.Size = a.ActiveDocument.Styles["Normal"].Font.Size;
                    }
                    else
                    {
                        a.Selection.Range.Underline = WdUnderline.wdUnderlineNone;
                        a.Selection.Font.Size = Properties.Settings.Default.MinimizeUnreadSize;
                    }
                    a.Selection.Collapse();
                }
            }
        }

        //why esc toggle here but modeon there??
        public static void Highlight()
        {
            EscToggle = !EscToggle;
            if (HighlightModeOn)
                return;

            while (EscToggle == false)
            {
                Cursor.Current = Cursors.Cross;
                System.Windows.Forms.Application.DoEvents();


                if ((int)a.Selection.Type > 1)
                {
                    if (a.Selection.Range.HighlightColorIndex == WdColorIndex.wdNoHighlight)
                    {
                        a.ScreenUpdating = false;
                        HighlightModeOn = true;
                        a.Selection.Range.HighlightColorIndex = a.Options.DefaultHighlightColorIndex;

                        foreach (Range w in a.Selection.Words)
                        {
                            if (w.Underline == WdUnderline.wdUnderlineNone)
                                w.HighlightColorIndex = WdColorIndex.wdNoHighlight;
                        }
                        a.Selection.Collapse(0);
                        HighlightModeOn = false;

                        a.ScreenUpdating = true;
                    }
                    else
                    {
                        a.Selection.Range.HighlightColorIndex = WdColorIndex.wdNoHighlight;

                        a.Selection.Collapse(1);
                    }
                }
            }
        }

        public static void PasteText()
        {
            if (Clipboard.ContainsData(DataFormats.Text) == false)
                return;

            object paste = Clipboard.GetDataObject().GetData(DataFormats.Text);

            a.Selection.Collapse(1);
            a.Selection.Text = paste.ToString();

            //todo keep selected and condense
        }

        //remove line breaks and similar breaks, optionally use a replace character
        public static void RemoveReturns()
        {
            Find f = a.Selection.Range.Find;
            f.ClearFormatting();
            f.Wrap = WdFindWrap.wdFindStop;
            f.Replacement.Text = " ";
            f.Text = Char.ConvertFromUtf32(10);
            f.Execute(Replace: WdReplace.wdReplaceAll);
            f.Text = Char.ConvertFromUtf32(11);
            f.Execute(Replace: WdReplace.wdReplaceAll);
            f.Text = Char.ConvertFromUtf32(12);
            f.Execute(Replace: WdReplace.wdReplaceAll);


            f.Text = Char.ConvertFromUtf32(45);
            f.Execute(Replace: WdReplace.wdReplaceAll);


            f.Text = Char.ConvertFromUtf32(13);
            f.Replacement.Font.Size = Properties.Settings.Default.MinimizeUnreadSize;
            
            // WHAT TYPE OF PARAGRAPH BREAK
            if (Properties.Settings.Default.PreserveParagraphs)
                f.Replacement.Text = " " + Char.ConvertFromUtf32(182) + " ";
            else
                f.Replacement.Text = " ";
            f.Replacement.Font.Underline = WdUnderline.wdUnderlineNone;

            f.Execute(Replace: WdReplace.wdReplaceAll);


            f.Text = Char.ConvertFromUtf32(182) + "  " + Char.ConvertFromUtf32(182);
            f.Replacement.Text = Char.ConvertFromUtf32(182);
            while (a.Selection.Range.Text.Contains(Char.ConvertFromUtf32(182) + "  " + Char.ConvertFromUtf32(182)))
                f.Execute(Replace: WdReplace.wdReplaceAll);

            f.Text = "  ";
            f.Replacement.Text = " ";
            f.Replacement.ClearFormatting();
            while (a.Selection.Range.Text.Contains("  "))
                f.Execute(Replace: WdReplace.wdReplaceAll);


            if (a.Selection.Range.Characters[a.Selection.Range.Characters.Count - 1].Text == Char.ConvertFromUtf32(182))
                a.Selection.Range.Characters[a.Selection.Range.Characters.Count - 1].Text = Char.ConvertFromUtf32(13);
        }

        public static void Heading1()
        {

            if (a.Selection.Text.Length > 40)
            {
                if (MessageBoxResult.OK !=
                    MessageBox.Show("Are you sure you want to set this text as Heading 1?", "",
                        MessageBoxButton.OKCancel))
                    return;
            }

            if ((int)a.Selection.Type < 2)
                a.Selection.Paragraphs.First.Range.Select();

            a.Selection.set_Style("Heading 1");

            a.Selection.EndKey();
            a.Selection.MoveRight();


            if (a.ActiveDocument.Words.Count < 10000)
                refreshDoc();
        }

        public static void Heading2()
        {
            if (a.Selection.Text.Length > 40)
            {
                if (MessageBoxResult.OK !=
                    MessageBox.Show("Are you sure you want to set this text as Heading 2?", "",
                        MessageBoxButton.OKCancel))
                    return;
            }

            if ((int)a.Selection.Type < 2)
                a.Selection.Paragraphs.First.Range.Select();

            a.Selection.set_Style("Heading 2");

            a.Selection.EndKey();
            a.Selection.MoveRight();

            if (a.ActiveDocument.Words.Count < 10000)
                refreshDoc();
        }

        public static void Heading3()
        {
            if (a.Selection.Text.Length > 40)
            {
                if (MessageBoxResult.OK !=
                    MessageBox.Show("Are you sure you want to set this text as Heading 3?", "",
                        MessageBoxButton.OKCancel))
                    return;
            }

            if ((int)a.Selection.Type < 2)
                a.Selection.Paragraphs.First.Range.Select();

            a.Selection.set_Style("Heading 3");

            a.Selection.EndKey();
            a.Selection.MoveRight();

            if (a.ActiveDocument.Words.Count < 10000)
                refreshDoc();
        }



        //add Flow Note which appears in Doc Map as red / blue H3 and collapses tags 
        public static void AddFlowNote()
        {
            if (a.Selection.Text.Length > 100)
            {
                if (MessageBoxResult.OK !=
                    MessageBox.Show("Are you sure you want to set this text as Flow Note?", "",
                        MessageBoxButton.OKCancel))
                    return;
            }

            if ((int)a.Selection.Type < 2)
                a.Selection.Paragraphs.First.Range.Select();

            a.Selection.set_Style("Heading 3");

            a.Selection.Font.Color = WdColor.wdColorRed;


            a.Selection.EndKey();
            a.Selection.MoveRight();

            if (a.ActiveDocument.Words.Count < 10000)
                refreshDoc();
        }

        public static void Heading4()
        {

            if ((int)a.Selection.Type < 2)
                a.Selection.Paragraphs.First.Range.Select();

            a.Selection.set_Style("Heading 4");

            a.Selection.EndKey();
            a.Selection.MoveRight();
        }


        public static void MinimizeUnread()
        {
            if ((int)a.Selection.Type < 2) return;

            a.ScreenUpdating = false;

            Find f = a.Selection.Range.Find;
            f.ClearFormatting();
            f.Wrap = WdFindWrap.wdFindStop;
            f.Replacement.Text = "";

            f.Font.Underline = WdUnderline.wdUnderlineSingle;
            f.ParagraphFormat.OutlineLevel = WdOutlineLevel.wdOutlineLevelBodyText;
            f.Replacement.Font.Size = a.ActiveDocument.Styles["Normal"].Font.Size;
            f.Execute(Replace: WdReplace.wdReplaceAll);

            f.Font.Underline = WdUnderline.wdUnderlineNone;
            f.Font.Bold = 1;
            f.Execute(Replace: WdReplace.wdReplaceAll);

            f.Font.Bold = 0;
            f.Font.Underline = WdUnderline.wdUnderlineNone;
            f.Replacement.Font.Size = Properties.Settings.Default.MinimizeUnreadSize;
            f.Execute(Replace: WdReplace.wdReplaceAll);
            a.ScreenUpdating = true;
        }



        //TODO -- find a way to use ExpandOutline to H4 tags without freezing screen
        public static void CollapseDocToTags()
        {
            a.ActiveWindow.View.CollapseAllHeadings();
            a.ScreenRefresh();

            return;

        }


        //Reading Mode Toggle between text size of showing unread, underlined, and section headings
        public static void InvisibilityMode()
        {

            // bring up menu
            
            // if nothing is selected ask to apply to whole doc
            if ((int)a.Selection.Type < 2)
            {
                // if you got a really big doc, ask if just to selection

                a.Selection.WholeStory();

            };


            float sizeNormal = a.ActiveDocument.Styles["Normal"].Font.Size;

            // READ MODE SWITCHER

            ReadModeLevel++;

            if (ReadModeLevel > 4)
            {
                ReadModeLevel = 1;

                a.ActiveWindow.View.ExpandAllHeadings();
            }


            float sizeUnread = 8; //shrink 
            float sizeUnderlined = 11;



            string StatusBar = "Shrink Unread Mode: Show all text and shrink unread.";

            if (ReadModeLevel == 2)
            {
                sizeUnread = 1;

                StatusBar = "Underline Mode: SHOW highlighted emphasis underlined, HIDE unread";
            }

            

            if (ReadModeLevel == 3)
            {

                sizeUnread = 1; 
                sizeUnderlined = 1;

                StatusBar = "Highlight Mode: SHOW highlighted, HIDE emphasis underlined unread";
            }


            if (ReadModeLevel == 4)
            {
                a.ActiveWindow.View.CollapseAllHeadings();

                a.StatusBar = "Flow Mode: SHOW Headings, collapsible tags and Flow Notes";

                // expand the first H1 and H2 
                SendKeys.Send("{END}{ENTER}{DOWN}{END}{ENTER}");

                return;
            }

            a.ScreenUpdating = false;
            Find f = a.Selection.Range.Find;
            f.Wrap = WdFindWrap.wdFindStop;
            f.Replacement.Text = "";

            // unread = non bold and non underline
            f.ClearFormatting(); 
            f.Font.Bold = 0;
            f.Highlight = 0; 
            f.Font.Underline = WdUnderline.wdUnderlineNone;
            f.ParagraphFormat.OutlineLevel = WdOutlineLevel.wdOutlineLevelBodyText;
            f.Replacement.Font.Size = sizeUnread;
            f.Replacement.Font.Scaling = sizeUnread == 1 ? 10 : 100;
            f.Replacement.Font.Color = sizeUnread == 1 ? WdColor.wdColorWhite : WdColor.wdColorBlack;

            f.Execute(Replace: WdReplace.wdReplaceAll);

            // underline = underlined and not tags or titles
            f.ClearFormatting();
            f.Highlight = 0;
            f.Font.Underline = WdUnderline.wdUnderlineSingle;
            f.ParagraphFormat.OutlineLevel = WdOutlineLevel.wdOutlineLevelBodyText;
            f.Replacement.Font.Size = sizeUnderlined;
            f.Replacement.Font.Scaling = sizeUnderlined == 1 ? 10 : 100;
            f.Replacement.Font.Color = sizeUnderlined == 1 ? WdColor.wdColorWhite : WdColor.wdColorBlack;

            f.Execute(Replace: WdReplace.wdReplaceAll);


            a.ScreenUpdating = true;
            a.StatusBar = "                                                                 "
                +StatusBar;


        }

        /* emphasis = bold and underlined
         f.ClearFormatting(); 
         f.Font.Underline = WdUnderline.wdUnderlineSingle;
         f.ParagraphFormat.OutlineLevel = WdOutlineLevel.wdOutlineLevelBodyText;
         f.Font.Bold = 1;
         f.Replacement.Font.Size = sizeEmphasis;
         f.Replacement.Font.Scaling = sizeEmphasis == 1 ? 1 : 100;
         f.Execute(Replace: WdReplace.wdReplaceAll);
         */

        // ensure showing of tags = non underline and bold = show
        /*
        f.Font.Underline = WdUnderline.wdUnderlineNone;
        f.Font.Bold = 1;
        f.Replacement.Font.Size = 11;
        f.ParagraphFormat.OutlineLevel
        f.Execute(Replace: WdReplace.wdReplaceAll);*/

        public static void RemoveFormatting()
        {
            a.Selection.ClearFormatting();
            a.Selection.Range.HighlightColorIndex = WdColorIndex.wdNoHighlight;
        }

    
    }
}