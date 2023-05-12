using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Word.Application;

namespace DebateSidebarWordAddIn
{
    public partial class ManageSpeech : Form
    {
        public ManageSpeech()
        {
            InitializeComponent();
        }

        //load
        private void Speech_Load(object sender, EventArgs e)
        {

            populateName();

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

        private void populateName()
        {
            string s = "Speech ";

            if (DateTime.Now.Month < 10)
                s += "0";
            s += DateTime.Now.Month + "-";
            if (DateTime.Now.Day < 10)
                s += "0";
            s += DateTime.Now.Day + " ";

            s += Regex.Replace(DateTime.Now.ToShortTimeString(), ":.* ", "");

            s += " ";
            s += r1.Checked ? r1.Text : r2.Checked ? r2.Text : r3.Checked ? r3.Text : r4.Checked ?
               r4.Text : r5.Checked ? r5.Text : r6.Checked ? r6.Text : r7.Checked ? r7.Text : "";


            speechName.Text = s;
        }

        private void speechChecked(object sender, EventArgs e)
        {
            populateName();
        }

        private void bSpeechAdd_Click(object sender, EventArgs e)
        {

            Document d = Globals.ThisAddIn.Application.Documents.Add();
            Globals.ThisAddIn.speechDoc = d;

            string savePath = "";
            Properties.Settings s = Properties.Settings.Default;
            savePath = s.SpeechDirectory != "" ? s.SpeechDirectory : s.FilesDirectory != "" ?
                s.FilesDirectory : Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            savePath += "\\" + speechName.Text;

            while (File.Exists(savePath))
                savePath += " - New";

            try
            {
                d.SaveAs(savePath);
            }
            catch (Exception err)
            {
                Debug.WriteLine(err);
                d.Save();
            }

            Close();

        }

        //set current

        private void bSetCurDoc_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.speechDoc = Globals.ThisAddIn.Application.Windows[curDocsList.SelectedIndex + 1].Document;
            Close();
        }

        //read speech

        private void bReadOnline_Click(object sender, EventArgs e)
        {
            Macros.UploadSpeech();
        }

        private void bReadOffline_Click(object sender, EventArgs e)
        {
            Pane v = Globals.ThisAddIn.Application.ActiveWindow.ActivePane;
            v.View.Type = WdViewType.wdReadingView;
            v.Document.ActiveWindow.DocumentMap = true;
            v.View.ReadingLayoutAllowMultiplePages = false;
        }

        private void bUSB_Click(object sender, EventArgs e)
        {
            Application a = Globals.ThisAddIn.Application;
            try
            {
                a.ActiveDocument.Save();
            }
            catch (Exception err) { Debug.WriteLine(err); }
            string msg = "";
            if (a.ActiveDocument.Saved)
                msg = a.ActiveDocument.FullName + " Saved \r\n";
            IEnumerable<DriveInfo> drives = DriveInfo.GetDrives()
                .Where(drive => drive.IsReady && drive.DriveType == DriveType.Removable);

            if (drives.Count() == 0)
                return;
            for (int i = 0; i < drives.Count(); i++)
            {
                File.Copy(a.ActiveDocument.FullName, drives.ElementAt(i).Name + a.ActiveDocument.Name, true);
                msg += drives.ElementAt(i).Name + a.ActiveDocument.Name + " Copied \r\n";
            }
            MessageBox.Show(msg);
        }

        private void bTimer_Click(object sender, EventArgs e)
        {
            Macros.Timer();
        }
    }
}