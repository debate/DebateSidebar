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

            //bReindexAutoOpen.Checked = s.ExpandHeadings;

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



        private void bFilesChange_Click(object sender, EventArgs e)
        {
            if (dialogFolder.ShowDialog() == DialogResult.OK)
                s.FilesDirectory = dialogFolder.SelectedPath;
        }


        private void bOK_Click(object sender, EventArgs e)
        {

            Close();
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


     

        private void bReindexAutoOpen_CheckedChanged(object sender, EventArgs e)
        {
           // s.ExpandHeadings = bReindexAutoOpen.Checked;

            s.Save();


        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            s.SelectAfterDocMap = checkBox3.Checked;

            s.Save();
            


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {


        }
    }
}