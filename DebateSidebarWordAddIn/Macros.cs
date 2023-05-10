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
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools;
using Application = Microsoft.Office.Interop.Word.Application;
using Clipboard = System.Windows.Clipboard;
using DataFormats = System.Windows.DataFormats;
using MessageBox = System.Windows.MessageBox;
using RichTextBox = System.Windows.Controls.RichTextBox;

namespace DebateSidebarWordAddIn
{
internal class Macros
{
private static Application a = Globals.ThisAddIn.Application;
public static bool EscToggle = true;

public static bool HighlightModeOn = false;

//Sidebar Hotkeys

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


    int level = Convert.ToInt32(Properties.Settings.Default.HeadingLevels);

    if (!c.treeDoc.Visible)
        c.bFilesShow.PerformClick();

    //if (nowTime - 10 < c.indexLastTime)
    
        switch(c.indexLevel){
            case 4:
                c.bCollapse.PerformClick();
            c.indexLevel = 1;
           
        break; case 3:

        c.bExpand.PerformClick();
            if (level >= 4)
                c.indexLevel = 4;
            else
                c.indexLevel = 1;

       	break; case 2:


        c.bCollapseHeading3.PerformClick();
            if (level >= 3)
                c.indexLevel = 3;
            else
                c.indexLevel = 1;
        break; case 1:

        c.bCollapseHeading2.PerformClick();
            if (level >= 2)
                c.indexLevel = 2;
            else
                c.indexLevel = 1;

        break;
        }
   /* }
    else
    {
        c.populateDoc();
        if (Properties.Settings.Default.ExpandHeadings)
            c.indexLevel = 1;
        else
            c.indexLevel = 4;
    }*/

    c.indexLastTime = nowTime;
}

//Format Macros

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
        
        if ((int) a.Selection.Type > 1)
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

public static void Highlight()
{
    EscToggle = !EscToggle;
    if (HighlightModeOn)
        return;

    while (EscToggle == false)
    {
        Cursor.Current = Cursors.Cross;
        System.Windows.Forms.Application.DoEvents();


        if ((int) a.Selection.Type > 1)
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
}

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

    if ((int) a.Selection.Type < 2)
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

    if ((int) a.Selection.Type < 2)
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

    if ((int) a.Selection.Type < 2)
        a.Selection.Paragraphs.First.Range.Select();

    a.Selection.set_Style("Heading 3");

    a.Selection.EndKey();
    a.Selection.MoveRight();

    if (a.ActiveDocument.Words.Count < 10000)
        refreshDoc();
}

public static void Heading4()
{

    if ((int) a.Selection.Type < 2)
        a.Selection.Paragraphs.First.Range.Select();

    a.Selection.set_Style("Heading 4");

    a.Selection.EndKey();
    a.Selection.MoveRight();
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
    if ((int) a.Selection.Type < 2) return;

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
        if ((int)p.Range.Font.Underline == 9999999 && (int)p.Range.Font.Bold != 1
                    && !((int)w[1].Font.Bold == 1 && (int)w[2].Font.Bold == 1 && (int)w[3].Font.Bold == 0)
                    && !p.Range.Text.Trim().EndsWith(")") && !p.Range.Text.Trim().EndsWith("]")) {

                    string endWords = w[wC - 5].Text + w[wC - 4].Text + w[wC - 3].Text + w[wC - 2].Text + w[wC - 1].Text + "\r";

                    if (p.Previous().Range.Text.IndexOf("...") > -1) {
                        p.Range.Delete();
                        p.Previous().Range.Text = p.Previous().Range.Text.Substring(0, p.Previous().Range.Text.IndexOf("...") + 4) + endWords;
                    } else
                        p.Range.Text = w[1].Text + w[2].Text + w[3].Text + w[4].Text + w[5].Text + "... " + endWords;

                }
            }
}

public static void RemoveFormatting()
{
    a.Selection.ClearFormatting();
    a.Selection.Range.HighlightColorIndex = WdColorIndex.wdNoHighlight;
}

//Speech

public static void Timer()
{
    string timerPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
                   + "\\Debate Sidebar Word Addin\\DebateTimer.exe";

    if (File.Exists(timerPath))
    {
        Process.Start(timerPath);
    }
    else if (File.Exists(Properties.Settings.Default.TimerPath))
    {
        Process.Start(Properties.Settings.Default.TimerPath);
    }
    else
    {
        OpenFileDialog path = new OpenFileDialog();
        if (path.ShowDialog() == DialogResult.OK)
            Properties.Settings.Default.TimerPath = path.FileName;

        Properties.Settings.Default.Save();

    }
}

public static void SendToSpeech()
{
    try
    {
        if (Globals.ThisAddIn.speechDoc == null || Globals.ThisAddIn.speechDoc.ActiveWindow == null)
        {
            SpeechManage();
            return;
        }
    }
    catch (Exception err)
    {
        SpeechManage();
        Debug.WriteLine(err);
        return; 
        
    }



    if (Globals.ThisAddIn.speechDoc == Globals.ThisAddIn.Application.ActiveDocument)
    {
        if (MessageBoxResult.Yes != MessageBox.Show("Do you want to read this speech?",
            "Upload Speech", MessageBoxButton.YesNo, MessageBoxImage.Question))
            return;

        ReadSpeech();
        return;
    }

    if ((int) a.Selection.Type > 1)
        a.Selection.Copy();


   

    Microsoft.Office.Interop.Word.Window winSpeech = Globals.ThisAddIn.speechDoc.ActiveWindow;
    winSpeech.Selection.Collapse(1);
    winSpeech.Selection.EndOf(WdUnits.wdParagraph);
    winSpeech.Selection.Range.Paragraphs.Last.Range.EndOf();
    winSpeech.Selection.PasteSpecial(DataType: WdPasteDataType.wdPasteRTF);
    winSpeech.ScrollIntoView(winSpeech.Selection.Range);
}

public static void SpeechManage()
{
    var s = new ManageSpeech();
    s.ShowDialog();

    try
    {
        if (Globals.ThisAddIn.speechDoc == null)
            return;
  
    }
    catch (Exception err){ Debug.WriteLine(err); return; }


    //half size current window
    a.ActiveWindow.WindowState = WdWindowState.wdWindowStateNormal;

    a.Resize((int)Math.Floor(SystemInformation.VirtualScreen.Width * 0.45),
        (int)(SystemInformation.VirtualScreen.Height * 0.7));

    a.ActiveWindow.Left = 0;
    a.ActiveWindow.Top = 0;


    a.ActiveWindow.View.Type = WdViewType.wdNormalView;

    a.ActiveWindow.View.Type = WdViewType.wdWebView;
    Globals.ThisAddIn.Application.ActiveWindow.WindowState = WdWindowState.wdWindowStateMaximize;
    Globals.ThisAddIn.Application.ActiveWindow.WindowState = WdWindowState.wdWindowStateNormal;


    //half size speech window

    Microsoft.Office.Interop.Word.Window w = Globals.ThisAddIn.speechDoc.ActiveWindow;


    w.View.Type = WdViewType.wdWebView;
    w.WindowState = WdWindowState.wdWindowStateNormal;
    w.Width = (int)Math.Floor(System.Windows.Forms.SystemInformation.VirtualScreen.Width * 0.3);
    w.Height = (int)(System.Windows.Forms.SystemInformation.VirtualScreen.Height * 0.7);

    w.Left = (int)Math.Floor(System.Windows.Forms.SystemInformation.VirtualScreen.Width * 0.45);
    w.Top = 0;


    for (int i = 0; i < Globals.ThisAddIn.CustomTaskPanes.Count; i++)
        if (Globals.ThisAddIn.CustomTaskPanes[i].Window != null
            && Globals.ThisAddIn.CustomTaskPanes[i].Window.Equals(w))
        {
            Globals.ThisAddIn.CustomTaskPanes[i].Visible = false;
            return;
        }

}

public static void ReadSpeech()
{
    if (Properties.Settings.Default.UploadSpeech)
    {
        UploadSpeech();
    }
    else
    {
        a.ActiveWindow.ActivePane.View.Type = WdViewType.wdReadingView;
        a.ActiveWindow.ActivePane.Document.ActiveWindow.DocumentMap = true;
        a.ActiveWindow.ActivePane.View.ReadingLayoutAllowMultiplePages = false;
    }
}

public static void UploadSpeech()
{
    int i;
    if (InternetGetConnectedState(out i, 0) == false)
    {
        MessageBox.Show("No internet connection");
        return;
    }

    Globals.ThisAddIn.Application.StatusBar = "Preparing";


    //copy as rtf
    a.ActiveDocument.StoryRanges[WdStoryType.wdMainTextStory].Copy();
    var rtfCopy = (string) Clipboard.GetDataObject().GetData(DataFormats.Rtf);

    //rtf to xaml
    string o;
    var richTextBox = new RichTextBox();
    var textRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);

    var rtfMemoryStream = new MemoryStream();
    var rtfStreamWriter = new StreamWriter(rtfMemoryStream);
    rtfStreamWriter.Write(rtfCopy);
    rtfStreamWriter.Flush();
    rtfMemoryStream.Seek(0, SeekOrigin.Begin);
    textRange.Load(rtfMemoryStream, DataFormats.Rtf);

    rtfMemoryStream = new MemoryStream();
    textRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
    textRange.Save(rtfMemoryStream, DataFormats.Xaml);
    rtfMemoryStream.Seek(0, SeekOrigin.Begin);
    var rtfStreamReader = new StreamReader(rtfMemoryStream);
    o = rtfStreamReader.ReadToEnd();

    //xaml to html
    o = new Regex("<Section [^>]+>").Replace(o, "");
    o = new Regex("<(/|)(Run|Section)>").Replace(o, "");
    o = new Regex("</Paragraph").Replace(o, "</span");
    o = new Regex("<Hyperlink [^>]+NavigateUri").Replace(o, "<a href");
    o = new Regex("</Hyperlink").Replace(o, "</a");

    foreach (Match m in new Regex("<Span>[^>^<]+</Span>").Matches(o))
        o = o.Replace(m.Value, m.Value.Replace("<Span>", "").Replace("</Span>", ""));

    int formatIndex = 0;
    int formatTotal = new Regex("<(Span|Paragraph)[^>]+>").Matches(o).Count;

    foreach (Match m in new Regex("<(Span|Paragraph)[^>]+>").Matches(o))
    {
        formatIndex++;
        Globals.ThisAddIn.Application.StatusBar = "                                " 
            + Math.Floor((double)(100 * formatIndex / formatTotal)).ToString() + "% Converted";
        System.Windows.Forms.Application.DoEvents();
       

        string v = m.Value;
        string r = "<span style=\"";
        r += v.Contains("Paragraph") ? "display:block;min-height:14px;" : null;
        r += v.Contains("FontSize")
            ? "font-size:" + new Regex("FontSize=\"[^\"]+\"").Match(v).Value.Substring(10).TrimEnd("\""[0]) + "pt;": null;
        r += v.Contains("FontStyle")
            ? "font-style:" + new Regex("FontStyle=\"[^\"]+\"").Match(v).Value.Substring(11).TrimEnd("\""[0]) +";": null;
        r += v.Contains("FontFamily")
            ? "font-family:" + new Regex("FontFamily=\"[^\"]+\"").Match(v).Value.Substring(12).TrimEnd("\""[0]) +";": null;
        r += v.Contains("FontWeight")
            ? "font-weight:" + new Regex("FontWeight=\"[^\"]+\"").Match(v).Value.Substring(12).TrimEnd("\""[0]) +";": null;
        r += v.Contains("TextDecorations")
            ? "text-decoration:" + new Regex("TextDecorations=\"[^\"]+\"").Match(v).Value.Substring(17).TrimEnd("\""[0]) + ";": null;
        r += v.Contains("TextAlignment")
            ? "text-align:" + new Regex("TextAlignment=\"[^\"]+\"").Match(v).Value.Substring(15).TrimEnd("\""[0]) + ";": null;
        r += v.Contains("TextIndent")
            ? "text-indent:" + new Regex("TextIndent=\"[^\"]+\"").Match(v).Value.Substring(12).TrimEnd("\""[0]) +";" : null;
        r += v.Contains("Background")
            ? "background-color:" +new Regex("Background=\"[^\"]+\"").Match(v).Value.Substring(12).TrimEnd("\""[0]) + ";": null;
        r += v.Contains("Foreground")
            ? "color:" + new Regex("Foreground=\"[^\"]+\"").Match(v).Value.Substring(12).TrimEnd("\""[0]) + ";": null;
        r += "\" class=\"";
        r += v.Contains("TextAlignment=\"Center") ? " heading " : null;
        r += v.Contains("TextDecorations") ? " underline " : null;
        r += v.Contains("Background") ? " hilite " : null;
        r += v.Contains("Bold") ? " bold " : null;
        r += "\">";
        r = new Regex("\\.[0-9]+").Replace(r, "");
        o = o.Replace(m.Value, r);
    }


    Globals.ThisAddIn.Application.StatusBar = "Uploading";
    string htmlCopy = o.Replace("&", "%26");

    WebRequest request = WebRequest.Create("http://debatesynergy.com/speech");
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

//WinAPI
[DllImport("wininet.dll")]
private static extern bool InternetGetConnectedState(out int Description, int ReservedValue);


}
}