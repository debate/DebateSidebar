namespace DebateSidebarWordAddIn
{
    partial class MainPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.toolStripContainer4 = new System.Windows.Forms.ToolStripContainer();
            this.treeFiles = new System.Windows.Forms.TreeView();
            this.contextTreeFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.expandAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.treeDoc = new System.Windows.Forms.TreeView();
            this.contextTreeDoc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.promoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bCollapseHeading2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bCollapseHeading3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMain = new System.Windows.Forms.ToolStrip();
            this.bFilesShow = new System.Windows.Forms.ToolStripButton();
            this.bRefreshDocMain = new System.Windows.Forms.ToolStripSplitButton();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bExpandAll = new System.Windows.Forms.ToolStripMenuItem();
            this.bCollapseHeading1 = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseToHeading2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseToHeading3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bFormattingMain = new System.Windows.Forms.ToolStripSplitButton();
            this.autoUnderlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoHightlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.bReturns = new System.Windows.Forms.ToolStripMenuItem();
            this.bHeading1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bHeading2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bHeading3 = new System.Windows.Forms.ToolStripMenuItem();
            this.bHeading4 = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeUnreadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectSimilarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caselistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFormattingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bSpeechMain = new System.Windows.Forms.ToolStripSplitButton();
            this.bSpeechAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToSpeechToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bReadSpeech = new System.Windows.Forms.ToolStripMenuItem();
            this.bCopyUSB = new System.Windows.Forms.ToolStripMenuItem();
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bSwitchWindow = new System.Windows.Forms.ToolStripDropDownButton();
            this.bSearchString = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripContainer4.ContentPanel.SuspendLayout();
            this.toolStripContainer4.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer4.SuspendLayout();
            this.contextTreeFiles.SuspendLayout();
            this.contextTreeDoc.SuspendLayout();
            this.toolsMain.SuspendLayout();
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
            this.toolStripContainer4.ContentPanel.Controls.Add(this.treeFiles);
            this.toolStripContainer4.ContentPanel.Controls.Add(this.treeDoc);
            this.toolStripContainer4.ContentPanel.Size = new System.Drawing.Size(260, 275);
            this.toolStripContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer4.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer4.Name = "toolStripContainer4";
            this.toolStripContainer4.Size = new System.Drawing.Size(260, 300);
            this.toolStripContainer4.TabIndex = 2;
            this.toolStripContainer4.Text = "toolStripContainer4";
            // 
            // toolStripContainer4.TopToolStripPanel
            // 
            this.toolStripContainer4.TopToolStripPanel.Controls.Add(this.toolsMain);
            // 
            // treeFiles
            // 
            this.treeFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeFiles.ContextMenuStrip = this.contextTreeFiles;
            this.treeFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeFiles.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeFiles.Location = new System.Drawing.Point(0, 0);
            this.treeFiles.Name = "treeFiles";
            this.treeFiles.Size = new System.Drawing.Size(260, 275);
            this.treeFiles.TabIndex = 3;
            this.treeFiles.Visible = false;
            this.treeFiles.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeFiles_NodeMouseDoubleClick);
            // 
            // contextTreeFiles
            // 
            this.contextTreeFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderToolStripMenuItem,
            this.collapseAllToolStripMenuItem1,
            this.expandAllToolStripMenuItem1});
            this.contextTreeFiles.Name = "contextTreeFiles";
            this.contextTreeFiles.Size = new System.Drawing.Size(140, 70);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Image = global::DebateSidebarWordAddIn.Properties.Resources.folders;
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // collapseAllToolStripMenuItem1
            // 
            this.collapseAllToolStripMenuItem1.Image = global::DebateSidebarWordAddIn.Properties.Resources.bb;
            this.collapseAllToolStripMenuItem1.Name = "collapseAllToolStripMenuItem1";
            this.collapseAllToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.collapseAllToolStripMenuItem1.Text = "Collapse All";
            this.collapseAllToolStripMenuItem1.Click += new System.EventHandler(this.collapseAllToolStripMenuItem1_Click);
            // 
            // expandAllToolStripMenuItem1
            // 
            this.expandAllToolStripMenuItem1.Image = global::DebateSidebarWordAddIn.Properties.Resources.ff;
            this.expandAllToolStripMenuItem1.Name = "expandAllToolStripMenuItem1";
            this.expandAllToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.expandAllToolStripMenuItem1.Text = "Expand All";
            this.expandAllToolStripMenuItem1.Click += new System.EventHandler(this.expandToolStripMenuItem_Click);
            // 
            // treeDoc
            // 
            this.treeDoc.AllowDrop = true;
            this.treeDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeDoc.ContextMenuStrip = this.contextTreeDoc;
            this.treeDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeDoc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeDoc.FullRowSelect = true;
            this.treeDoc.Indent = 10;
            this.treeDoc.ItemHeight = 14;
            this.treeDoc.Location = new System.Drawing.Point(0, 0);
            this.treeDoc.Margin = new System.Windows.Forms.Padding(0);
            this.treeDoc.Name = "treeDoc";
            this.treeDoc.ShowLines = false;
            this.treeDoc.Size = new System.Drawing.Size(260, 275);
            this.treeDoc.TabIndex = 4;
            this.treeDoc.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.treeDoc_NodeMouseHover);
            this.treeDoc.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeDoc_NodeMouseClick);
            // 
            // contextTreeDoc
            // 
            this.contextTreeDoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem1,
            this.promoteToolStripMenuItem,
            this.demoteToolStripMenuItem,
            this.collapseAllToolStripMenuItem,
            this.expandAllToolStripMenuItem,
            this.bCollapseHeading2,
            this.bCollapseHeading3});
            this.contextTreeDoc.Name = "treeDocContentMenu";
            this.contextTreeDoc.Size = new System.Drawing.Size(191, 158);
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Image = global::DebateSidebarWordAddIn.Properties.Resources.refresh;
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.refreshToolStripMenuItem1.Text = "Refresh";
            this.refreshToolStripMenuItem1.Click += new System.EventHandler(this.refreshToolStripMenuItem1_Click);
            // 
            // promoteToolStripMenuItem
            // 
            this.promoteToolStripMenuItem.Image = global::DebateSidebarWordAddIn.Properties.Resources.b;
            this.promoteToolStripMenuItem.Name = "promoteToolStripMenuItem";
            this.promoteToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.promoteToolStripMenuItem.Text = "Promote";
            this.promoteToolStripMenuItem.Click += new System.EventHandler(this.promoteToolStripMenuItem_Click);
            // 
            // demoteToolStripMenuItem
            // 
            this.demoteToolStripMenuItem.Image = global::DebateSidebarWordAddIn.Properties.Resources.f;
            this.demoteToolStripMenuItem.Name = "demoteToolStripMenuItem";
            this.demoteToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.demoteToolStripMenuItem.Text = "Demote";
            this.demoteToolStripMenuItem.Click += new System.EventHandler(this.demoteToolStripMenuItem_Click);
            // 
            // collapseAllToolStripMenuItem
            // 
            this.collapseAllToolStripMenuItem.Image = global::DebateSidebarWordAddIn.Properties.Resources.bb;
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            this.collapseAllToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.collapseAllToolStripMenuItem.Text = "Collapse All";
            this.collapseAllToolStripMenuItem.Click += new System.EventHandler(this.collapseAllToolStripMenuItem_Click);
            // 
            // expandAllToolStripMenuItem
            // 
            this.expandAllToolStripMenuItem.Image = global::DebateSidebarWordAddIn.Properties.Resources.ff;
            this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            this.expandAllToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.expandAllToolStripMenuItem.Text = "Expand All";
            this.expandAllToolStripMenuItem.Click += new System.EventHandler(this.expandAllToolStripMenuItem_Click);
            // 
            // bCollapseHeading2
            // 
            this.bCollapseHeading2.Image = ((System.Drawing.Image)(resources.GetObject("bCollapseHeading2.Image")));
            this.bCollapseHeading2.Name = "bCollapseHeading2";
            this.bCollapseHeading2.Size = new System.Drawing.Size(190, 22);
            this.bCollapseHeading2.Text = "Collapse to Heading 2";
            this.bCollapseHeading2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.bCollapseHeading2.Click += new System.EventHandler(this.bCollapseHeading2_Click);
            // 
            // bCollapseHeading3
            // 
            this.bCollapseHeading3.Image = ((System.Drawing.Image)(resources.GetObject("bCollapseHeading3.Image")));
            this.bCollapseHeading3.Name = "bCollapseHeading3";
            this.bCollapseHeading3.Size = new System.Drawing.Size(190, 22);
            this.bCollapseHeading3.Text = "Collapse to Heading 3";
            this.bCollapseHeading3.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.bCollapseHeading3.Click += new System.EventHandler(this.bCollapseHeading3_Click);
            // 
            // toolsMain
            // 
            this.toolsMain.Dock = System.Windows.Forms.DockStyle.None;
            this.toolsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bFilesShow,
            this.bRefreshDocMain,
            this.bFormattingMain,
            this.bSpeechMain,
            this.bSwitchWindow,
            this.bSearchString});
            this.toolsMain.Location = new System.Drawing.Point(3, 0);
            this.toolsMain.Name = "toolsMain";
            this.toolsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolsMain.Size = new System.Drawing.Size(257, 25);
            this.toolsMain.TabIndex = 1;
            this.toolsMain.Text = "toolStrip2";
            // 
            // bFilesShow
            // 
            this.bFilesShow.CheckOnClick = true;
            this.bFilesShow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bFilesShow.Image = ((System.Drawing.Image)(resources.GetObject("bFilesShow.Image")));
            this.bFilesShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bFilesShow.Name = "bFilesShow";
            this.bFilesShow.Size = new System.Drawing.Size(23, 22);
            this.bFilesShow.Text = "Show / hide Debate Files";
            this.bFilesShow.Click += new System.EventHandler(this.bFilesShow_Click);
            // 
            // bRefreshDocMain
            // 
            this.bRefreshDocMain.BackColor = System.Drawing.Color.White;
            this.bRefreshDocMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bRefreshDocMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.bExpandAll,
            this.bCollapseHeading1,
            this.collapseToHeading2ToolStripMenuItem,
            this.collapseToHeading3ToolStripMenuItem});
            this.bRefreshDocMain.Image = global::DebateSidebarWordAddIn.Properties.Resources.refresh;
            this.bRefreshDocMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bRefreshDocMain.Name = "bRefreshDocMain";
            this.bRefreshDocMain.Size = new System.Drawing.Size(32, 22);
            this.bRefreshDocMain.Text = "Refresh Navigation Pane";
            this.bRefreshDocMain.ButtonClick += new System.EventHandler(this.bRefreshDocMain_ButtonClick);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::DebateSidebarWordAddIn.Properties.Resources.refresh;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // bExpandAll
            // 
            this.bExpandAll.Image = global::DebateSidebarWordAddIn.Properties.Resources.ff;
            this.bExpandAll.Name = "bExpandAll";
            this.bExpandAll.Size = new System.Drawing.Size(190, 22);
            this.bExpandAll.Text = "Expand All";
            this.bExpandAll.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.bExpandAll.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click_1);
            // 
            // bCollapseHeading1
            // 
            this.bCollapseHeading1.Image = global::DebateSidebarWordAddIn.Properties.Resources.bb;
            this.bCollapseHeading1.Name = "bCollapseHeading1";
            this.bCollapseHeading1.Size = new System.Drawing.Size(190, 22);
            this.bCollapseHeading1.Text = "Collapse All";
            this.bCollapseHeading1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.bCollapseHeading1.Click += new System.EventHandler(this.showToHeading1ToolStripMenuItem_Click);
            // 
            // collapseToHeading2ToolStripMenuItem
            // 
            this.collapseToHeading2ToolStripMenuItem.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8fheading;
            this.collapseToHeading2ToolStripMenuItem.Name = "collapseToHeading2ToolStripMenuItem";
            this.collapseToHeading2ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.collapseToHeading2ToolStripMenuItem.Text = "Collapse to Heading 2";
            this.collapseToHeading2ToolStripMenuItem.Click += new System.EventHandler(this.showToHeading2ToolStripMenuItem_Click);
            // 
            // collapseToHeading3ToolStripMenuItem
            // 
            this.collapseToHeading3ToolStripMenuItem.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8fheading;
            this.collapseToHeading3ToolStripMenuItem.Name = "collapseToHeading3ToolStripMenuItem";
            this.collapseToHeading3ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.collapseToHeading3ToolStripMenuItem.Text = "Collapse to Heading 3";
            this.collapseToHeading3ToolStripMenuItem.Click += new System.EventHandler(this.showToHeading3ToolStripMenuItem_Click);
            // 
            // bFormattingMain
            // 
            this.bFormattingMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bFormattingMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoUnderlineToolStripMenuItem,
            this.autoHightlightToolStripMenuItem,
            this.bPaste,
            this.bReturns,
            this.bHeading1,
            this.bHeading2,
            this.bHeading3,
            this.bHeading4,
            this.minimizeUnreadToolStripMenuItem,
            this.selectSimilarToolStripMenuItem,
            this.caselistToolStripMenuItem,
            this.removeFormattingToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.bFormattingMain.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8pastereturns;
            this.bFormattingMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bFormattingMain.Name = "bFormattingMain";
            this.bFormattingMain.Size = new System.Drawing.Size(32, 22);
            this.bFormattingMain.Text = "Formatting";
            this.bFormattingMain.ButtonClick += new System.EventHandler(this.bFormattingMain_ButtonClick);
            // 
            // autoUnderlineToolStripMenuItem
            // 
            this.autoUnderlineToolStripMenuItem.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8fsmallall;
            this.autoUnderlineToolStripMenuItem.Name = "autoUnderlineToolStripMenuItem";
            this.autoUnderlineToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.autoUnderlineToolStripMenuItem.Text = "Underline Mode";
            this.autoUnderlineToolStripMenuItem.Click += new System.EventHandler(this.autoUnderlineToolStripMenuItem_Click);
            // 
            // autoHightlightToolStripMenuItem
            // 
            this.autoHightlightToolStripMenuItem.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8fhighlite;
            this.autoHightlightToolStripMenuItem.Name = "autoHightlightToolStripMenuItem";
            this.autoHightlightToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.autoHightlightToolStripMenuItem.Text = "Highlight Mode";
            this.autoHightlightToolStripMenuItem.Click += new System.EventHandler(this.autoHightlightToolStripMenuItem_Click);
            // 
            // bPaste
            // 
            this.bPaste.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8pastereturns;
            this.bPaste.Name = "bPaste";
            this.bPaste.Size = new System.Drawing.Size(179, 22);
            this.bPaste.Text = "Paste Text";
            this.bPaste.Click += new System.EventHandler(this.bPaste_Click);
            // 
            // bReturns
            // 
            this.bReturns.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8returns;
            this.bReturns.Name = "bReturns";
            this.bReturns.Size = new System.Drawing.Size(179, 22);
            this.bReturns.Text = "Remove Returns";
            this.bReturns.Click += new System.EventHandler(this.bReturns_Click);
            // 
            // bHeading1
            // 
            this.bHeading1.Image = ((System.Drawing.Image)(resources.GetObject("bHeading1.Image")));
            this.bHeading1.Name = "bHeading1";
            this.bHeading1.Size = new System.Drawing.Size(179, 22);
            this.bHeading1.Text = "Set Heading 1";
            this.bHeading1.Click += new System.EventHandler(this.bHeading1_Click);
            // 
            // bHeading2
            // 
            this.bHeading2.Image = ((System.Drawing.Image)(resources.GetObject("bHeading2.Image")));
            this.bHeading2.Name = "bHeading2";
            this.bHeading2.Size = new System.Drawing.Size(179, 22);
            this.bHeading2.Text = "Set Heading 2";
            this.bHeading2.Click += new System.EventHandler(this.bHeading2_Click);
            // 
            // bHeading3
            // 
            this.bHeading3.Image = ((System.Drawing.Image)(resources.GetObject("bHeading3.Image")));
            this.bHeading3.Name = "bHeading3";
            this.bHeading3.Size = new System.Drawing.Size(179, 22);
            this.bHeading3.Text = "Set Heading 3";
            this.bHeading3.Click += new System.EventHandler(this.bHeading3_Click);
            // 
            // bHeading4
            // 
            this.bHeading4.Image = ((System.Drawing.Image)(resources.GetObject("bHeading4.Image")));
            this.bHeading4.Name = "bHeading4";
            this.bHeading4.Size = new System.Drawing.Size(179, 22);
            this.bHeading4.Text = "Set Heading 4";
            this.bHeading4.Click += new System.EventHandler(this.bHeading4_Click);
            // 
            // minimizeUnreadToolStripMenuItem
            // 
            this.minimizeUnreadToolStripMenuItem.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8fsmallallmore;
            this.minimizeUnreadToolStripMenuItem.Name = "minimizeUnreadToolStripMenuItem";
            this.minimizeUnreadToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.minimizeUnreadToolStripMenuItem.Text = "Minimize Unread";
            this.minimizeUnreadToolStripMenuItem.Click += new System.EventHandler(this.minimizeUnreadToolStripMenuItem_Click);
            // 
            // selectSimilarToolStripMenuItem
            // 
            this.selectSimilarToolStripMenuItem.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8fsimilar;
            this.selectSimilarToolStripMenuItem.Name = "selectSimilarToolStripMenuItem";
            this.selectSimilarToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.selectSimilarToolStripMenuItem.Text = "Select Similar";
            this.selectSimilarToolStripMenuItem.Click += new System.EventHandler(this.selectSimilarToolStripMenuItem_Click);
            // 
            // caselistToolStripMenuItem
            // 
            this.caselistToolStripMenuItem.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8check;
            this.caselistToolStripMenuItem.Name = "caselistToolStripMenuItem";
            this.caselistToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.caselistToolStripMenuItem.Text = "Caselist Cites";
            this.caselistToolStripMenuItem.Click += new System.EventHandler(this.caselistToolStripMenuItem_Click);
            // 
            // removeFormattingToolStripMenuItem
            // 
            this.removeFormattingToolStripMenuItem.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8fclear;
            this.removeFormattingToolStripMenuItem.Name = "removeFormattingToolStripMenuItem";
            this.removeFormattingToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.removeFormattingToolStripMenuItem.Text = "Remove Formatting";
            this.removeFormattingToolStripMenuItem.Click += new System.EventHandler(this.removeFormattingToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsToolStripMenuItem.Image = global::DebateSidebarWordAddIn.Properties.Resources.settings;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // bSpeechMain
            // 
            this.bSpeechMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bSpeechMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bSpeechAdd,
            this.sendToSpeechToolStripMenuItem,
            this.bReadSpeech,
            this.bCopyUSB,
            this.timerToolStripMenuItem});
            this.bSpeechMain.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8ssend;
            this.bSpeechMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bSpeechMain.Name = "bSpeechMain";
            this.bSpeechMain.Size = new System.Drawing.Size(32, 22);
            this.bSpeechMain.Text = "Send Selection to Speech";
            this.bSpeechMain.ButtonClick += new System.EventHandler(this.toolStripSplitButton2_ButtonClick);
            // 
            // bSpeechAdd
            // 
            this.bSpeechAdd.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8s2ar;
            this.bSpeechAdd.Name = "bSpeechAdd";
            this.bSpeechAdd.Size = new System.Drawing.Size(154, 22);
            this.bSpeechAdd.Text = "New Speech";
            this.bSpeechAdd.Click += new System.EventHandler(this.bSpeechAdd_Click);
            // 
            // sendToSpeechToolStripMenuItem
            // 
            this.sendToSpeechToolStripMenuItem.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8ssend;
            this.sendToSpeechToolStripMenuItem.Name = "sendToSpeechToolStripMenuItem";
            this.sendToSpeechToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sendToSpeechToolStripMenuItem.Text = "Send to speech";
            this.sendToSpeechToolStripMenuItem.Click += new System.EventHandler(this.sendToSpeechToolStripMenuItem_Click);
            // 
            // bReadSpeech
            // 
            this.bReadSpeech.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8spbreak;
            this.bReadSpeech.Name = "bReadSpeech";
            this.bReadSpeech.Size = new System.Drawing.Size(154, 22);
            this.bReadSpeech.Text = "Read speech";
            this.bReadSpeech.Click += new System.EventHandler(this.bReadSpeech_Click);
            // 
            // bCopyUSB
            // 
            this.bCopyUSB.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8spsave;
            this.bCopyUSB.Name = "bCopyUSB";
            this.bCopyUSB.Size = new System.Drawing.Size(154, 22);
            this.bCopyUSB.Text = "Copy to USB";
            this.bCopyUSB.Click += new System.EventHandler(this.bCopyUSB_Click);
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8timerlogo;
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.timerToolStripMenuItem.Text = "Timer";
            this.timerToolStripMenuItem.Click += new System.EventHandler(this.timerToolStripMenuItem_Click);
            // 
            // bSwitchWindow
            // 
            this.bSwitchWindow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bSwitchWindow.Image = global::DebateSidebarWordAddIn.Properties.Resources.windows;
            this.bSwitchWindow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bSwitchWindow.Name = "bSwitchWindow";
            this.bSwitchWindow.Size = new System.Drawing.Size(29, 22);
            this.bSwitchWindow.Text = "Switch Current Windows";
            this.bSwitchWindow.DropDownOpening += new System.EventHandler(this.DropOnDropDownOpening);
            this.bSwitchWindow.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.bSwitchWindows_DropDownItemClicked);
            // 
            // bSearchString
            // 
            this.bSearchString.AcceptsReturn = true;
            this.bSearchString.MaxLength = 20;
            this.bSearchString.Name = "bSearchString";
            this.bSearchString.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.bSearchString.Size = new System.Drawing.Size(80, 25);
            this.bSearchString.ToolTipText = "Search current file or Debate Files document titles";
            this.bSearchString.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bSearchString_KeyUp);
            // 
            // MainPanel
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.Controls.Add(this.toolStripContainer4);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MainPanel";
            this.Size = new System.Drawing.Size(260, 300);
            this.toolStripContainer4.ContentPanel.ResumeLayout(false);
            this.toolStripContainer4.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer4.TopToolStripPanel.PerformLayout();
            this.toolStripContainer4.ResumeLayout(false);
            this.toolStripContainer4.PerformLayout();
            this.contextTreeFiles.ResumeLayout(false);
            this.contextTreeDoc.ResumeLayout(false);
            this.toolsMain.ResumeLayout(false);
            this.toolsMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer4;
        private System.Windows.Forms.ContextMenuStrip contextTreeDoc;
        private System.Windows.Forms.ToolStrip toolsMain;
        private System.Windows.Forms.ToolStripButton bFilesShow;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bExpandAll;
        private System.Windows.Forms.ToolStripMenuItem bCollapseHeading1;
        private System.Windows.Forms.ToolStripSplitButton bFormattingMain;
        private System.Windows.Forms.ToolStripMenuItem bPaste;
        private System.Windows.Forms.ToolStripMenuItem bReturns;
        private System.Windows.Forms.ToolStripMenuItem autoUnderlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoHightlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bHeading1;
        private System.Windows.Forms.ToolStripMenuItem bHeading2;
        private System.Windows.Forms.ToolStripMenuItem bHeading3;
        private System.Windows.Forms.ToolStripMenuItem minimizeUnreadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectSimilarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caselistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFormattingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton bSpeechMain;
        private System.Windows.Forms.ToolStripMenuItem bSpeechAdd;
        private System.Windows.Forms.ToolStripMenuItem sendToSpeechToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bReadSpeech;
        private System.Windows.Forms.ToolStripMenuItem bCopyUSB;
        private System.Windows.Forms.ToolStripTextBox bSearchString;
        private System.Windows.Forms.TreeView treeFiles;
        private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bHeading4;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
        public System.Windows.Forms.ToolStripSplitButton bRefreshDocMain;
        public System.Windows.Forms.ToolStripDropDownButton bSwitchWindow;
        private System.Windows.Forms.ToolStripMenuItem promoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseToHeading2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseToHeading3ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextTreeFiles;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem bCollapseHeading2;
        public System.Windows.Forms.ToolStripMenuItem bCollapseHeading3;
        public System.Windows.Forms.TreeView treeDoc;
    }
}
