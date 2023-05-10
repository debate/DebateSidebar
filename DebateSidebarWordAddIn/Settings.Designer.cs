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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bTubPath = new System.Windows.Forms.TextBox();
            this.bTubChange = new System.Windows.Forms.Button();
            this.bHotkeys = new System.Windows.Forms.CheckBox();
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
            this.bTemplatePath = new System.Windows.Forms.TextBox();
            this.bTemplateCustom = new System.Windows.Forms.RadioButton();
            this.bTemplateChange = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bOK
            // 
            this.bOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOK.Location = new System.Drawing.Point(243, 454);
            this.bOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.groupBox1.Controls.Add(this.bTemplatePath);
            this.groupBox1.Controls.Add(this.bTemplateCustom);
            this.groupBox1.Controls.Add(this.bTemplateChange);
            this.groupBox1.Controls.Add(this.bShowOnlyHeading1);
            this.groupBox1.Controls.Add(this.bOpenWeb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(565, 137);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main";
            // 
            // bShowOnlyHeading1
            // 
            this.bShowOnlyHeading1.AutoSize = true;
            this.bShowOnlyHeading1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bShowOnlyHeading1.Location = new System.Drawing.Point(8, 66);
            this.bShowOnlyHeading1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bShowOnlyHeading1.Name = "bShowOnlyHeading1";
            this.bShowOnlyHeading1.Size = new System.Drawing.Size(280, 21);
            this.bShowOnlyHeading1.TabIndex = 15;
            this.bShowOnlyHeading1.Text = "Headings Index will open fully expanded";
            this.bShowOnlyHeading1.UseVisualStyleBackColor = true;
            // 
            // bOpenWeb
            // 
            this.bOpenWeb.AutoSize = true;
            this.bOpenWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOpenWeb.Location = new System.Drawing.Point(8, 44);
            this.bOpenWeb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bOpenWeb.Name = "bOpenWeb";
            this.bOpenWeb.Size = new System.Drawing.Size(380, 21);
            this.bOpenWeb.TabIndex = 5;
            this.bOpenWeb.Text = "Show sidebar and custom styles on opening documents";
            this.bOpenWeb.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bTubPath);
            this.groupBox2.Controls.Add(this.bTubChange);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 150);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(565, 121);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Folders";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Debate Files";
            // 
            // bTubPath
            // 
            this.bTubPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTubPath.Location = new System.Drawing.Point(12, 43);
            this.bTubPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bTubPath.Name = "bTubPath";
            this.bTubPath.Size = new System.Drawing.Size(365, 23);
            this.bTubPath.TabIndex = 3;
            // 
            // bTubChange
            // 
            this.bTubChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTubChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTubChange.Location = new System.Drawing.Point(387, 41);
            this.bTubChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bTubChange.Name = "bTubChange";
            this.bTubChange.Size = new System.Drawing.Size(77, 28);
            this.bTubChange.TabIndex = 0;
            this.bTubChange.Text = "Change";
            this.bTubChange.UseVisualStyleBackColor = true;
            this.bTubChange.Click += new System.EventHandler(this.bFilesChange_Click);
            // 
            // bHotkeys
            // 
            this.bHotkeys.AutoSize = true;
            this.bHotkeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHotkeys.Location = new System.Drawing.Point(12, 25);
            this.bHotkeys.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bHotkeys.Name = "bHotkeys";
            this.bHotkeys.Size = new System.Drawing.Size(199, 21);
            this.bHotkeys.TabIndex = 6;
            this.bHotkeys.Text = "Enable keyboard shortcuts";
            this.bHotkeys.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.k2);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.k4);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.k3);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.k1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.bHotkeys);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(19, 272);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(565, 174);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Keyboard";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(196, 49);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 17);
            this.label12.TabIndex = 17;
            // 
            // k2
            // 
            this.k2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k2.Location = new System.Drawing.Point(95, 78);
            this.k2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.label9.Location = new System.Drawing.Point(12, 81);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Highlight";
            // 
            // k4
            // 
            this.k4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k4.Location = new System.Drawing.Point(95, 133);
            this.k4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.label8.Location = new System.Drawing.Point(12, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Paste Text";
            // 
            // k3
            // 
            this.k3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k3.Location = new System.Drawing.Point(95, 105);
            this.k3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.label7.Location = new System.Drawing.Point(12, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Returns";
            // 
            // k1
            // 
            this.k1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k1.Location = new System.Drawing.Point(95, 50);
            this.k1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.label5.Location = new System.Drawing.Point(12, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Underline";
            // 
            // bTemplatePath
            // 
            this.bTemplatePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTemplatePath.Location = new System.Drawing.Point(224, 91);
            this.bTemplatePath.Margin = new System.Windows.Forms.Padding(4);
            this.bTemplatePath.Name = "bTemplatePath";
            this.bTemplatePath.Size = new System.Drawing.Size(233, 23);
            this.bTemplatePath.TabIndex = 20;
            // 
            // bTemplateCustom
            // 
            this.bTemplateCustom.AutoSize = true;
            this.bTemplateCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTemplateCustom.Location = new System.Drawing.Point(8, 95);
            this.bTemplateCustom.Margin = new System.Windows.Forms.Padding(4);
            this.bTemplateCustom.Name = "bTemplateCustom";
            this.bTemplateCustom.Size = new System.Drawing.Size(209, 21);
            this.bTemplateCustom.TabIndex = 21;
            this.bTemplateCustom.TabStop = true;
            this.bTemplateCustom.Text = "Attach custom style template";
            this.bTemplateCustom.UseVisualStyleBackColor = true;
            // 
            // bTemplateChange
            // 
            this.bTemplateChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTemplateChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTemplateChange.Location = new System.Drawing.Point(466, 89);
            this.bTemplateChange.Margin = new System.Windows.Forms.Padding(4);
            this.bTemplateChange.Name = "bTemplateChange";
            this.bTemplateChange.Size = new System.Drawing.Size(77, 28);
            this.bTemplateChange.TabIndex = 19;
            this.bTemplateChange.Text = "Change";
            this.bTemplateChange.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AcceptButton = this.bOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 497);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bTubPath;
        private System.Windows.Forms.Button bTubChange;
        private System.Windows.Forms.CheckBox bHotkeys;
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
        private System.Windows.Forms.TextBox bTemplatePath;
        private System.Windows.Forms.RadioButton bTemplateCustom;
        private System.Windows.Forms.Button bTemplateChange;
    }
}