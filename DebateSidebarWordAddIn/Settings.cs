using System;
using System.Linq;
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

            comboBox1.SelectedIndex = s.HeadingLevels - 1;
            bReindexAutoOpen.Checked = s.ExpandHeadings;

            k1.Text = s.k1;
            k2.Text = s.k2;
            k3.Text = s.k3;

        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {

            Globals.ThisAddIn.isSettingsOpen = false;

            s.k1 = k1.Text;
            s.k2 = k2.Text;
            s.k3 = k3.Text;


            s.Save();
        }

        private void bOK_Click(object sender, EventArgs e)
        {

            Close();
        }

        //Folders

        private void bFilesChange_Click(object sender, EventArgs e)
        {

            var dialogFolder = new FolderBrowserDialog();

            if (dialogFolder.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.FilesDirectory = dialogFolder.SelectedPath;

                Properties.Settings.Default.Save();
            }
        }




        private void kKeyDown(object sender, KeyEventArgs e)
        {
            k = e.KeyData.ToString();
        }

        private void kKeyUp(object sender, KeyEventArgs e)
        {
            ((TextBox)sender).Text = k;
        }

        private void kMouseClick(object sender, MouseEventArgs e)
        {
            Globals.ThisAddIn.isSettingsOpen = true;

            ((TextBox)sender).Text = "";
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = (string)comboBox1.SelectedItem;

            s.HeadingLevels = Int32.Parse(selected.Last().ToString());
            s.Save();



        }

        private void bReindexAutoOpen_CheckedChanged(object sender, EventArgs e)
        {
            s.ExpandHeadings = bReindexAutoOpen.Checked;

            s.Save();


        }
    }
}