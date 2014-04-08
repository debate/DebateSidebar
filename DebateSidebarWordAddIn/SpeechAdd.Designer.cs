namespace DebateSidebarWordAddIn
{
    partial class SpeechAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textCurrentDoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // speechName
            // 
            this.speechName.Location = new System.Drawing.Point(7, 5);
            this.speechName.Name = "speechName";
            this.speechName.Size = new System.Drawing.Size(264, 20);
            this.speechName.TabIndex = 0;
            this.speechName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.speechName_KeyUp);
            // 
            // bSpeechAdd
            // 
            this.bSpeechAdd.Location = new System.Drawing.Point(277, 5);
            this.bSpeechAdd.Name = "bSpeechAdd";
            this.bSpeechAdd.Size = new System.Drawing.Size(74, 20);
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
            this.r1.Location = new System.Drawing.Point(6, 31);
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
            this.r5.Location = new System.Drawing.Point(198, 31);
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
            this.r4.Location = new System.Drawing.Point(148, 31);
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
            this.r3.Location = new System.Drawing.Point(100, 31);
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
            this.r2.Location = new System.Drawing.Point(53, 31);
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
            this.r6.Location = new System.Drawing.Point(245, 31);
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
            this.r7.Location = new System.Drawing.Point(293, 31);
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
            this.curDocsList.Location = new System.Drawing.Point(7, 26);
            this.curDocsList.Name = "curDocsList";
            this.curDocsList.Size = new System.Drawing.Size(210, 21);
            this.curDocsList.TabIndex = 9;
            // 
            // bSetCurDoc
            // 
            this.bSetCurDoc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bSetCurDoc.Location = new System.Drawing.Point(223, 24);
            this.bSetCurDoc.Name = "bSetCurDoc";
            this.bSetCurDoc.Size = new System.Drawing.Size(128, 23);
            this.bSetCurDoc.TabIndex = 10;
            this.bSetCurDoc.Text = "Set This as Speech";
            this.bSetCurDoc.UseVisualStyleBackColor = true;
            this.bSetCurDoc.Click += new System.EventHandler(this.bSetCurDoc_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bSpeechAdd);
            this.splitContainer1.Panel1.Controls.Add(this.r7);
            this.splitContainer1.Panel1.Controls.Add(this.speechName);
            this.splitContainer1.Panel1.Controls.Add(this.r6);
            this.splitContainer1.Panel1.Controls.Add(this.r1);
            this.splitContainer1.Panel1.Controls.Add(this.r5);
            this.splitContainer1.Panel1.Controls.Add(this.r2);
            this.splitContainer1.Panel1.Controls.Add(this.r4);
            this.splitContainer1.Panel1.Controls.Add(this.r3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textCurrentDoc);
            this.splitContainer1.Panel2.Controls.Add(this.bSetCurDoc);
            this.splitContainer1.Panel2.Controls.Add(this.curDocsList);
            this.splitContainer1.Size = new System.Drawing.Size(356, 111);
            this.splitContainer1.SplitterDistance = 55;
            this.splitContainer1.TabIndex = 11;
            // 
            // textCurrentDoc
            // 
            this.textCurrentDoc.AutoSize = true;
            this.textCurrentDoc.Location = new System.Drawing.Point(12, 7);
            this.textCurrentDoc.Name = "textCurrentDoc";
            this.textCurrentDoc.Size = new System.Drawing.Size(139, 13);
            this.textCurrentDoc.TabIndex = 11;
            this.textCurrentDoc.Text = "Current Speech Document: ";
            // 
            // SpeechAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(356, 111);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SpeechAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "New Speech";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpeechAdd_FormClosing);
            this.Load += new System.EventHandler(this.SpeechAdd_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label textCurrentDoc;
    }
}