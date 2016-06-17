namespace DebateSidebarWordAddIn
{
    partial class ManageSpeech
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
            this.speechName = new System.Windows.Forms.TextBox();
            this.bSpeechAdd = new System.Windows.Forms.Button();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.r5 = new System.Windows.Forms.RadioButton();
            this.r4 = new System.Windows.Forms.RadioButton();
            this.r3 = new System.Windows.Forms.RadioButton();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.r6 = new System.Windows.Forms.RadioButton();
            this.r7 = new System.Windows.Forms.RadioButton();
            this.curDocsList = new System.Windows.Forms.ComboBox();
            this.bSetCurDoc = new System.Windows.Forms.Button();
            this.textCurrentDoc = new System.Windows.Forms.Label();
            this.bReadOnline = new System.Windows.Forms.Button();
            this.bUSB = new System.Windows.Forms.Button();
            this.bTimer = new System.Windows.Forms.Button();
            this.bReadOffline = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // speechName
            // 
            this.speechName.Location = new System.Drawing.Point(9, 19);
            this.speechName.Name = "speechName";
            this.speechName.Size = new System.Drawing.Size(251, 20);
            this.speechName.TabIndex = 0;
            this.speechName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.speechName_KeyUp);
            // 
            // bSpeechAdd
            // 
            this.bSpeechAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSpeechAdd.Location = new System.Drawing.Point(271, 16);
            this.bSpeechAdd.Name = "bSpeechAdd";
            this.bSpeechAdd.Size = new System.Drawing.Size(74, 23);
            this.bSpeechAdd.TabIndex = 1;
            this.bSpeechAdd.Text = "Create New";
            this.bSpeechAdd.UseVisualStyleBackColor = true;
            this.bSpeechAdd.Click += new System.EventHandler(this.bSpeechAdd_Click);
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Checked = true;
            this.r1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r1.ForeColor = System.Drawing.Color.Red;
            this.r1.Location = new System.Drawing.Point(9, 42);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(49, 17);
            this.r1.TabIndex = 2;
            this.r1.TabStop = true;
            this.r1.Text = "1NC";
            this.r1.UseVisualStyleBackColor = true;
            this.r1.CheckedChanged += new System.EventHandler(this.speechChecked);
            // 
            // r5
            // 
            this.r5.AutoSize = true;
            this.r5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r5.ForeColor = System.Drawing.Color.Blue;
            this.r5.Location = new System.Drawing.Point(201, 42);
            this.r5.Name = "r5";
            this.r5.Size = new System.Drawing.Size(49, 17);
            this.r5.TabIndex = 4;
            this.r5.Text = "1AR";
            this.r5.UseVisualStyleBackColor = true;
            this.r5.CheckedChanged += new System.EventHandler(this.speechChecked);
            // 
            // r4
            // 
            this.r4.AutoSize = true;
            this.r4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r4.ForeColor = System.Drawing.Color.Red;
            this.r4.Location = new System.Drawing.Point(151, 42);
            this.r4.Name = "r4";
            this.r4.Size = new System.Drawing.Size(50, 17);
            this.r4.TabIndex = 5;
            this.r4.Text = "1NR";
            this.r4.UseVisualStyleBackColor = true;
            this.r4.CheckedChanged += new System.EventHandler(this.speechChecked);
            // 
            // r3
            // 
            this.r3.AutoSize = true;
            this.r3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r3.ForeColor = System.Drawing.Color.Red;
            this.r3.Location = new System.Drawing.Point(103, 42);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(49, 17);
            this.r3.TabIndex = 6;
            this.r3.Text = "2NC";
            this.r3.UseVisualStyleBackColor = true;
            this.r3.CheckedChanged += new System.EventHandler(this.speechChecked);
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r2.ForeColor = System.Drawing.Color.Blue;
            this.r2.Location = new System.Drawing.Point(56, 42);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(48, 17);
            this.r2.TabIndex = 7;
            this.r2.Text = "2AC";
            this.r2.UseVisualStyleBackColor = true;
            this.r2.CheckedChanged += new System.EventHandler(this.speechChecked);
            // 
            // r6
            // 
            this.r6.AutoSize = true;
            this.r6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r6.ForeColor = System.Drawing.Color.Red;
            this.r6.Location = new System.Drawing.Point(248, 42);
            this.r6.Name = "r6";
            this.r6.Size = new System.Drawing.Size(50, 17);
            this.r6.TabIndex = 3;
            this.r6.Text = "2NR";
            this.r6.UseVisualStyleBackColor = true;
            this.r6.CheckedChanged += new System.EventHandler(this.speechChecked);
            // 
            // r7
            // 
            this.r7.AutoSize = true;
            this.r7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r7.ForeColor = System.Drawing.Color.Blue;
            this.r7.Location = new System.Drawing.Point(296, 42);
            this.r7.Name = "r7";
            this.r7.Size = new System.Drawing.Size(49, 17);
            this.r7.TabIndex = 8;
            this.r7.Text = "2AR";
            this.r7.UseVisualStyleBackColor = true;
            this.r7.CheckedChanged += new System.EventHandler(this.speechChecked);
            // 
            // curDocsList
            // 
            this.curDocsList.FormattingEnabled = true;
            this.curDocsList.Location = new System.Drawing.Point(6, 94);
            this.curDocsList.Name = "curDocsList";
            this.curDocsList.Size = new System.Drawing.Size(210, 21);
            this.curDocsList.TabIndex = 9;
            // 
            // bSetCurDoc
            // 
            this.bSetCurDoc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bSetCurDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSetCurDoc.Location = new System.Drawing.Point(223, 34);
            this.bSetCurDoc.Name = "bSetCurDoc";
            this.bSetCurDoc.Size = new System.Drawing.Size(122, 23);
            this.bSetCurDoc.TabIndex = 10;
            this.bSetCurDoc.Text = "Set This as Speech";
            this.bSetCurDoc.UseVisualStyleBackColor = true;
            this.bSetCurDoc.Click += new System.EventHandler(this.bSetCurDoc_Click);
            // 
            // textCurrentDoc
            // 
            this.textCurrentDoc.AutoSize = true;
            this.textCurrentDoc.Location = new System.Drawing.Point(11, 75);
            this.textCurrentDoc.Name = "textCurrentDoc";
            this.textCurrentDoc.Size = new System.Drawing.Size(139, 13);
            this.textCurrentDoc.TabIndex = 11;
            this.textCurrentDoc.Text = "Current Speech Document: ";
            // 
            // bReadOnline
            // 
            this.bReadOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReadOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReadOnline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bReadOnline.Location = new System.Drawing.Point(84, 12);
            this.bReadOnline.Name = "bReadOnline";
            this.bReadOnline.Size = new System.Drawing.Size(85, 23);
            this.bReadOnline.TabIndex = 12;
            this.bReadOnline.Text = "Read Online";
            this.bReadOnline.UseVisualStyleBackColor = true;
            this.bReadOnline.Click += new System.EventHandler(this.bReadOnline_Click);
            // 
            // bUSB
            // 
            this.bUSB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUSB.Location = new System.Drawing.Point(175, 39);
            this.bUSB.Name = "bUSB";
            this.bUSB.Size = new System.Drawing.Size(85, 23);
            this.bUSB.TabIndex = 13;
            this.bUSB.Text = "Copy to USB";
            this.bUSB.UseVisualStyleBackColor = true;
            this.bUSB.Click += new System.EventHandler(this.bUSB_Click);
            // 
            // bTimer
            // 
            this.bTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTimer.Location = new System.Drawing.Point(84, 39);
            this.bTimer.Name = "bTimer";
            this.bTimer.Size = new System.Drawing.Size(85, 23);
            this.bTimer.TabIndex = 14;
            this.bTimer.Text = "Timer";
            this.bTimer.UseVisualStyleBackColor = true;
            this.bTimer.Click += new System.EventHandler(this.bTimer_Click);
            // 
            // bReadOffline
            // 
            this.bReadOffline.BackColor = System.Drawing.Color.White;
            this.bReadOffline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReadOffline.Location = new System.Drawing.Point(175, 12);
            this.bReadOffline.Name = "bReadOffline";
            this.bReadOffline.Size = new System.Drawing.Size(85, 23);
            this.bReadOffline.TabIndex = 15;
            this.bReadOffline.Text = "Read Offline";
            this.bReadOffline.UseVisualStyleBackColor = false;
            this.bReadOffline.Click += new System.EventHandler(this.bReadOffline_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.speechName);
            this.groupBox1.Controls.Add(this.r5);
            this.groupBox1.Controls.Add(this.r1);
            this.groupBox1.Controls.Add(this.r6);
            this.groupBox1.Controls.Add(this.r7);
            this.groupBox1.Controls.Add(this.bSpeechAdd);
            this.groupBox1.Controls.Add(this.r4);
            this.groupBox1.Controls.Add(this.r2);
            this.groupBox1.Controls.Add(this.r3);
            this.groupBox1.Location = new System.Drawing.Point(1, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 69);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bSetCurDoc);
            this.groupBox2.Location = new System.Drawing.Point(1, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 66);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bReadOffline);
            this.groupBox3.Controls.Add(this.bReadOnline);
            this.groupBox3.Controls.Add(this.bUSB);
            this.groupBox3.Controls.Add(this.bTimer);
            this.groupBox3.Location = new System.Drawing.Point(1, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 68);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // ManageSpeech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(356, 191);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.curDocsList);
            this.Controls.Add(this.textCurrentDoc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageSpeech";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Manage Speech";
            this.Load += new System.EventHandler(this.Speech_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox speechName;
        private System.Windows.Forms.Button bSpeechAdd;
        private System.Windows.Forms.RadioButton r1;
        private System.Windows.Forms.RadioButton r5;
        private System.Windows.Forms.RadioButton r4;
        private System.Windows.Forms.RadioButton r3;
        private System.Windows.Forms.RadioButton r2;
        private System.Windows.Forms.RadioButton r6;
        private System.Windows.Forms.RadioButton r7;
        private System.Windows.Forms.ComboBox curDocsList;
        private System.Windows.Forms.Button bSetCurDoc;
        private System.Windows.Forms.Label textCurrentDoc;
        private System.Windows.Forms.Button bReadOnline;
        private System.Windows.Forms.Button bUSB;
        private System.Windows.Forms.Button bTimer;
        private System.Windows.Forms.Button bReadOffline;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}