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
            this.label4 = new System.Windows.Forms.Label();
            this.fontSize = new System.Windows.Forms.ComboBox();
            this.bPreserveParagraphs = new System.Windows.Forms.CheckBox();
            this.bUploadSpeech = new System.Windows.Forms.CheckBox();
            this.bShowOnlyHeading1 = new System.Windows.Forms.CheckBox();
            this.bOpenWeb = new System.Windows.Forms.CheckBox();
            this.bUnderlineBold = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bSpeechPath = new System.Windows.Forms.TextBox();
            this.bSpeechChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bTubPath = new System.Windows.Forms.TextBox();
            this.bTubChange = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bTemplatePath = new System.Windows.Forms.TextBox();
            this.bBoxHeading1 = new System.Windows.Forms.CheckBox();
            this.bTemplateNormal = new System.Windows.Forms.RadioButton();
            this.bTemplateCustom = new System.Windows.Forms.RadioButton();
            this.labelLevels = new System.Windows.Forms.Label();
            this.bHeadingLevels = new System.Windows.Forms.ComboBox();
            this.bFontName = new System.Windows.Forms.ComboBox();
            this.bTemplateChange = new System.Windows.Forms.Button();
            this.bFontSize = new System.Windows.Forms.ComboBox();
            this.bHotkeys = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.k12 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.k11 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.k10 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.k9 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.k6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.k8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.k7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.k5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bOK
            // 
            this.bOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOK.Location = new System.Drawing.Point(192, 474);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
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
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.fontSize);
            this.groupBox1.Controls.Add(this.bPreserveParagraphs);
            this.groupBox1.Controls.Add(this.bUploadSpeech);
            this.groupBox1.Controls.Add(this.bShowOnlyHeading1);
            this.groupBox1.Controls.Add(this.bOpenWeb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 111);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Minimize Unread font size of non-underlined text";
            // 
            // fontSize
            // 
            this.fontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontSize.FormattingEnabled = true;
            this.fontSize.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.fontSize.Location = new System.Drawing.Point(6, 88);
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(37, 21);
            this.fontSize.TabIndex = 19;
            this.fontSize.Text = "8";
            // 
            // bPreserveParagraphs
            // 
            this.bPreserveParagraphs.AutoSize = true;
            this.bPreserveParagraphs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPreserveParagraphs.Location = new System.Drawing.Point(6, 72);
            this.bPreserveParagraphs.Name = "bPreserveParagraphs";
            this.bPreserveParagraphs.Size = new System.Drawing.Size(278, 17);
            this.bPreserveParagraphs.TabIndex = 17;
            this.bPreserveParagraphs.Text = "Remove Returns will replace paragraph breaks with ¶";
            this.bPreserveParagraphs.UseVisualStyleBackColor = true;
            // 
            // bUploadSpeech
            // 
            this.bUploadSpeech.AutoSize = true;
            this.bUploadSpeech.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUploadSpeech.Location = new System.Drawing.Point(6, 18);
            this.bUploadSpeech.Name = "bUploadSpeech";
            this.bUploadSpeech.Size = new System.Drawing.Size(258, 17);
            this.bUploadSpeech.TabIndex = 16;
            this.bUploadSpeech.Text = "Read Speech will upload speech to online reader";
            this.bUploadSpeech.UseVisualStyleBackColor = true;
            // 
            // bShowOnlyHeading1
            // 
            this.bShowOnlyHeading1.AutoSize = true;
            this.bShowOnlyHeading1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bShowOnlyHeading1.Location = new System.Drawing.Point(6, 54);
            this.bShowOnlyHeading1.Name = "bShowOnlyHeading1";
            this.bShowOnlyHeading1.Size = new System.Drawing.Size(215, 17);
            this.bShowOnlyHeading1.TabIndex = 15;
            this.bShowOnlyHeading1.Text = "Headings Index will open fully expanded";
            this.bShowOnlyHeading1.UseVisualStyleBackColor = true;
            // 
            // bOpenWeb
            // 
            this.bOpenWeb.AutoSize = true;
            this.bOpenWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOpenWeb.Location = new System.Drawing.Point(6, 36);
            this.bOpenWeb.Name = "bOpenWeb";
            this.bOpenWeb.Size = new System.Drawing.Size(288, 17);
            this.bOpenWeb.TabIndex = 5;
            this.bOpenWeb.Text = "Show sidebar and custom styles on opening documents";
            this.bOpenWeb.UseVisualStyleBackColor = true;
            // 
            // bUnderlineBold
            // 
            this.bUnderlineBold.AutoSize = true;
            this.bUnderlineBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUnderlineBold.Location = new System.Drawing.Point(312, 46);
            this.bUnderlineBold.Name = "bUnderlineBold";
            this.bUnderlineBold.Size = new System.Drawing.Size(99, 17);
            this.bUnderlineBold.TabIndex = 19;
            this.bUnderlineBold.Text = "Bold underlined";
            this.bUnderlineBold.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bSpeechPath);
            this.groupBox2.Controls.Add(this.bSpeechChange);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bTubPath);
            this.groupBox2.Controls.Add(this.bTubChange);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 98);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Folders";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Speeches";
            // 
            // bSpeechPath
            // 
            this.bSpeechPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSpeechPath.Location = new System.Drawing.Point(9, 75);
            this.bSpeechPath.Name = "bSpeechPath";
            this.bSpeechPath.Size = new System.Drawing.Size(275, 20);
            this.bSpeechPath.TabIndex = 9;
            // 
            // bSpeechChange
            // 
            this.bSpeechChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSpeechChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSpeechChange.Location = new System.Drawing.Point(290, 72);
            this.bSpeechChange.Name = "bSpeechChange";
            this.bSpeechChange.Size = new System.Drawing.Size(58, 23);
            this.bSpeechChange.TabIndex = 7;
            this.bSpeechChange.Text = "Change";
            this.bSpeechChange.UseVisualStyleBackColor = true;
            this.bSpeechChange.Click += new System.EventHandler(this.bSpeechChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Debate Files";
            // 
            // bTubPath
            // 
            this.bTubPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTubPath.Location = new System.Drawing.Point(9, 35);
            this.bTubPath.Name = "bTubPath";
            this.bTubPath.Size = new System.Drawing.Size(275, 20);
            this.bTubPath.TabIndex = 3;
            // 
            // bTubChange
            // 
            this.bTubChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTubChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTubChange.Location = new System.Drawing.Point(290, 33);
            this.bTubChange.Name = "bTubChange";
            this.bTubChange.Size = new System.Drawing.Size(58, 23);
            this.bTubChange.TabIndex = 0;
            this.bTubChange.Text = "Change";
            this.bTubChange.UseVisualStyleBackColor = true;
            this.bTubChange.Click += new System.EventHandler(this.bFilesChange_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bTemplatePath);
            this.groupBox3.Controls.Add(this.bBoxHeading1);
            this.groupBox3.Controls.Add(this.bUnderlineBold);
            this.groupBox3.Controls.Add(this.bTemplateNormal);
            this.groupBox3.Controls.Add(this.bTemplateCustom);
            this.groupBox3.Controls.Add(this.labelLevels);
            this.groupBox3.Controls.Add(this.bHeadingLevels);
            this.groupBox3.Controls.Add(this.bFontName);
            this.groupBox3.Controls.Add(this.bTemplateChange);
            this.groupBox3.Controls.Add(this.bFontSize);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(14, 364);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 104);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Styles";
            // 
            // bTemplatePath
            // 
            this.bTemplatePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTemplatePath.Location = new System.Drawing.Point(172, 71);
            this.bTemplatePath.Name = "bTemplatePath";
            this.bTemplatePath.Size = new System.Drawing.Size(176, 20);
            this.bTemplatePath.TabIndex = 7;
            // 
            // bBoxHeading1
            // 
            this.bBoxHeading1.AutoSize = true;
            this.bBoxHeading1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBoxHeading1.Location = new System.Drawing.Point(215, 46);
            this.bBoxHeading1.Name = "bBoxHeading1";
            this.bBoxHeading1.Size = new System.Drawing.Size(96, 17);
            this.bBoxHeading1.TabIndex = 20;
            this.bBoxHeading1.Text = "Box Heading 1";
            this.bBoxHeading1.UseVisualStyleBackColor = true;
            // 
            // bTemplateNormal
            // 
            this.bTemplateNormal.AutoSize = true;
            this.bTemplateNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTemplateNormal.Location = new System.Drawing.Point(10, 46);
            this.bTemplateNormal.Name = "bTemplateNormal";
            this.bTemplateNormal.Size = new System.Drawing.Size(59, 17);
            this.bTemplateNormal.TabIndex = 19;
            this.bTemplateNormal.TabStop = true;
            this.bTemplateNormal.Text = "Default";
            this.bTemplateNormal.UseVisualStyleBackColor = true;
            // 
            // bTemplateCustom
            // 
            this.bTemplateCustom.AutoSize = true;
            this.bTemplateCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTemplateCustom.Location = new System.Drawing.Point(10, 74);
            this.bTemplateCustom.Name = "bTemplateCustom";
            this.bTemplateCustom.Size = new System.Drawing.Size(160, 17);
            this.bTemplateCustom.TabIndex = 18;
            this.bTemplateCustom.TabStop = true;
            this.bTemplateCustom.Text = "Attach custom style template";
            this.bTemplateCustom.UseVisualStyleBackColor = true;
            this.bTemplateCustom.CheckedChanged += new System.EventHandler(this.bTemplateCustom_CheckedChanged);
            // 
            // labelLevels
            // 
            this.labelLevels.AutoSize = true;
            this.labelLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevels.Location = new System.Drawing.Point(7, 22);
            this.labelLevels.Name = "labelLevels";
            this.labelLevels.Size = new System.Drawing.Size(81, 13);
            this.labelLevels.TabIndex = 15;
            this.labelLevels.Text = "Heading Levels";
            // 
            // bHeadingLevels
            // 
            this.bHeadingLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHeadingLevels.FormattingEnabled = true;
            this.bHeadingLevels.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.bHeadingLevels.Location = new System.Drawing.Point(94, 19);
            this.bHeadingLevels.Name = "bHeadingLevels";
            this.bHeadingLevels.Size = new System.Drawing.Size(37, 21);
            this.bHeadingLevels.TabIndex = 14;
            this.bHeadingLevels.Text = "4";
            // 
            // bFontName
            // 
            this.bFontName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFontName.FormattingEnabled = true;
            this.bFontName.Location = new System.Drawing.Point(71, 44);
            this.bFontName.Name = "bFontName";
            this.bFontName.Size = new System.Drawing.Size(95, 21);
            this.bFontName.TabIndex = 13;
            this.bFontName.Text = "Garamond";
            // 
            // bTemplateChange
            // 
            this.bTemplateChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTemplateChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTemplateChange.Location = new System.Drawing.Point(353, 69);
            this.bTemplateChange.Name = "bTemplateChange";
            this.bTemplateChange.Size = new System.Drawing.Size(58, 23);
            this.bTemplateChange.TabIndex = 6;
            this.bTemplateChange.Text = "Change";
            this.bTemplateChange.UseVisualStyleBackColor = true;
            this.bTemplateChange.Click += new System.EventHandler(this.bOpenTemplate_Click);
            // 
            // bFontSize
            // 
            this.bFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFontSize.FormattingEnabled = true;
            this.bFontSize.Items.AddRange(new object[] {
            "10",
            "10.5",
            "11",
            "11.5",
            "12",
            "12.5",
            "13"});
            this.bFontSize.Location = new System.Drawing.Point(172, 44);
            this.bFontSize.Name = "bFontSize";
            this.bFontSize.Size = new System.Drawing.Size(37, 21);
            this.bFontSize.TabIndex = 12;
            this.bFontSize.Text = "11";
            // 
            // bHotkeys
            // 
            this.bHotkeys.AutoSize = true;
            this.bHotkeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHotkeys.Location = new System.Drawing.Point(9, 20);
            this.bHotkeys.Name = "bHotkeys";
            this.bHotkeys.Size = new System.Drawing.Size(152, 17);
            this.bHotkeys.TabIndex = 6;
            this.bHotkeys.Text = "Enable keyboard shortcuts";
            this.bHotkeys.UseVisualStyleBackColor = true;
            this.bHotkeys.CheckedChanged += new System.EventHandler(this.bHotkeys_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.k12);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.k11);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.k10);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.k9);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.k6);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.k8);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.k7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.k5);
            this.groupBox4.Controls.Add(this.label13);
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
            this.groupBox4.Location = new System.Drawing.Point(14, 221);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(424, 141);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Keyboard";
            // 
            // k12
            // 
            this.k12.CausesValidation = false;
            this.k12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k12.Location = new System.Drawing.Point(340, 108);
            this.k12.Name = "k12";
            this.k12.Size = new System.Drawing.Size(71, 20);
            this.k12.TabIndex = 42;
            this.k12.TabStop = false;
            this.k12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kMouseClick);
            this.k12.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kKeyDown);
            this.k12.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kKeyUp);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(290, 112);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "Windows";
            // 
            // k11
            // 
            this.k11.CausesValidation = false;
            this.k11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k11.Location = new System.Drawing.Point(340, 85);
            this.k11.Name = "k11";
            this.k11.Size = new System.Drawing.Size(71, 20);
            this.k11.TabIndex = 40;
            this.k11.TabStop = false;
            this.k11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kMouseClick);
            this.k11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kKeyDown);
            this.k11.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kKeyUp);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(290, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Index";
            // 
            // k10
            // 
            this.k10.CausesValidation = false;
            this.k10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k10.Location = new System.Drawing.Point(340, 64);
            this.k10.Name = "k10";
            this.k10.Size = new System.Drawing.Size(71, 20);
            this.k10.TabIndex = 38;
            this.k10.TabStop = false;
            this.k10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kMouseClick);
            this.k10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kKeyDown);
            this.k10.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kKeyUp);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(290, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Minimize";
            // 
            // k9
            // 
            this.k9.CausesValidation = false;
            this.k9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k9.Location = new System.Drawing.Point(340, 41);
            this.k9.Name = "k9";
            this.k9.Size = new System.Drawing.Size(71, 20);
            this.k9.TabIndex = 36;
            this.k9.TabStop = false;
            this.k9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kMouseClick);
            this.k9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kKeyDown);
            this.k9.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kKeyUp);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(290, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Speech";
            // 
            // k6
            // 
            this.k6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k6.Location = new System.Drawing.Point(210, 64);
            this.k6.Name = "k6";
            this.k6.Size = new System.Drawing.Size(71, 20);
            this.k6.TabIndex = 34;
            this.k6.TabStop = false;
            this.k6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kMouseClick);
            this.k6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kKeyDown);
            this.k6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kKeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(148, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Heading 2";
            // 
            // k8
            // 
            this.k8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k8.Location = new System.Drawing.Point(210, 109);
            this.k8.Name = "k8";
            this.k8.Size = new System.Drawing.Size(71, 20);
            this.k8.TabIndex = 32;
            this.k8.TabStop = false;
            this.k8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kMouseClick);
            this.k8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kKeyDown);
            this.k8.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kKeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(148, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Heading 4";
            // 
            // k7
            // 
            this.k7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k7.Location = new System.Drawing.Point(210, 86);
            this.k7.Name = "k7";
            this.k7.Size = new System.Drawing.Size(71, 20);
            this.k7.TabIndex = 30;
            this.k7.TabStop = false;
            this.k7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kMouseClick);
            this.k7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kKeyDown);
            this.k7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kKeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(148, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Heading 3";
            // 
            // k5
            // 
            this.k5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k5.Location = new System.Drawing.Point(210, 41);
            this.k5.Name = "k5";
            this.k5.Size = new System.Drawing.Size(71, 20);
            this.k5.TabIndex = 28;
            this.k5.TabStop = false;
            this.k5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kMouseClick);
            this.k5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kKeyDown);
            this.k5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kKeyUp);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(148, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Heading 1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(147, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 17;
            // 
            // k2
            // 
            this.k2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k2.Location = new System.Drawing.Point(71, 63);
            this.k2.Name = "k2";
            this.k2.Size = new System.Drawing.Size(71, 20);
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
            this.label9.Location = new System.Drawing.Point(9, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Highlight";
            // 
            // k4
            // 
            this.k4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k4.Location = new System.Drawing.Point(71, 108);
            this.k4.Name = "k4";
            this.k4.Size = new System.Drawing.Size(71, 20);
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
            this.label8.Location = new System.Drawing.Point(9, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Paste Text";
            // 
            // k3
            // 
            this.k3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k3.Location = new System.Drawing.Point(71, 85);
            this.k3.Name = "k3";
            this.k3.Size = new System.Drawing.Size(71, 20);
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
            this.label7.Location = new System.Drawing.Point(9, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Returns";
            // 
            // k1
            // 
            this.k1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k1.Location = new System.Drawing.Point(71, 41);
            this.k1.Name = "k1";
            this.k1.Size = new System.Drawing.Size(71, 20);
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
            this.label5.Location = new System.Drawing.Point(9, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Underline";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Alex Gulakov, May 2014";
            // 
            // Settings
            // 
            this.AcceptButton = this.bOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog dialogFolder;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.OpenFileDialog dialogFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox bPreserveParagraphs;
        private System.Windows.Forms.CheckBox bUploadSpeech;
        private System.Windows.Forms.CheckBox bShowOnlyHeading1;
        private System.Windows.Forms.CheckBox bOpenWeb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bSpeechPath;
        private System.Windows.Forms.Button bSpeechChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bTubPath;
        private System.Windows.Forms.Button bTubChange;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelLevels;
        private System.Windows.Forms.ComboBox bHeadingLevels;
        private System.Windows.Forms.TextBox bTemplatePath;
        private System.Windows.Forms.ComboBox bFontName;
        private System.Windows.Forms.Button bTemplateChange;
        private System.Windows.Forms.ComboBox bFontSize;
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
        private System.Windows.Forms.TextBox k6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox k8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox k7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox k5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox k12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox k11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox k10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox k9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox bUnderlineBold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton bTemplateNormal;
        private System.Windows.Forms.RadioButton bTemplateCustom;
        private System.Windows.Forms.CheckBox bBoxHeading1;
        private System.Windows.Forms.ComboBox fontSize;
        private System.Windows.Forms.Label label4;
    }
}