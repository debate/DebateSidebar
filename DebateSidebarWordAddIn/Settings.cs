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

            Globals.ThisAddIn.isSettingsOpen = true;


        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {

            Globals.ThisAddIn.isSettingsOpen = false;


            

            s.Save();
        }

        private void bOK_Click(object sender, EventArgs e)
        {

            Close();
        }

        //Folders

        private void bFilesChange_Click(object sender, EventArgs e)
        {
             if (dialogFolder.ShowDialog() == DialogResult.OK){
                bTubPath.Text = dialogFolder.SelectedPath;
                Properties.Settings.Default.FilesDirectory = dialogFolder.SelectedPath;

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

        //Styles

        private void bOpenTemplate_Click(object sender, EventArgs e)
        {
            if (dialogFile.ShowDialog() == DialogResult.OK)
                bTemplatePath.Text = dialogFile.FileName;
        }

        private void bOpenWeb_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}