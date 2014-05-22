using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace DebateSidebarWordAddIn
{
    public partial class Settings : Form
    {
        private Properties.Settings s = Properties.Settings.Default;
        private string k;

        //LOAD & OK

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

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


            fontSize.Text = s.MinimizeUnreadSize.ToString();
            bHotkeys.Checked = true;
            bHotkeys.Checked = s.Hotkeys;
            bUnderlineBold.Checked = s.UnderlineBold;
            bFontName.Text = s.FontName;
            bFontSize.Text = s.FontSize;
            bUploadSpeech.Checked = s.UploadSpeech;
            bPreserveParagraphs.Checked = s.PreserveParagraphs;
            bShowOnlyHeading1.Checked = s.ExpandHeadings;
            bTubPath.Text = s.FilesDirectory;
            bSpeechPath.Text = s.SpeechDirectory;
            bOpenWeb.Checked = s.Enabled;
            bHotkeys.Checked = s.Hotkeys;
            bHeadingLevels.Text = s.HeadingLevels;
            bBoxHeading1.Checked = s.BoxHeading1;

            foreach (FontFamily family in new InstalledFontCollection().Families)
                bFontName.Items.Add(family.Name);
            

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

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {

            Globals.ThisAddIn.isSettingsOpen = false;


            s.MinimizeUnreadSize = Convert.ToInt32(fontSize.Text);
            s.Hotkeys = bHotkeys.Checked;
            s.UnderlineBold = bUnderlineBold.Checked;
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
            s.ExpandHeadings = bShowOnlyHeading1.Checked;
            s.BoxHeading1 = bBoxHeading1.Checked;

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


            s.Save();
        }

        private void bOK_Click(object sender, EventArgs e)
        {

            Close();
        }

        //Folders

        private void bFilesChange_Click(object sender, EventArgs e)
        {
            if (dialogFolder.ShowDialog() == DialogResult.OK)
                bTubPath.Text = dialogFolder.SelectedPath;
        }

        private void bSpeechChange_Click(object sender, EventArgs e)
        {
            if (dialogFolder.ShowDialog() == DialogResult.OK)
                bSpeechPath.Text = dialogFolder.SelectedPath;

        }
        
        //Keyboard

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

        //Styles

        private void bOpenTemplate_Click(object sender, EventArgs e)
        {
            if (dialogFile.ShowDialog() == DialogResult.OK)
                bTemplatePath.Text = dialogFile.FileName;
        }

        private void bTemplateCustom_CheckedChanged(object sender, EventArgs e)
        {
            bTemplateChange.Enabled = bTemplateCustom.Checked;
            bTemplatePath.Text = "";
            bTemplatePath.Enabled = bTemplateCustom.Checked;
            bFontName.Enabled = !bTemplateCustom.Checked;
            bFontSize.Enabled = !bTemplateCustom.Checked;
            bBoxHeading1.Enabled = !bTemplateCustom.Checked;
            bUnderlineBold.Enabled = !bTemplateCustom.Checked;
        }

    }
}