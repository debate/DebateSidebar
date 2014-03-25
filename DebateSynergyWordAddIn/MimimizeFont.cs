 using System;
using System.Collections.Generic;
using System.ComponentModel;
 using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebateSynergyWordAddIn
{
    public partial class MimimizeFont : Form
    {
        public MimimizeFont()
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
