using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Documents;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;

namespace DebateSidebarWordAddIn
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        //load
        private void Speech_Load(object sender, EventArgs e)
        {
           

            foreach (Window win in Globals.ThisAddIn.Application.Windows)
            {
                curDocsList.Items.Add(win.Caption);
            }
            curDocsList.SelectedIndex = 0;

            try
            {
                if (Globals.ThisAddIn.speechDoc != null && Globals.ThisAddIn.speechDoc.Name != null)
                    textCurrentDoc.Text += Globals.ThisAddIn.speechDoc.Name;
                else
                    textCurrentDoc.Text += "None";
            }
            catch (Exception err)
            {
               Debug.WriteLine(err); 
               textCurrentDoc.Text += "None";
            }
        }
       
        private void speechName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString() == "Escape")
                Close();
        }


        //new speech

      
        //set current

        private void bSetCurDoc_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.speechDoc = Globals.ThisAddIn.Application.Windows[curDocsList.SelectedIndex + 1].Document;
            Close();
        }

        //read speech

        private void bReadOnline_Click(object sender, EventArgs e)
        {
       

        //custom converter from Verbatim docx to DebateAI format
        //requires login with DebateAI account
       /*
            string speechServer = "http://";

            int i;
            if (InternetGetConnectedState(out i, 0) == false)
            {
                MessageBox.Show("No internet connection");
                return;
            }

            Globals.ThisAddIn.Application.StatusBar = "Preparing";


            //copy as rtf
            a.ActiveDocument.StoryRanges[WdStoryType.wdMainTextStory].Copy();
            var rtfCopy = (string)Clipboard.GetDataObject().GetData(DataFormats.Rtf);

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
                    ? "font-size:" + new Regex("FontSize=\"[^\"]+\"").Match(v).Value.Substring(10).TrimEnd("\""[0]) + "pt;" : null;
                r += v.Contains("FontStyle")
                    ? "font-style:" + new Regex("FontStyle=\"[^\"]+\"").Match(v).Value.Substring(11).TrimEnd("\""[0]) + ";" : null;
                r += v.Contains("FontFamily")
                    ? "font-family:" + new Regex("FontFamily=\"[^\"]+\"").Match(v).Value.Substring(12).TrimEnd("\""[0]) + ";" : null;
                r += v.Contains("FontWeight")
                    ? "font-weight:" + new Regex("FontWeight=\"[^\"]+\"").Match(v).Value.Substring(12).TrimEnd("\""[0]) + ";" : null;
                r += v.Contains("TextDecorations")
                    ? "text-decoration:" + new Regex("TextDecorations=\"[^\"]+\"").Match(v).Value.Substring(17).TrimEnd("\""[0]) + ";" : null;
                r += v.Contains("TextAlignment")
                    ? "text-align:" + new Regex("TextAlignment=\"[^\"]+\"").Match(v).Value.Substring(15).TrimEnd("\""[0]) + ";" : null;
                r += v.Contains("TextIndent")
                    ? "text-indent:" + new Regex("TextIndent=\"[^\"]+\"").Match(v).Value.Substring(12).TrimEnd("\""[0]) + ";" : null;
                r += v.Contains("Background")
                    ? "background-color:" + new Regex("Background=\"[^\"]+\"").Match(v).Value.Substring(12).TrimEnd("\""[0]) + ";" : null;
                r += v.Contains("Foreground")
                    ? "color:" + new Regex("Foreground=\"[^\"]+\"").Match(v).Value.Substring(12).TrimEnd("\""[0]) + ";" : null;
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

            WebRequest request = WebRequest.Create(speechServer);
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
                    "\"" + responseFromServer + "\"");
       */
        }


        private void bReadOffline_Click(object sender, EventArgs e)
        {
            Pane v = Globals.ThisAddIn.Application.ActiveWindow.ActivePane;
            v.View.Type = WdViewType.wdReadingView;
            v.Document.ActiveWindow.DocumentMap = true;
            v.View.ReadingLayoutAllowMultiplePages = false;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }


        //WinAPI
        //  [DllImport("wininet.dll")]
        //  private static extern bool InternetGetConnectedState(out int Description, int ReservedValue);



    }
}