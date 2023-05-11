namespace DebateSidebarWordAddIn
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
       

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dialogFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.bOK = new System.Windows.Forms.Button();
            this.dialogFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bShowOnlyHeading1 = new System.Windows.Forms.CheckBox();
            this.bOpenWeb = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.k2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.k4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.k3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.k1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bTemplatePath = new System.Windows.Forms.TextBox();
            this.bTemplateChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bTubPath = new System.Windows.Forms.TextBox();
            this.bTubChange = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bOK
            // 
            this.bOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOK.Location = new System.Drawing.Point(231, 363);
            this.bOK.Margin = new System.Windows.Forms.Padding(4);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(100, 28);
            this.bOK.TabIndex = 4;
            this.bOK.Text = "OK";
            this.bOK.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // dialogFile
            // 
            this.dialogFile.Filter = "Word Template|*.dotm|All files (*.*)|*.*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bTemplatePath);
            this.groupBox1.Controls.Add(this.bTemplateChange);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bTubPath);
            this.groupBox1.Controls.Add(this.bTubChange);
            this.groupBox1.Controls.Add(this.bShowOnlyHeading1);
            this.groupBox1.Controls.Add(this.bOpenWeb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(565, 161);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // bShowOnlyHeading1
            // 
            this.bShowOnlyHeading1.AutoSize = true;
            this.bShowOnlyHeading1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bShowOnlyHeading1.Location = new System.Drawing.Point(15, 53);
            this.bShowOnlyHeading1.Margin = new System.Windows.Forms.Padding(4);
            this.bShowOnlyHeading1.Name = "bShowOnlyHeading1";
            this.bShowOnlyHeading1.Size = new System.Drawing.Size(286, 21);
            this.bShowOnlyHeading1.TabIndex = 15;
            this.bShowOnlyHeading1.Text = "Document Map fully expanded by default";
            this.bShowOnlyHeading1.UseVisualStyleBackColor = true;
            // 
            // bOpenWeb
            // 
            this.bOpenWeb.AutoSize = true;
            this.bOpenWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOpenWeb.Location = new System.Drawing.Point(15, 24);
            this.bOpenWeb.Margin = new System.Windows.Forms.Padding(4);
            this.bOpenWeb.Name = "bOpenWeb";
            this.bOpenWeb.Size = new System.Drawing.Size(181, 21);
            this.bOpenWeb.TabIndex = 5;
            this.bOpenWeb.Text = "Show sidebar by default";
            this.bOpenWeb.UseVisualStyleBackColor = true;
            this.bOpenWeb.CheckedChanged += new System.EventHandler(this.bOpenWeb_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.k2);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.k4);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.k3);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.k1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(21, 181);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(565, 174);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Keyboard Shortcuts";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(197, 31);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 17);
            this.label12.TabIndex = 17;
            // 
            // k2
            // 
            this.k2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k2.Location = new System.Drawing.Point(96, 60);
            this.k2.Margin = new System.Windows.Forms.Padding(4);
            this.k2.Name = "k2";
            this.k2.Size = new System.Drawing.Size(93, 23);
            this.k2.TabIndex = 16;
            this.k2.TabStop = false;
            this.k2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kMouseClick);
            this.k2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kKeyDown);
            this.k2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kKeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Collapse";
            // 
            // k4
            // 
            this.k4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k4.Location = new System.Drawing.Point(96, 115);
            this.k4.Margin = new System.Windows.Forms.Padding(4);
            this.k4.Name = "k4";
            this.k4.Size = new System.Drawing.Size(93, 23);
            this.k4.TabIndex = 14;
            this.k4.TabStop = false;
            this.k4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kMouseClick);
            this.k4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kKeyDown);
            this.k4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kKeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Expand";
            // 
            // k3
            // 
            this.k3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k3.Location = new System.Drawing.Point(96, 87);
            this.k3.Margin = new System.Windows.Forms.Padding(4);
            this.k3.Name = "k3";
            this.k3.Size = new System.Drawing.Size(93, 23);
            this.k3.TabIndex = 12;
            this.k3.TabStop = false;
            this.k3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kMouseClick);
            this.k3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kKeyDown);
            this.k3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kKeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Refresh";
            // 
            // k1
            // 
            this.k1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k1.Location = new System.Drawing.Point(96, 32);
            this.k1.Margin = new System.Windows.Forms.Padding(4);
            this.k1.Name = "k1";
            this.k1.Size = new System.Drawing.Size(93, 23);
            this.k1.TabIndex = 8;
            this.k1.TabStop = false;
            this.k1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kMouseClick);
            this.k1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kKeyDown);
            this.k1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kKeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Switch View";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Attach .dotm template to all files";
            // 
            // bTemplatePath
            // 
            this.bTemplatePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTemplatePath.Location = new System.Drawing.Point(232, 118);
            this.bTemplatePath.Margin = new System.Windows.Forms.Padding(4);
            this.bTemplatePath.Name = "bTemplatePath";
            this.bTemplatePath.Size = new System.Drawing.Size(233, 23);
            this.bTemplatePath.TabIndex = 29;
            // 
            // bTemplateChange
            // 
            this.bTemplateChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTemplateChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTemplateChange.Location = new System.Drawing.Point(474, 116);
            this.bTemplateChange.Margin = new System.Windows.Forms.Padding(4);
            this.bTemplateChange.Name = "bTemplateChange";
            this.bTemplateChange.Size = new System.Drawing.Size(77, 28);
            this.bTemplateChange.TabIndex = 28;
            this.bTemplateChange.Text = "Change";
            this.bTemplateChange.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Debate Files";
            // 
            // bTubPath
            // 
            this.bTubPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTubPath.Location = new System.Drawing.Point(101, 83);
            this.bTubPath.Margin = new System.Windows.Forms.Padding(4);
            this.bTubPath.Name = "bTubPath";
            this.bTubPath.Size = new System.Drawing.Size(365, 23);
            this.bTubPath.TabIndex = 27;
            // 
            // bTubChange
            // 
            this.bTubChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTubChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTubChange.Location = new System.Drawing.Point(474, 80);
            this.bTubChange.Margin = new System.Windows.Forms.Padding(4);
            this.bTubChange.Name = "bTubChange";
            this.bTubChange.Size = new System.Drawing.Size(77, 28);
            this.bTubChange.TabIndex = 25;
            this.bTubChange.Text = "Change";
            this.bTubChange.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(312, 60);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 23);
            this.textBox1.TabIndex = 25;
            this.textBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Heading 2";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(312, 115);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(93, 23);
            this.textBox2.TabIndex = 23;
            this.textBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(229, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Heading 3";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(312, 87);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(93, 23);
            this.textBox3.TabIndex = 21;
            this.textBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(229, 119);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Heading 4";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(312, 32);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(93, 23);
            this.textBox4.TabIndex = 19;
            this.textBox4.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(229, 36);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Heading 1";
            // 
            // Settings
            // 
            this.AcceptButton = this.bOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 405);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Debate Sidebar Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog dialogFolder;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.OpenFileDialog dialogFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox bShowOnlyHeading1;
        private System.Windows.Forms.CheckBox bOpenWeb;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox k2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox k4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox k3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox k1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bTemplatePath;
        private System.Windows.Forms.Button bTemplateChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bTubPath;
        private System.Windows.Forms.Button bTubChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
    }
}