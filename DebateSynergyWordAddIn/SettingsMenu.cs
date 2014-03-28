using System;
using System.Drawing;
using System.Windows.Forms;

namespace DebateSynergyWordAddIn
{
    public partial class SettingsMenu : Form
    {
        private Properties.Settings s = Properties.Settings.Default;
        public SettingsMenu()
        {
           
            InitializeComponent();


            if (s.OpenTemplate.Length > 0)
            {
                bTemplateCustom.Checked = true;
                bTemplatePath.Text = s.OpenTemplate;
            }
            else
            {
                bTemplatePath.Enabled = false;
                bTemplateChange.Enabled = false;
            }


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

            System.Drawing.Text.InstalledFontCollection fonts = new System.Drawing.Text.InstalledFontCollection();
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
            s.k10= k10.Text;
            s.k11= k11.Text;
            s.k12= k12.Text;


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

            this.Close();
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


      
        private void bCancel_Click(object sender, EventArgs e)
        {

            Globals.ThisAddIn.isSettingsOpen = false;
            this.Close();
        }


        private void bTemplateCustom_CheckedChanged(object sender, EventArgs e)
        {
            bTemplateChange.Enabled = bTemplateCustom.Checked;
            bTemplatePath.Text = "";
            bTemplatePath.Enabled = bTemplateCustom.Checked;

            bFontName.Enabled = !bTemplateCustom.Checked;

            bFontSize.Enabled = !bTemplateCustom.Checked;
            labelNormal.Enabled = !bTemplateCustom.Checked;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                bSpeechPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

       
        private string k;
        private void kKeyDown(object sender, KeyEventArgs e)
        {

            k = e.KeyData.ToString();;
        }

        private void kKeyUp(object sender, KeyEventArgs e)
        {
            ((TextBox)sender).Text = k;
        }

        private void kMouseClick(object sender, MouseEventArgs e)
        {

            Globals.ThisAddIn.isSettingsOpen = true;

            ((TextBox) sender).Text = "";
        }

     
      
    }
}
