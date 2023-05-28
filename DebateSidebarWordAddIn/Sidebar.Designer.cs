namespace DebateSidebarWordAddIn
{
    partial class Sidebar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
   

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sidebar));
            this.toolStripContainer4 = new System.Windows.Forms.ToolStripContainer();
            this.treeFiles = new System.Windows.Forms.TreeView();
            this.contextFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeDoc = new System.Windows.Forms.TreeView();
            this.contextHeadings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.contextExpand = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.contextStarRating = new System.Windows.Forms.ToolStripMenuItem();
            this.Menubar = new System.Windows.Forms.ToolStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.underlinedTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highlightedTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.bUnderlineMode = new System.Windows.Forms.ToolStripMenuItem();
            this.bHightlightMode = new System.Windows.Forms.ToolStripMenuItem();
            this.bSendToSpeech = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bExpand = new System.Windows.Forms.ToolStripMenuItem();
            this.bSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStripContainer4.ContentPanel.SuspendLayout();
            this.toolStripContainer4.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer4.SuspendLayout();
            this.contextFiles.SuspendLayout();
            this.contextHeadings.SuspendLayout();
            this.Menubar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer4
            // 
            this.toolStripContainer4.AllowDrop = true;
            // 
            // toolStripContainer4.ContentPanel
            // 
            this.toolStripContainer4.ContentPanel.AutoScroll = true;
            this.toolStripContainer4.ContentPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripContainer4.ContentPanel.Controls.Add(this.tabControl1);
            this.toolStripContainer4.ContentPanel.Size = new System.Drawing.Size(287, 307);
            this.toolStripContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer4.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer4.Name = "toolStripContainer4";
            this.toolStripContainer4.Size = new System.Drawing.Size(287, 338);
            this.toolStripContainer4.TabIndex = 2;
            this.toolStripContainer4.Text = "toolStripContainer4";
            // 
            // toolStripContainer4.TopToolStripPanel
            // 
            this.toolStripContainer4.TopToolStripPanel.BackColor = System.Drawing.Color.White;
            this.toolStripContainer4.TopToolStripPanel.Controls.Add(this.Menubar);
            // 
            // treeFiles
            // 
            this.treeFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeFiles.ContextMenuStrip = this.contextFiles;
            this.treeFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeFiles.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeFiles.FullRowSelect = true;
            this.treeFiles.ItemHeight = 24;
            this.treeFiles.Location = new System.Drawing.Point(3, 3);
            this.treeFiles.Margin = new System.Windows.Forms.Padding(0);
            this.treeFiles.Name = "treeFiles";
            this.treeFiles.Size = new System.Drawing.Size(273, 275);
            this.treeFiles.TabIndex = 3;
            this.treeFiles.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeFiles_NodeMouseDoubleClick);
            // 
            // contextFiles
            // 
            this.contextFiles.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderToolStripMenuItem});
            this.contextFiles.Name = "contextTreeFiles";
            this.contextFiles.Size = new System.Drawing.Size(148, 34);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openFolderToolStripMenuItem.Image")));
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(147, 30);
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.contextFilesFolder_Click);
            // 
            // treeDoc
            // 
            this.treeDoc.AllowDrop = true;
            this.treeDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeDoc.ContextMenuStrip = this.contextHeadings;
            this.treeDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeDoc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.treeDoc.FullRowSelect = true;
            this.treeDoc.Indent = 16;
            this.treeDoc.ItemHeight = 22;
            this.treeDoc.Location = new System.Drawing.Point(3, 3);
            this.treeDoc.Margin = new System.Windows.Forms.Padding(0);
            this.treeDoc.Name = "treeDoc";
            this.treeDoc.ShowLines = false;
            this.treeDoc.Size = new System.Drawing.Size(273, 275);
            this.treeDoc.TabIndex = 4;
            this.treeDoc.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeDoc_AfterExpand);
            this.treeDoc.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.treeDoc_NodeMouseHover);
            this.treeDoc.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeDoc_AfterSelect);
            this.treeDoc.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeDoc_NodeMouseClick);
            // 
            // contextHeadings
            // 
            this.contextHeadings.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextHeadings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextRefresh,
            this.contextExpand,
            this.toolStripMenuItem2,
            this.bSettings,
            this.contextStarRating});
            this.contextHeadings.Name = "treeDocContentMenu";
            this.contextHeadings.Size = new System.Drawing.Size(172, 154);
            // 
            // contextRefresh
            // 
            this.contextRefresh.Image = ((System.Drawing.Image)(resources.GetObject("contextRefresh.Image")));
            this.contextRefresh.Name = "contextRefresh";
            this.contextRefresh.Size = new System.Drawing.Size(171, 30);
            this.contextRefresh.Text = "Refresh";
            this.contextRefresh.Click += new System.EventHandler(this.contextRefresh_Click);
            // 
            // contextExpand
            // 
            this.contextExpand.Image = ((System.Drawing.Image)(resources.GetObject("contextExpand.Image")));
            this.contextExpand.Name = "contextExpand";
            this.contextExpand.Size = new System.Drawing.Size(171, 30);
            this.contextExpand.Text = "Toggle Tags";
            this.contextExpand.Click += new System.EventHandler(this.bExpand_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::DebateSidebarWordAddIn.Properties.Resources.Clear;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(171, 30);
            this.toolStripMenuItem2.Text = "Hide in Doc Map";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.contextRemove_Click);
            // 
            // bSettings
            // 
            this.bSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSettings.Image = ((System.Drawing.Image)(resources.GetObject("bSettings.Image")));
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(171, 30);
            this.bSettings.Text = "Settings";
            this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
            // 
            // contextStarRating
            // 
            this.contextStarRating.Image = global::DebateSidebarWordAddIn.Properties.Resources.Check;
            this.contextStarRating.Name = "contextStarRating";
            this.contextStarRating.Size = new System.Drawing.Size(171, 30);
            this.contextStarRating.Text = "Star Rating";
            this.contextStarRating.Click += new System.EventHandler(this.contextStarRating_Click);
            // 
            // Menubar
            // 
            this.Menubar.BackColor = System.Drawing.Color.White;
            this.Menubar.Dock = System.Windows.Forms.DockStyle.None;
            this.Menubar.GripMargin = new System.Windows.Forms.Padding(0);
            this.Menubar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Menubar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripDropDownButton1,
            this.showAllTextToolStripMenuItem,
            this.bExpand,
            this.bSearch});
            this.Menubar.Location = new System.Drawing.Point(3, 0);
            this.Menubar.Name = "Menubar";
            this.Menubar.Padding = new System.Windows.Forms.Padding(0);
            this.Menubar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menubar.Size = new System.Drawing.Size(274, 31);
            this.Menubar.TabIndex = 1;
            this.Menubar.Text = "toolStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::DebateSidebarWordAddIn.Properties.Resources.Logo;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(36, 31);
            this.toolStripMenuItem1.ToolTipText = "Refresh after each edit ";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.underlinedTextToolStripMenuItem,
            this.highlightedTextToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem15,
            this.bUnderlineMode,
            this.bHightlightMode,
            this.bSendToSpeech,
            this.toolStripMenuItem4,
            this.toolStripComboBox1});
            this.toolStripDropDownButton1.Image = global::DebateSidebarWordAddIn.Properties.Resources.Underline;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(37, 28);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // underlinedTextToolStripMenuItem
            // 
            this.underlinedTextToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("underlinedTextToolStripMenuItem.Image")));
            this.underlinedTextToolStripMenuItem.Name = "underlinedTextToolStripMenuItem";
            this.underlinedTextToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.underlinedTextToolStripMenuItem.Text = "Hide Underlined";
            this.underlinedTextToolStripMenuItem.Click += new System.EventHandler(this.FormatMacro_Click);
            // 
            // highlightedTextToolStripMenuItem
            // 
            this.highlightedTextToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("highlightedTextToolStripMenuItem.Image")));
            this.highlightedTextToolStripMenuItem.Name = "highlightedTextToolStripMenuItem";
            this.highlightedTextToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.highlightedTextToolStripMenuItem.Text = "Hide Highlighted";
            this.highlightedTextToolStripMenuItem.Click += new System.EventHandler(this.FormatMacro_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem15.Image")));
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem15.Text = "Highlight Mode";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.FormatMacro_Click);
            // 
            // bUnderlineMode
            // 
            this.bUnderlineMode.Image = ((System.Drawing.Image)(resources.GetObject("bUnderlineMode.Image")));
            this.bUnderlineMode.Name = "bUnderlineMode";
            this.bUnderlineMode.Size = new System.Drawing.Size(181, 22);
            this.bUnderlineMode.Text = "Underline Mode";
            this.bUnderlineMode.Click += new System.EventHandler(this.FormatMacro_Click);
            // 
            // bHightlightMode
            // 
            this.bHightlightMode.Image = ((System.Drawing.Image)(resources.GetObject("bHightlightMode.Image")));
            this.bHightlightMode.Name = "bHightlightMode";
            this.bHightlightMode.Size = new System.Drawing.Size(181, 22);
            this.bHightlightMode.Text = "Add Note";
            this.bHightlightMode.Click += new System.EventHandler(this.FormatMacro_Click);
            // 
            // bSendToSpeech
            // 
            this.bSendToSpeech.Image = ((System.Drawing.Image)(resources.GetObject("bSendToSpeech.Image")));
            this.bSendToSpeech.Name = "bSendToSpeech";
            this.bSendToSpeech.Size = new System.Drawing.Size(181, 22);
            this.bSendToSpeech.Text = "Speech";
            this.bSendToSpeech.Click += new System.EventHandler(this.FormatMacro_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem4.Text = "Settings";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.FormatMacro_Click);
            // 
            // showAllTextToolStripMenuItem
            // 
            this.showAllTextToolStripMenuItem.Checked = true;
            this.showAllTextToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showAllTextToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showAllTextToolStripMenuItem.Image")));
            this.showAllTextToolStripMenuItem.Name = "showAllTextToolStripMenuItem";
            this.showAllTextToolStripMenuItem.Size = new System.Drawing.Size(36, 31);
            this.showAllTextToolStripMenuItem.Click += new System.EventHandler(this.FormatMacro_Click);
            // 
            // bExpand
            // 
            this.bExpand.BackColor = System.Drawing.Color.White;
            this.bExpand.Image = global::DebateSidebarWordAddIn.Properties.Resources.Heading;
            this.bExpand.Name = "bExpand";
            this.bExpand.Size = new System.Drawing.Size(36, 31);
            this.bExpand.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.bExpand.ToolTipText = "Toggle expanding all or default level";
            this.bExpand.Click += new System.EventHandler(this.bExpand_Click);
            // 
            // bSearch
            // 
            this.bSearch.AcceptsReturn = true;
            this.bSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bSearch.MaxLength = 20;
            this.bSearch.Name = "bSearch";
            this.bSearch.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.bSearch.Size = new System.Drawing.Size(125, 31);
            this.bSearch.ToolTipText = "Seaches first folders and files then document text";
            this.bSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bSearch_KeyDown);
            this.bSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bSearch_KeyUp);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.AutoToolTip = true;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Unread",
            "Underlined",
            "Highlighted",
            "Collapse Flow"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(287, 307);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeDoc);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(279, 281);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doc Map";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.treeFiles);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(279, 281);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Folders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Sidebar
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.CausesValidation = false;
            this.Controls.Add(this.toolStripContainer4);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Sidebar";
            this.Size = new System.Drawing.Size(287, 338);
            this.Load += new System.EventHandler(this.Sidebar_Load);
            this.SizeChanged += new System.EventHandler(this.Sidebar_SizeChanged);
            this.toolStripContainer4.ContentPanel.ResumeLayout(false);
            this.toolStripContainer4.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer4.TopToolStripPanel.PerformLayout();
            this.toolStripContainer4.ResumeLayout(false);
            this.toolStripContainer4.PerformLayout();
            this.contextFiles.ResumeLayout(false);
            this.contextHeadings.ResumeLayout(false);
            this.Menubar.ResumeLayout(false);
            this.Menubar.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer4;
        private System.Windows.Forms.ContextMenuStrip contextHeadings;
        private System.Windows.Forms.ToolStrip Menubar;
        private System.Windows.Forms.ToolStripTextBox bSearch;
        private System.Windows.Forms.TreeView treeFiles;
        private System.Windows.Forms.ToolStripMenuItem contextExpand;
        private System.Windows.Forms.ToolStripMenuItem contextRefresh;
        private System.Windows.Forms.ContextMenuStrip contextFiles;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        public System.Windows.Forms.TreeView treeDoc;
        private System.Windows.Forms.ToolStripMenuItem bSettings;
        public System.Windows.Forms.ToolStripMenuItem bExpand;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem underlinedTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highlightedTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem bUnderlineMode;
        private System.Windows.Forms.ToolStripMenuItem bHightlightMode;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem contextStarRating;
        private System.Windows.Forms.ToolStripMenuItem bSendToSpeech;
        private System.Windows.Forms.ToolStripMenuItem showAllTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
