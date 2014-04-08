using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace DebateSidebarWordAddIn
{
    public partial class SpeechAdd : Form
    {
        public SpeechAdd()
        {
            InitializeComponent();
        }


        private void SpeechAdd_Load(object sender, EventArgs e)
        {


            Macros.SpeechAddName = "";

            populateName();

            foreach ( Window win in Globals.ThisAddIn.Application.Windows)
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

            buttonName = r1.Checked ? r1.Text : r2.Checked ? r2.Text :  r3.Checked ? r3.Text : 
                r4.Checked ? r4.Text : r5.Checked ? r5.Text :  r6.Checked ? r6.Text : r7.Checked ? r7.Text : "";

             
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
            this.Close();
        }

        private void SpeechAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void bSetCurDoc_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.speechDoc = Globals.ThisAddIn.Application.Windows[curDocsList.SelectedIndex+1].Document;
            Macros.SpeechAddName = "current";
            this.Close();

        }

      
        private void speechName_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData.ToString() == "Escape")
                this.Close();
        }
    }
}
