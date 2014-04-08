namespace DebateSidebarWordAddIn
{
    partial class MimimizeFont
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
            this.bOKSize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fontSize = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bOKSize
            // 
            this.bOKSize.Location = new System.Drawing.Point(299, 9);
            this.bOKSize.Name = "bOKSize";
            this.bOKSize.Size = new System.Drawing.Size(54, 23);
            this.bOKSize.TabIndex = 5;
            this.bOKSize.Text = "OK";
            this.bOKSize.UseVisualStyleBackColor = true;
            this.bOKSize.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Font size of non-underlined text in selection:";
            // 
            // fontSize
            // 
            this.fontSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fontSize.FormattingEnabled = true;
            this.fontSize.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "10.5",
            "11",
            "11.5",
            "12",
            "12.5",
            "13"});
            this.fontSize.Location = new System.Drawing.Point(242, 11);
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(45, 21);
            this.fontSize.TabIndex = 3;
            this.fontSize.Text = "8";
            // 
            // MimimizeFont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 55);
            this.Controls.Add(this.bOKSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fontSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(500, 300);
            this.Name = "MimimizeFont";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Mimimize Font";
            this.Load += new System.EventHandler(this.MimimizeFont_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bOKSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fontSize;
    }
}