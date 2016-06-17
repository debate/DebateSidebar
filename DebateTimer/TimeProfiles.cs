using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DebateTimer.Properties;

namespace DebateTimer
{
    public class TimeProfiles : Form
    {
        private readonly IContainer components = null;
        internal Label Label1;
        internal Label Label3;
        internal Label Label4;
        internal Button buttonDefaults;
        internal Button buttonOK;
        internal NumericUpDown p1c;
        internal NumericUpDown p1p;
        internal Label p1plabel;
        internal NumericUpDown p1r;
        internal NumericUpDown p1x;

        public TimeProfiles()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void buttonDefaults_Click(object sender, EventArgs e)
        {
            p1p.Value = 8M;
            p1c.Value = 8M;
            p1r.Value = 5M;
            p1x.Value = 3M;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.p1c = (int) p1c.Value;
            settings.p1p = (int) p1p.Value;
            settings.p1x = (int) p1x.Value;
            settings.p1r = (int) p1r.Value;
            base.Close();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing & (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            buttonDefaults = new Button();
            p1r = new NumericUpDown();
            p1x = new NumericUpDown();
            p1p = new NumericUpDown();
            p1c = new NumericUpDown();
            buttonOK = new Button();
            Label4 = new Label();
            Label3 = new Label();
            p1plabel = new Label();
            Label1 = new Label();
            p1r.BeginInit();
            p1x.BeginInit();
            p1p.BeginInit();
            p1c.BeginInit();
            base.SuspendLayout();
            buttonDefaults.Font = new Font("Tahoma", 8.25f);
            buttonDefaults.Location = new Point(10, 0x7c);
            buttonDefaults.Name = "buttonDefaults";
            buttonDefaults.Size = new Size(60, 0x17);
            buttonDefaults.TabIndex = 0x2a;
            buttonDefaults.Text = "Defaults";
            buttonDefaults.UseVisualStyleBackColor = true;
            buttonDefaults.Click += buttonDefaults_Click;
            p1r.Font = new Font("Tahoma", 8.25f);
            p1r.Location = new Point(0x56, 40);
            var bits = new int[4];
            bits[0] = 60;
            p1r.Maximum = new decimal(bits);
            p1r.Name = "p1r";
            p1r.Size = new Size(40, 0x15);
            p1r.TabIndex = 0x23;
            var bits2 = new int[4];
            bits2[0] = 5;
            p1r.Value = new decimal(bits2);
            p1x.Font = new Font("Tahoma", 8.25f);
            p1x.Location = new Point(0x56, 0x42);
            var bits3 = new int[4];
            bits3[0] = 60;
            p1x.Maximum = new decimal(bits3);
            p1x.Name = "p1x";
            p1x.Size = new Size(40, 0x15);
            p1x.TabIndex = 0x22;
            var bits4 = new int[4];
            bits4[0] = 3;
            p1x.Value = new decimal(bits4);
            p1p.Font = new Font("Tahoma", 8.25f);
            p1p.Location = new Point(0x56, 0x5c);
            var bits5 = new int[4];
            bits5[0] = 60;
            p1p.Maximum = new decimal(bits5);
            p1p.Name = "p1p";
            p1p.Size = new Size(40, 0x15);
            p1p.TabIndex = 0x21;
            var bits6 = new int[4];
            bits6[0] = 8;
            p1p.Value = new decimal(bits6);
            p1c.Font = new Font("Tahoma", 8.25f);
            p1c.Location = new Point(0x56, 14);
            var bits7 = new int[4];
            bits7[0] = 60;
            p1c.Maximum = new decimal(bits7);
            p1c.Name = "p1c";
            p1c.Size = new Size(40, 0x15);
            p1c.TabIndex = 0x20;
            var bits8 = new int[4];
            bits8[0] = 8;
            p1c.Value = new decimal(bits8);
            buttonOK.Font = new Font("Tahoma", 8.25f);
            buttonOK.Location = new Point(0x51, 0x7c);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(60, 0x17);
            buttonOK.TabIndex = 0x1f;
            buttonOK.Text = "Ok";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            Label4.AutoSize = true;
            Label4.Font = new Font("Tahoma", 8.25f);
            Label4.Location = new Point(12, 0x2c);
            Label4.Name = "Label4";
            Label4.Size = new Size(0x34, 13);
            Label4.TabIndex = 0x1d;
            Label4.Text = "Rebuttal:";
            Label3.AutoSize = true;
            Label3.Font = new Font("Tahoma", 8.25f);
            Label3.Location = new Point(12, 70);
            Label3.Name = "Label3";
            Label3.Size = new Size(0x30, 13);
            Label3.TabIndex = 0x1c;
            Label3.Text = "Cross-x:";
            p1plabel.AutoSize = true;
            p1plabel.Font = new Font("Tahoma", 8.25f);
            p1plabel.Location = new Point(12, 0x60);
            p1plabel.Name = "p1plabel";
            p1plabel.Size = new Size(0x3a, 13);
            p1plabel.TabIndex = 0x1b;
            p1plabel.Text = "Prep Time:";
            Label1.AutoSize = true;
            Label1.Font = new Font("Tahoma", 8.25f);
            Label1.Location = new Point(12, 0x12);
            Label1.Name = "Label1";
            Label1.Size = new Size(0x48, 13);
            Label1.TabIndex = 0x1a;
            Label1.Text = "Constructive:";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.ClientSize = new Size(0xae, 0x98);
            base.Controls.Add(buttonDefaults);
            base.Controls.Add(p1r);
            base.Controls.Add(p1x);
            base.Controls.Add(p1p);
            base.Controls.Add(p1c);
            base.Controls.Add(buttonOK);
            base.Controls.Add(Label4);
            base.Controls.Add(Label3);
            base.Controls.Add(p1plabel);
            base.Controls.Add(Label1);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "TimeProfiles";
            base.ShowIcon = false;
            Text = "Configure";
            base.Load += TimeProfiles_Load;
            p1r.EndInit();
            p1x.EndInit();
            p1p.EndInit();
            p1c.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void TimeProfiles_Load(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            p1c.Value = settings.p1c;
            p1p.Value = settings.p1p;
            p1x.Value = settings.p1x;
            p1r.Value = settings.p1r;
        }
    }
}