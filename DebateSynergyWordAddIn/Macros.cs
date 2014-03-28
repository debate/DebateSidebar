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
using System.Windows.Controls;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;
using MessageBox = System.Windows.MessageBox;

namespace DebateSynergyWordAddIn
{
    class Macros
    {
        public static Application a = Globals.ThisAddIn.Application;
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
                        if (Properties.Settings.Default.UnderlineBold)
                            a.Selection.Range.Bold = 1;
                        a.Selection.Range.Underline = WdUnderline.wdUnderlineSingle;
                        a.Selection.Range.Font.Size = a.ActiveDocument.Styles["Normal"].Font.Size;

                    }
                    else
                    {
                        if (Properties.Settings.Default.UnderlineBold)
                            a.Selection.Range.Bold = 0;
                        a.Selection.Range.Underline = WdUnderline.wdUnderlineNone;
                        a.Selection.Font.Size = Properties.Settings.Default.MinimizeUnreadSize;


                    }
                    a.Selection.Collapse();
                }
            }


        }


        public static int refreshTime = 0;
        public static int refreshDocLevel = 1;
        public static void refreshDoc()
        {
            int nowTime = DateTime.Now.Minute * 60 + DateTime.Now.Second;


            MainPanel c = null;
            for (int i = 0; i < Globals.ThisAddIn.CustomTaskPanes.Count; i++)
                if (Globals.ThisAddIn.CustomTaskPanes[i].Window != null && Globals.ThisAddIn.CustomTaskPanes[i].Window.Equals(a.ActiveDocument.ActiveWindow))
                {
                   c = (MainPanel)Globals.ThisAddIn.CustomTaskPanes[i].Control;
                   break;
                }

          
            if (nowTime - 10 < refreshTime)
            {
                if (refreshDocLevel == 4)
                {
                    c.treeDoc.ExpandAll();
                    refreshDocLevel = 1;

                }
                else if (refreshDocLevel == 3)
                {
                    refreshDocLevel = 4;
                    c.treeDoc.CollapseAll();
                    for (int j = 0; j < c.treeDoc.Nodes.Count; j++)
                        c.treeDoc.Nodes[j].Expand();
                    for (int j = 0; j < c.treeDoc.Nodes.Count; j++)
                        for (int k = 0; k < c.treeDoc.Nodes[j].Nodes.Count; k++)
                            c.treeDoc.Nodes[j].Nodes[k].Expand();
                }
                else if (refreshDocLevel == 2)
                {
                    refreshDocLevel = 3;
                    c.treeDoc.CollapseAll();
                    for (int j = 0; j < c.treeDoc.Nodes.Count; j++)
                        c.treeDoc.Nodes[j].Expand();
                } else if (refreshDocLevel == 1){
                    refreshDocLevel = 2;
                    c.treeDoc.CollapseAll();
                }

           } else {
                c.populateDoc();
                refreshDocLevel = 2;
            }


            refreshTime = nowTime;
                 

          

        }
        public static void switchDocuments()
        {
           
            for (int i = 0; i < Globals.ThisAddIn.CustomTaskPanes.Count; i++)
                if (Globals.ThisAddIn.CustomTaskPanes[i].Window != null
                    && Globals.ThisAddIn.CustomTaskPanes[i].Window.Equals(a.ActiveDocument.ActiveWindow))
                {
                    MainPanel c = (MainPanel)Globals.ThisAddIn.CustomTaskPanes[i].Control;
                   
                    if (!c.bSwitchWindow.IsOnDropDown)
                       c.bSwitchWindow.ShowDropDown();
                  

                    return;


                    
                }



          
        }

        public static void Caselist()
        {
            if ((int)a.Selection.Type > 1)
                a.Selection.Copy();
            else
                a.ActiveDocument.StoryRanges[WdStoryType.wdMainTextStory].Copy();

            Document citeDoc = a.Documents.Add();

            citeDoc.ActiveWindow.Selection.Paste();

            foreach (Microsoft.Office.Interop.Word.Paragraph p in citeDoc.Paragraphs)
            {
                Words w = p.Range.Words;
                int wC = w.Count;
                if ((int) p.Range.Font.Underline == 9999999)
                {
                    p.Range.Text = w[1].Text + w[2].Text + w[3].Text + w[4].Text + w[5].Text + "... " +
                        w[wC - 5].Text + w[wC - 4].Text + w[wC - 3].Text + w[wC - 2].Text + w[wC - 1].Text + "\r";

                }


            }



        } 

        public static void RemoveFormatting()
        {
            a.Selection.ClearFormatting();
            a.Selection.Range.HighlightColorIndex = WdColorIndex.wdNoHighlight;
        }

        public static void PasteUnformatted()
        {
            if (System.Windows.Clipboard.ContainsData(System.Windows.DataFormats.Text) == false)
                return;
            
            object paste = (object) System.Windows.Clipboard.GetDataObject().GetData(System.Windows.DataFormats.Text);
            
            a.Selection.Collapse(1);
            a.Selection.Text = paste.ToString();
        }

        public static bool EscToggle = true;

        public static void EscPressed()
        {

            EscToggle = true;
        }

       

        public static void Highlight()
        {
          
            EscToggle = !EscToggle;
          
            while (EscToggle == false)
            {
                Cursor.Current = Cursors.Cross;
                System.Windows.Forms.Application.DoEvents();


                if ((int) a.Selection.Type > 1)
                {
                    if (a.Selection.Range.HighlightColorIndex == WdColorIndex.wdNoHighlight)
                    {
                        a.ScreenUpdating = false;
                        a.Selection.Range.HighlightColorIndex = a.Options.DefaultHighlightColorIndex;

                        foreach (Range w in a.Selection.Words)
                        {
                            if (w.Underline == WdUnderline.wdUnderlineNone)
                                w.HighlightColorIndex = WdColorIndex.wdNoHighlight;

                        }
                        a.Selection.Collapse(1);

                        a.ScreenUpdating = true;
                       
                    }
                    else
                    {

                        a.Selection.Range.HighlightColorIndex = WdColorIndex.wdNoHighlight;

                        a.Selection.Collapse();

                    }
                }
            }
           

        }

   


        public static void Heading1()
        {
           


            Application a = Globals.ThisAddIn.Application;
            
            if (a.Selection.Text.Length > 40)
            {
                if (MessageBoxResult.OK !=
                    MessageBox.Show("Are you sure you want to set this text heading 1?", "",
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
            Application a = Globals.ThisAddIn.Application;
            if (a.Selection.Text.Length > 40)
            {
                if (MessageBoxResult.OK !=
                    MessageBox.Show("Are you sure you want to set this text as heading 2?", "",
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
            Application a = Globals.ThisAddIn.Application;
            if (a.Selection.Text.Length > 40)
            {
                if (MessageBoxResult.OK !=
                    MessageBox.Show("Are you sure you want to set this text as heading 3?", "",
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

        public static void Heading4()
        {
            Application a = Globals.ThisAddIn.Application;
          

            if ((int)a.Selection.Type < 2)
                a.Selection.Paragraphs.First.Range.Select();

            a.Selection.set_Style("Heading 4");

            a.Selection.EndKey();
            a.Selection.MoveRight();


        }

        public static void RemoveReturns()
        {
           // if ((int)a.Selection.Type < 2) return;

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
            if (Properties.Settings.Default.PreserveParagraphs)
                f.Replacement.Text = " " + Char.ConvertFromUtf32(182) + " ";
            else
                f.Replacement.Text = " ";
            f.Replacement.Font.Underline = WdUnderline.wdUnderlineNone;
            
            f.Execute(Replace: WdReplace.wdReplaceAll);


            f.Text = Char.ConvertFromUtf32(182) + "  " + Char.ConvertFromUtf32(182);
            f.Replacement.Text = Char.ConvertFromUtf32(182);
            while (a.Selection.Range.Text.Contains(Char.ConvertFromUtf32(182) + "  "  + Char.ConvertFromUtf32(182)))
                f.Execute(Replace: WdReplace.wdReplaceAll);

            f.Text = "  ";
            f.Replacement.Text = " ";
            f.Replacement.ClearFormatting();
            while (a.Selection.Range.Text.Contains("  "))
                f.Execute(Replace: WdReplace.wdReplaceAll);
         

            if (a.Selection.Range.Characters[a.Selection.Range.Characters.Count - 1].Text == Char.ConvertFromUtf32(182))
                a.Selection.Range.Characters[a.Selection.Range.Characters.Count - 1].Text = Char.ConvertFromUtf32(13);


        }

        public static void SelectSimilar()
        {
            a.ScreenUpdating = false;

            if (a.Selection.Font.Underline == WdUnderline.wdUnderlineNone
                && a.Selection.Font.Size == a.ActiveDocument.Styles["Normal"].Font.Size)
            {
                a.ActiveDocument.Content.Font.Shrink();

                a.WordBasic.SelectSimilarFormatting();
                a.ActiveDocument.Content.Font.Grow();
            }
            else
            {

                a.WordBasic.SelectSimilarFormatting();

            }

            a.ScreenUpdating = true;

        }

        public static void MinimizeUnread()
        {
            if ((int)a.Selection.Type < 2) return;

            if (Properties.Settings.Default.MinimizeUnread)
            {
                MimimizeFont form = new MimimizeFont();
                form.ShowDialog();
            }




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


        public static void SendToSpeech()
        {
            if ((int)a.Selection.Type >1) 
                a.Selection.Copy();

            if (Globals.ThisAddIn.speechDoc == null || Globals.ThisAddIn.speechDoc.ActiveWindow == null)
            {
                SpeechAdd();
                if (Globals.ThisAddIn.speechDoc == null)
                    return;

            }

            Globals.ThisAddIn.speechDoc.ActiveWindow.Selection.Collapse(1);
            Globals.ThisAddIn.speechDoc.ActiveWindow.Selection.Paste();

            Globals.ThisAddIn.speechDoc.ActiveWindow.ScrollIntoView(Globals.ThisAddIn.speechDoc.ActiveWindow.Selection.Range);

        }


        public static string SpeechAddName = "";
        public static void SpeechAdd()
        {


            SpeechAdd s = new SpeechAdd();
            s.ShowDialog();

            if (Macros.SpeechAddName == "")
                return;

           // a.ScreenUpdating = false;

            a.ActiveWindow.WindowState = WdWindowState.wdWindowStateNormal;

            a.Resize((int) Math.Floor(SystemInformation.VirtualScreen.Width*0.45),
                (int) (SystemInformation.VirtualScreen.Height*0.7));

            a.ActiveWindow.Left = 0;
            a.ActiveWindow.Top = 0;


           // Globals.ThisAddIn.TaskPane.Visible = false;
            a.ActiveWindow.View.Type = WdViewType.wdNormalView;

            a.ActiveWindow.View.Type = WdViewType.wdWebView;
            Globals.ThisAddIn.Application.ActiveWindow.WindowState = WdWindowState.wdWindowStateMaximize;
            Globals.ThisAddIn.Application.ActiveWindow.WindowState = WdWindowState.wdWindowStateNormal;

            if (SpeechAddName != "current")
            {
                Document d = Globals.ThisAddIn.Application.Documents.Add();
                Globals.ThisAddIn.speechDoc = d;

                string savePath;
                if (Properties.Settings.Default.SpeechDirectory!="")
                    savePath = Properties.Settings.Default.SpeechDirectory;
                else if (Properties.Settings.Default.FilesDirectory != "")
                    savePath = Properties.Settings.Default.FilesDirectory;
                else savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

               
                savePath +=  "\\" + SpeechAddName;

                while (File.Exists(savePath))
                    savePath += " - Copy";
                try
                {
                    d.SaveAs(savePath);
                }
                catch (Exception err)
                {
                    d.Save();
                }
                ;
            }

            Microsoft.Office.Interop.Word.Window w = Globals.ThisAddIn.speechDoc.ActiveWindow;



            w.View.Type = WdViewType.wdWebView;
            w.WindowState = WdWindowState.wdWindowStateNormal;
            w.Width = (int)Math.Floor(SystemInformation.VirtualScreen.Width * 0.3);
            w.Height = (int)(SystemInformation.VirtualScreen.Height * 0.7);

            w.Left = (int)Math.Floor(SystemInformation.VirtualScreen.Width * 0.45);
            w.Top = 0;





            for (int i = 0; i < Globals.ThisAddIn.CustomTaskPanes.Count; i++)
                if (Globals.ThisAddIn.CustomTaskPanes[i].Window != null
                    && Globals.ThisAddIn.CustomTaskPanes[i].Window.Equals(w))
                {
                    Globals.ThisAddIn.CustomTaskPanes[i].Visible = false;
                    return;

                }



            Globals.ThisAddIn.Application.ScreenUpdating = true;
        }

        public static void ReadSpeech()
        {
            if (Properties.Settings.Default.UploadSpeech)
            {
                uploadSpeech();
                return;
            }

            a.ActiveWindow.ActivePane.View.Type = WdViewType.wdReadingView;
             a.ActiveWindow.ActivePane.Document.ActiveWindow.DocumentMap = true;
            a.ActiveWindow.ActivePane.View.ReadingLayoutAllowMultiplePages = false;
            //
        }


        public static void uploadSpeech()
        {
        	int i;
            if (InternetGetConnectedState(out i, 0) == false)
            {
                MessageBox.Show("No internet connection");
                return;
            }

            //copy as rtf
            a.ActiveDocument.StoryRanges[WdStoryType.wdMainTextStory].Copy();
            String rtfCopy = (string)System.Windows.Clipboard.GetDataObject().GetData(System.Windows.DataFormats.Rtf);

            //rtf to xaml
            string o;
            var richTextBox = new System.Windows.Controls.RichTextBox();

            var textRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);

            MemoryStream rtfMemoryStream = new MemoryStream();
            StreamWriter rtfStreamWriter = new StreamWriter(rtfMemoryStream);
            rtfStreamWriter.Write(rtfCopy);
            rtfStreamWriter.Flush();
            rtfMemoryStream.Seek(0, SeekOrigin.Begin);
            textRange.Load(rtfMemoryStream, System.Windows.DataFormats.Rtf);
            
            rtfMemoryStream = new MemoryStream();
            textRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
            textRange.Save(rtfMemoryStream, System.Windows.DataFormats.Xaml);
            rtfMemoryStream.Seek(0, SeekOrigin.Begin);
            StreamReader rtfStreamReader = new StreamReader(rtfMemoryStream);
            o = rtfStreamReader.ReadToEnd();
                

            //xaml to html
            o = new Regex("<Section [^>]+>").Replace(o, "");
            o = new Regex("<(/|)(Run|Section)>").Replace(o, "");
            o = new Regex("</Paragraph").Replace(o, "</span");
            o = new Regex("<Hyperlink [^>]+NavigateUri").Replace(o, "<a href");
            o = new Regex("</Hyperlink").Replace(o, "</a");

            foreach (Match m in new Regex("<Span>[^>^<]+</Span>").Matches(o))
                o = o.Replace(m.Value, m.Value.Replace("<Span>", "").Replace("</Span>", ""));
            
            foreach (Match m in new Regex("<(Span|Paragraph)[^>]+>").Matches(o))
            {
                string v = m.Value;
                string r = "<span style=\"";
                r += v.Contains("Paragraph") ? "display:block;min-height:14px;" : null;
                r += v.Contains("FontSize") ? "font-size:" + new Regex("FontSize=\"[^\"]+\"").Match(v).Value.Substring(10).TrimEnd("\""[0]) + "pt;" : null;
                r += v.Contains("FontStyle") ? "font-style:" + new Regex("FontStyle=\"[^\"]+\"").Match(v).Value.Substring(11).TrimEnd("\""[0]) + ";" : null;
                r += v.Contains("FontFamily") ? "font-family:" + new Regex("FontFamily=\"[^\"]+\"").Match(v).Value.Substring(12).TrimEnd("\""[0]) + ";" : null;
                r += v.Contains("FontWeight") ? "font-weight:" + new Regex("FontWeight=\"[^\"]+\"").Match(v).Value.Substring(12).TrimEnd("\""[0]) + ";" : null;
                r += v.Contains("TextDecorations") ? "text-decoration:" + new Regex("TextDecorations=\"[^\"]+\"").Match(v).Value.Substring(17).TrimEnd("\""[0]) + ";" : null;
                r += v.Contains("TextAlignment") ? "text-align:" + new Regex("TextAlignment=\"[^\"]+\"").Match(v).Value.Substring(15).TrimEnd("\""[0]) + ";" : null;
                r += v.Contains("TextIndent") ? "text-indent:" + new Regex("TextIndent=\"[^\"]+\"").Match(v).Value.Substring(12).TrimEnd("\""[0]) + ";" : null;
                r += v.Contains("Background") ? "background-color:" + new Regex("Background=\"[^\"]+\"").Match(v).Value.Substring(12).TrimEnd("\""[0]) + ";" : null;
                r += v.Contains("Foreground") ? "color:" + new Regex("Foreground=\"[^\"]+\"").Match(v).Value.Substring(12).TrimEnd("\""[0]) + ";" : null;
                r += "\" class=\"";
                r += v.Contains("TextAlignment=\"Center") ? " heading " : null;
                r += v.Contains("TextDecorations") ? " underline " : null;
                r += v.Contains("Background") ? " hilite " : null;
                r += v.Contains("Bold") ? " bold " : null;
                r += "\">";
                r = new Regex(".(3|6)+(2|4|)").Replace(r, "");

                o = o.Replace(m.Value, r);
            }

            string htmlCopy = o.Replace("&", "%26");           

            WebRequest request = WebRequest.Create("http://debatesynergy.com/speech.php");
            request.Method = "POST";
            byte[] byteArray = Encoding.UTF8.GetBytes("&data=" + htmlCopy);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream = request.GetResponse().GetResponseStream();
            string responseFromServer = new StreamReader(dataStream).ReadToEnd();

            if (responseFromServer.ToLower().Contains("error"))
                MessageBox.Show(responseFromServer);
            else //open URL with read speech 
                Process.Start(Path.Combine(Environment.GetEnvironmentVariable("SystemRoot"), "explorer.exe"),
                    "\"" + "http://debatesynergy.com/" + responseFromServer + "\"");

        }
        
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
    }
}


