using DebateTimer.Properties;

namespace DebateTimer
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class TimeProfiles : Form
    {
        internal Button buttonDefaults;
        internal Button buttonOK;
        private IContainer components = null;
        internal Label Label1;
        internal Label Label3;
        internal Label Label4;
        internal NumericUpDown p1c;
        internal NumericUpDown p1p;
        internal Label p1plabel;
        internal NumericUpDown p1r;
        internal NumericUpDown p1x;

        public TimeProfiles()
        {
            this.InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void buttonDefaults_Click(object sender, EventArgs e)
        {
            this.p1p.Value = 8M;
            this.p1c.Value = 8M;
            this.p1r.Value = 5M;
            this.p1x.Value = 3M;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.p1c = (int) this.p1c.Value;
            settings.p1p = (int) this.p1p.Value;
            settings.p1x = (int) this.p1x.Value;
            settings.p1r = (int) this.p1r.Value;
            base.Close();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing & (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonDefaults = new Button();
            this.p1r = new NumericUpDown();
            this.p1x = new NumericUpDown();
            this.p1p = new NumericUpDown();
            this.p1c = new NumericUpDown();
            this.buttonOK = new Button();
            this.Label4 = new Label();
            this.Label3 = new Label();
            this.p1plabel = new Label();
            this.Label1 = new Label();
            this.p1r.BeginInit();
            this.p1x.BeginInit();
            this.p1p.BeginInit();
            this.p1c.BeginInit();
            base.SuspendLayout();
            this.buttonDefaults.Font = new Font("Tahoma", 8.25f);
            this.buttonDefaults.Location = new Point(10, 0x7c);
            this.buttonDefaults.Name = "buttonDefaults";
            this.buttonDefaults.Size = new Size(60, 0x17);
            this.buttonDefaults.TabIndex = 0x2a;
            this.buttonDefaults.Text = "Defaults";
            this.buttonDefaults.UseVisualStyleBackColor = true;
            this.buttonDefaults.Click += new EventHandler(this.buttonDefaults_Click);
            this.p1r.Font = new Font("Tahoma", 8.25f);
            this.p1r.Location = new Point(0x56, 40);
            int[] bits = new int[4];
            bits[0] = 60;
            this.p1r.Maximum = new decimal(bits);
            this.p1r.Name = "p1r";
            this.p1r.Size = new Size(40, 0x15);
            this.p1r.TabIndex = 0x23;
            int[] bits2 = new int[4];
            bits2[0] = 5;
            this.p1r.Value = new decimal(bits2);
            this.p1x.Font = new Font("Tahoma", 8.25f);
            this.p1x.Location = new Point(0x56, 0x42);
            int[] bits3 = new int[4];
            bits3[0] = 60;
            this.p1x.Maximum = new decimal(bits3);
            this.p1x.Name = "p1x";
            this.p1x.Size = new Size(40, 0x15);
            this.p1x.TabIndex = 0x22;
            int[] bits4 = new int[4];
            bits4[0] = 3;
            this.p1x.Value = new decimal(bits4);
            this.p1p.Font = new Font("Tahoma", 8.25f);
            this.p1p.Location = new Point(0x56, 0x5c);
            int[] bits5 = new int[4];
            bits5[0] = 60;
            this.p1p.Maximum = new decimal(bits5);
            this.p1p.Name = "p1p";
            this.p1p.Size = new Size(40, 0x15);
            this.p1p.TabIndex = 0x21;
            int[] bits6 = new int[4];
            bits6[0] = 8;
            this.p1p.Value = new decimal(bits6);
            this.p1c.Font = new Font("Tahoma", 8.25f);
            this.p1c.Location = new Point(0x56, 14);
            int[] bits7 = new int[4];
            bits7[0] = 60;
            this.p1c.Maximum = new decimal(bits7);
            this.p1c.Name = "p1c";
            this.p1c.Size = new Size(40, 0x15);
            this.p1c.TabIndex = 0x20;
            int[] bits8 = new int[4];
            bits8[0] = 8;
            this.p1c.Value = new decimal(bits8);
            this.buttonOK.Font = new Font("Tahoma", 8.25f);
            this.buttonOK.Location = new Point(0x51, 0x7c);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new Size(60, 0x17);
            this.buttonOK.TabIndex = 0x1f;
            this.buttonOK.Text = "Ok";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new EventHandler(this.buttonOK_Click);
            this.Label4.AutoSize = true;
            this.Label4.Font = new Font("Tahoma", 8.25f);
            this.Label4.Location = new Point(12, 0x2c);
            this.Label4.Name = "Label4";
            this.Label4.Size = new Size(0x34, 13);
            this.Label4.TabIndex = 0x1d;
            this.Label4.Text = "Rebuttal:";
            this.Label3.AutoSize = true;
            this.Label3.Font = new Font("Tahoma", 8.25f);
            this.Label3.Location = new Point(12, 70);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(0x30, 13);
            this.Label3.TabIndex = 0x1c;
            this.Label3.Text = "Cross-x:";
            this.p1plabel.AutoSize = true;
            this.p1plabel.Font = new Font("Tahoma", 8.25f);
            this.p1plabel.Location = new Point(12, 0x60);
            this.p1plabel.Name = "p1plabel";
            this.p1plabel.Size = new Size(0x3a, 13);
            this.p1plabel.TabIndex = 0x1b;
            this.p1plabel.Text = "Prep Time:";
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Tahoma", 8.25f);
            this.Label1.Location = new Point(12, 0x12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x48, 13);
            this.Label1.TabIndex = 0x1a;
            this.Label1.Text = "Constructive:";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.ClientSize = new Size(0xae, 0x98);
            base.Controls.Add(this.buttonDefaults);
            base.Controls.Add(this.p1r);
            base.Controls.Add(this.p1x);
            base.Controls.Add(this.p1p);
            base.Controls.Add(this.p1c);
            base.Controls.Add(this.buttonOK);
            base.Controls.Add(this.Label4);
            base.Controls.Add(this.Label3);
            base.Controls.Add(this.p1plabel);
            base.Controls.Add(this.Label1);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "TimeProfiles";
            base.ShowIcon = false;
            this.Text = "Configure";
            base.Load += new EventHandler(this.TimeProfiles_Load);
            this.p1r.EndInit();
            this.p1x.EndInit();
            this.p1p.EndInit();
            this.p1c.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void TimeProfiles_Load(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            this.p1c.Value = settings.p1c;
            this.p1p.Value = settings.p1p;
            this.p1x.Value = settings.p1x;
            this.p1r.Value = settings.p1r;
        }
    }
}

