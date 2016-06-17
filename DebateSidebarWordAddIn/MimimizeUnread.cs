using System;
using System.Windows.Forms;

namespace DebateSidebarWordAddIn
{
    public partial class MimimizeUnread : Form
    {
        public MimimizeUnread()
        {
            InitializeComponent();
        }

        private void MimimizeFont_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MinimizeUnreadSize = Convert.ToInt32(fontSize.Text);
            Close();
        }
    }
}