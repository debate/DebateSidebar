using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;
using Font = System.Drawing.Font;

namespace DebateSidebarWordAddIn
{
    public partial class Speech : Form
    {
        public Speech()
        {
            InitializeComponent();
        }


        private void SpeechAdd_Load(object sender, EventArgs e)
        {
            Macros.SpeechAddName = "";

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
                textCurrentDoc.Text += "None";
            }
        }

        private void populateName()
        {
            string buttonName;

            buttonName = r1.Checked
                ? r1.Text
                : r2.Checked
                    ? r2.Text
                    : r3.Checked
                        ? r3.Text
                        : r4.Checked ? r4.Text : r5.Checked ? r5.Text : r6.Checked ? r6.Text : r7.Checked ? r7.Text : "";


            speechName.Text = "Speech " + buttonName + " " + DateTime.Now.Month + "-" + DateTime.Now.Day + " " +
                              Regex.Replace(DateTime.Now.ToShortTimeString(), ":.* ", "");
        }

        private void speechChecked(object sender, EventArgs e)
        {
            populateName();
        }

        private void bSpeechAdd_Click(object sender, EventArgs e)
        {
            Macros.SpeechAddName = speechName.Text;
            Close();
        }


        private void bSetCurDoc_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.speechDoc = Globals.ThisAddIn.Application.Windows[curDocsList.SelectedIndex + 1].Document;
            Macros.SpeechAddName = "current";
            Close();
        }


        private void speechName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString() == "Escape")
                Close();
        }

      

        private void bReadOnline_Click(object sender, EventArgs e)
        {
              Macros.uploadSpeech();
          
        }

        private void bReadOffline_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.Application.ActiveWindow.ActivePane.View.Type = WdViewType.wdReadingView;
            Globals.ThisAddIn.Application.ActiveWindow.ActivePane.Document.ActiveWindow.DocumentMap = true;
            Globals.ThisAddIn.Application.ActiveWindow.ActivePane.View.ReadingLayoutAllowMultiplePages = false;
        }


        private void bUSB_Click(object sender, EventArgs e)
        {
            Application a = Globals.ThisAddIn.Application;
            a.ActiveDocument.Save();
            string msg = a.ActiveDocument.FullName + " Saved \r\n";
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
            string timerPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
                               + "\\Debate Sidebar Word Addin\\DebateTimer.exe";

            if (File.Exists(timerPath))
            {
                Process.Start(timerPath);
            }
        }
    }
}