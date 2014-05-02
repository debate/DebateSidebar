using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace DebateSidebarWordAddIn
{
    public partial class Settings : Form
    {
        private readonly Properties.Settings s = Properties.Settings.Default;
        private string k;

        public Settings()
        {
            InitializeComponent();


            if (s.OpenTemplate.Length > 0)
            {
                bTemplateCustom.Checked = true;
                bTemplatePath.Text = s.OpenTemplate;
            }
            else
            {
                bTemplateNormal.PerformClick();
                bTemplateNormal.Checked = true;
                bTemplatePath.Enabled = false;
                bTemplateChange.Enabled = false;
            }


            bHotkeys.Checked = true;
            bHotkeys.Checked = s.Hotkeys;
            bUnderlineBold.Checked = s.UnderlineBold;
            bMinimizeUnread.Checked = s.MinimizeUnread;
            bFontName.Text = s.FontName;
            bFontSize.Text = s.FontSize;

            bUploadSpeech.Checked = s.UploadSpeech;
            bPreserveParagraphs.Checked = s.PreserveParagraphs;

            bShowOnlyHeading1.Checked = s.ShowHeading1;

            bTubPath.Text = s.FilesDirectory;
            bSpeechPath.Text = s.SpeechDirectory;

            bOpenWeb.Checked = s.Enabled;
            bHotkeys.Checked = s.Hotkeys;

            bHeadingLevels.Text = s.HeadingLevels;

            var fonts = new InstalledFontCollection();
            foreach (FontFamily family in fonts.Families)
            {
                bFontName.Items.Add(family.Name);
            }


            k1.Text = s.k1;
            k2.Text = s.k2;
            k3.Text = s.k3;
            k4.Text = s.k4;
            k5.Text = s.k5;
            k6.Text = s.k6;
            k7.Text = s.k7;
            k8.Text = s.k8;
            k9.Text = s.k9;
            k10.Text = s.k10;
            k11.Text = s.k11;
            k12.Text = s.k12;
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Globals.ThisAddIn.CustomTaskPanes.Count; i++)
                if (Globals.ThisAddIn.CustomTaskPanes[i].Window != null
                    &&
                    Globals.ThisAddIn.CustomTaskPanes[i].Window.Equals(
                        Globals.ThisAddIn.Application.ActiveDocument.ActiveWindow))
                {
                    Properties.Settings.Default.PanelWidth = Globals.ThisAddIn.CustomTaskPanes[i].Width;
                    Properties.Settings.Default.PanelPosition = Globals.ThisAddIn.CustomTaskPanes[i].DockPosition;
                    break;
                }


            Globals.ThisAddIn.isSettingsOpen = false;

            s.k1 = k1.Text;
            s.k2 = k2.Text;
            s.k3 = k3.Text;
            s.k4 = k4.Text;
            s.k5 = k5.Text;
            s.k6 = k6.Text;
            s.k7 = k7.Text;
            s.k8 = k8.Text;
            s.k9 = k9.Text;
            s.k10 = k10.Text;
            s.k11 = k11.Text;
            s.k12 = k12.Text;


            s.Hotkeys = bHotkeys.Checked;
            s.UnderlineBold = bUnderlineBold.Checked;
            s.MinimizeUnread = bMinimizeUnread.Checked;
            s.UploadSpeech = bUploadSpeech.Checked;
            s.PreserveParagraphs = bPreserveParagraphs.Checked;

            s.FontName = bFontName.Text;
            s.FontSize = bFontSize.Text;

            s.OpenTemplate = bTemplatePath.Text;
            s.FilesDirectory = bTubPath.Text;

            s.SpeechDirectory = bSpeechPath.Text;

            s.Enabled = bOpenWeb.Checked;

            s.HeadingLevels = bHeadingLevels.Text;
            s.Hotkeys = bHotkeys.Checked;

            s.ShowHeading1 = bShowOnlyHeading1.Checked;

            s.Save();

            Close();
        }


        private void tubChange_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                bTubPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }


        private void bOpenTemplate_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bTemplatePath.Text = openFileDialog1.FileName;
            }
        }



        private void bTemplateCustom_CheckedChanged(object sender, EventArgs e)
        {
            bTemplateChange.Enabled = bTemplateCustom.Checked;
            bTemplatePath.Text = "";
            bTemplatePath.Enabled = bTemplateCustom.Checked;

            bFontName.Enabled = !bTemplateCustom.Checked;

            bFontSize.Enabled = !bTemplateCustom.Checked;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                bSpeechPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }


        private void kKeyDown(object sender, KeyEventArgs e)
        {
            k = e.KeyData.ToString();
        }

        private void kKeyUp(object sender, KeyEventArgs e)
        {
            ((TextBox) sender).Text = k;
        }

        private void kMouseClick(object sender, MouseEventArgs e)
        {
            Globals.ThisAddIn.isSettingsOpen = true;

            ((TextBox) sender).Text = "";
        }

        private void bHotkeys_CheckedChanged(object sender, EventArgs e)
        {
            k1.Enabled = bHotkeys.Checked;
            k2.Enabled = bHotkeys.Checked;
            k3.Enabled = bHotkeys.Checked;
            k4.Enabled = bHotkeys.Checked;
            k5.Enabled = bHotkeys.Checked;
            k6.Enabled = bHotkeys.Checked;
            k7.Enabled = bHotkeys.Checked;
            k8.Enabled = bHotkeys.Checked;
            k9.Enabled = bHotkeys.Checked;
            k10.Enabled = bHotkeys.Checked;
            k11.Enabled = bHotkeys.Checked;
            k12.Enabled = bHotkeys.Checked;
        }
    }
}