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
            this.contextFilesCollapse = new System.Windows.Forms.ToolStripMenuItem();
            this.contextFilesExpand = new System.Windows.Forms.ToolStripMenuItem();
            this.treeDoc = new System.Windows.Forms.TreeView();
            this.contextHeadings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.contextPromote = new System.Windows.Forms.ToolStripMenuItem();
            this.contextDemote = new System.Windows.Forms.ToolStripMenuItem();
            this.contextRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextCollapse = new System.Windows.Forms.ToolStripMenuItem();
            this.contextCollapseHeading2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextCollapseHeading3 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextExpand = new System.Windows.Forms.ToolStripMenuItem();
            this.Menubar = new System.Windows.Forms.ToolStrip();
            this.bFilesShow = new System.Windows.Forms.ToolStripButton();
            this.bRefreshMenubar = new System.Windows.Forms.ToolStripSplitButton();
            this.bCollapse = new System.Windows.Forms.ToolStripMenuItem();
            this.bCollapseHeading2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bCollapseHeading3 = new System.Windows.Forms.ToolStripMenuItem();
            this.bExpand = new System.Windows.Forms.ToolStripMenuItem();
            this.bPasteMenubar = new System.Windows.Forms.ToolStripSplitButton();
            this.bUnderlineMode = new System.Windows.Forms.ToolStripMenuItem();
            this.bHightlightMode = new System.Windows.Forms.ToolStripMenuItem();
            this.bPasteText = new System.Windows.Forms.ToolStripMenuItem();
            this.bRemoveReturns = new System.Windows.Forms.ToolStripMenuItem();
            this.bHeading1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bHeading2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bHeading3 = new System.Windows.Forms.ToolStripMenuItem();
            this.bHeading4 = new System.Windows.Forms.ToolStripMenuItem();
            this.bMinimizeUnread = new System.Windows.Forms.ToolStripMenuItem();
            this.bSelectSimilar = new System.Windows.Forms.ToolStripMenuItem();
            this.bCaselist = new System.Windows.Forms.ToolStripMenuItem();
            this.bRemoveFormatting = new System.Windows.Forms.ToolStripMenuItem();
            this.bSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.bSpeechMenubar = new System.Windows.Forms.ToolStripSplitButton();
            this.bManageSpeech = new System.Windows.Forms.ToolStripMenuItem();
            this.bSendToSpeech = new System.Windows.Forms.ToolStripMenuItem();
            this.bReadSpeech = new System.Windows.Forms.ToolStripMenuItem();
            this.bTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.bSwitchWindow = new System.Windows.Forms.ToolStripDropDownButton();
            this.dropdownWindows = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripContainer4.ContentPanel.SuspendLayout();
            this.toolStripContainer4.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer4.SuspendLayout();
            this.contextFiles.SuspendLayout();
            this.contextHeadings.SuspendLayout();
            this.Menubar.SuspendLayout();
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
            this.toolStripContainer4.ContentPanel.Size = new System.Drawing.Size(251, 138);
            this.toolStripContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer4.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer4.Name = "toolStripContainer4";
            this.toolStripContainer4.Size = new System.Drawing.Size(251, 163);
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
            this.treeFiles.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeFiles.Location = new System.Drawing.Point(0, 0);
            this.treeFiles.Margin = new System.Windows.Forms.Padding(0);
            this.treeFiles.Name = "treeFiles";
            this.treeFiles.Size = new System.Drawing.Size(251, 138);
            this.treeFiles.TabIndex = 3;
            this.treeFiles.Visible = false;
            this.treeFiles.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeFiles_NodeMouseDoubleClick);
            // 
            // contextFiles
            // 
            this.contextFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderToolStripMenuItem,
            this.contextFilesCollapse,
            this.contextFilesExpand});
            this.contextFiles.Name = "contextTreeFiles";
            this.contextFiles.Size = new System.Drawing.Size(140, 70);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Image = global::DebateSidebarWordAddIn.Properties.Resources.folders;
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.contextFilesFolder_Click);
            // 
            // contextFilesCollapse
            // 
            this.contextFilesCollapse.Image = global::DebateSidebarWordAddIn.Properties.Resources.bb;
            this.contextFilesCollapse.Name = "contextFilesCollapse";
            this.contextFilesCollapse.Size = new System.Drawing.Size(139, 22);
            this.contextFilesCollapse.Text = "Collapse All";
            this.contextFilesCollapse.Click += new System.EventHandler(this.contextFilesCollapse_Click);
            // 
            // contextFilesExpand
            // 
            this.contextFilesExpand.Image = global::DebateSidebarWordAddIn.Properties.Resources.ff;
            this.contextFilesExpand.Name = "contextFilesExpand";
            this.contextFilesExpand.Size = new System.Drawing.Size(139, 22);
            this.contextFilesExpand.Text = "Expand All";
            this.contextFilesExpand.Click += new System.EventHandler(this.contextFilesExpand_Click);
            // 
            // treeDoc
            // 
            this.treeDoc.AllowDrop = true;
            this.treeDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeDoc.ContextMenuStrip = this.contextHeadings;
            this.treeDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeDoc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeDoc.FullRowSelect = true;
            this.treeDoc.Indent = 10;
            this.treeDoc.ItemHeight = 14;
            this.treeDoc.Location = new System.Drawing.Point(0, 0);
            this.treeDoc.Margin = new System.Windows.Forms.Padding(0);
            this.treeDoc.Name = "treeDoc";
            this.treeDoc.ShowLines = false;
            this.treeDoc.Size = new System.Drawing.Size(251, 138);
            this.treeDoc.TabIndex = 4;
            this.treeDoc.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeDoc_AfterExpand);
            this.treeDoc.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.treeDoc_NodeMouseHover);
            this.treeDoc.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeDoc_NodeMouseClick);
            // 
            // contextHeadings
            // 
            this.contextHeadings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextRefresh,
            this.contextPromote,
            this.contextDemote,
            this.contextRemove,
            this.toolStripSeparator1,
            this.contextCollapse,
            this.contextCollapseHeading2,
            this.contextCollapseHeading3,
            this.contextExpand});
            this.contextHeadings.Name = "treeDocContentMenu";
            this.contextHeadings.Size = new System.Drawing.Size(173, 186);
            // 
            // contextRefresh
            // 
            this.contextRefresh.Image = global::DebateSidebarWordAddIn.Properties.Resources.refresh;
            this.contextRefresh.Name = "contextRefresh";
            this.contextRefresh.Size = new System.Drawing.Size(172, 22);
            this.contextRefresh.Text = "Refresh";
            this.contextRefresh.Click += new System.EventHandler(this.contextRefresh_Click);
            // 
            // contextPromote
            // 
            this.contextPromote.Image = global::DebateSidebarWordAddIn.Properties.Resources.b;
            this.contextPromote.Name = "contextPromote";
            this.contextPromote.Size = new System.Drawing.Size(172, 22);
            this.contextPromote.Text = "Promote";
            this.contextPromote.Click += new System.EventHandler(this.contextPromote_Click);
            // 
            // contextDemote
            // 
            this.contextDemote.Image = global::DebateSidebarWordAddIn.Properties.Resources.f;
            this.contextDemote.Name = "contextDemote";
            this.contextDemote.Size = new System.Drawing.Size(172, 22);
            this.contextDemote.Text = "Demote";
            this.contextDemote.Click += new System.EventHandler(this.contextDemote_Click);
            // 
            // contextRemove
            // 
            this.contextRemove.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8fclear;
            this.contextRemove.Name = "contextRemove";
            this.contextRemove.Size = new System.Drawing.Size(172, 22);
            this.contextRemove.Text = "Remove";
            this.contextRemove.Click += new System.EventHandler(this.contextRemove_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // contextCollapse
            // 
            this.contextCollapse.Image = global::DebateSidebarWordAddIn.Properties.Resources.bb;
            this.contextCollapse.Name = "contextCollapse";
            this.contextCollapse.Size = new System.Drawing.Size(172, 22);
            this.contextCollapse.Text = "Collapse All";
            this.contextCollapse.Click += new System.EventHandler(this.contextCollapse_Click);
            // 
            // contextCollapseHeading2
            // 
            this.contextCollapseHeading2.Image = ((System.Drawing.Image)(resources.GetObject("contextCollapseHeading2.Image")));
            this.contextCollapseHeading2.Name = "contextCollapseHeading2";
            this.contextCollapseHeading2.Size = new System.Drawing.Size(172, 22);
            this.contextCollapseHeading2.Text = "2nd Heading Level";
            this.contextCollapseHeading2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.contextCollapseHeading2.Click += new System.EventHandler(this.contextCollapseHeading2_Click);
            // 
            // contextCollapseHeading3
            // 
            this.contextCollapseHeading3.Image = ((System.Drawing.Image)(resources.GetObject("contextCollapseHeading3.Image")));
            this.contextCollapseHeading3.Name = "contextCollapseHeading3";
            this.contextCollapseHeading3.Size = new System.Drawing.Size(172, 22);
            this.contextCollapseHeading3.Text = "3rd Heading Level";
            this.contextCollapseHeading3.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.contextCollapseHeading3.Click += new System.EventHandler(this.contextCollapseHeading3_Click);
            // 
            // contextExpand
            // 
            this.contextExpand.Image = global::DebateSidebarWordAddIn.Properties.Resources.ff;
            this.contextExpand.Name = "contextExpand";
            this.contextExpand.Size = new System.Drawing.Size(172, 22);
            this.contextExpand.Text = "Expand All";
            this.contextExpand.Click += new System.EventHandler(this.contextExpand_Click);
            // 
            // Menubar
            // 
            this.Menubar.BackColor = System.Drawing.Color.White;
            this.Menubar.Dock = System.Windows.Forms.DockStyle.None;
            this.Menubar.GripMargin = new System.Windows.Forms.Padding(0);
            this.Menubar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bFilesShow,
            this.bRefreshMenubar,
            this.bPasteMenubar,
            this.bSpeechMenubar,
            this.bSwitchWindow,
            this.bSearch});
            this.Menubar.Location = new System.Drawing.Point(3, 0);
            this.Menubar.Name = "Menubar";
            this.Menubar.Padding = new System.Windows.Forms.Padding(0);
            this.Menubar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menubar.Size = new System.Drawing.Size(232, 25);
            this.Menubar.TabIndex = 1;
            this.Menubar.Text = "toolStrip2";
            // 
            // bFilesShow
            // 
            this.bFilesShow.CheckOnClick = true;
            this.bFilesShow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bFilesShow.Image = ((System.Drawing.Image)(resources.GetObject("bFilesShow.Image")));
            this.bFilesShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bFilesShow.Name = "bFilesShow";
            this.bFilesShow.Size = new System.Drawing.Size(23, 22);
            this.bFilesShow.Text = "Switch between Headings Index and Debate Files";
            this.bFilesShow.Click += new System.EventHandler(this.bSwitchFilesHeadings_Click);
            // 
            // bRefreshMenubar
            // 
            this.bRefreshMenubar.BackColor = System.Drawing.Color.White;
            this.bRefreshMenubar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bRefreshMenubar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bCollapse,
            this.bCollapseHeading2,
            this.bCollapseHeading3,
            this.bExpand});
            this.bRefreshMenubar.Image = global::DebateSidebarWordAddIn.Properties.Resources.refresh;
            this.bRefreshMenubar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bRefreshMenubar.Name = "bRefreshMenubar";
            this.bRefreshMenubar.Size = new System.Drawing.Size(32, 22);
            this.bRefreshMenubar.Text = "Refresh Navigation Pane";
            this.bRefreshMenubar.ButtonClick += new System.EventHandler(this.bRefresh_Click);
            // 
            // bCollapse
            // 
            this.bCollapse.BackColor = System.Drawing.Color.White;
            this.bCollapse.Image = global::DebateSidebarWordAddIn.Properties.Resources.bb;
            this.bCollapse.Name = "bCollapse";
            this.bCollapse.Size = new System.Drawing.Size(172, 22);
            this.bCollapse.Text = "Collapse All";
            this.bCollapse.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.bCollapse.Click += new System.EventHandler(this.bCollapse_Click);
            // 
            // bCollapseHeading2
            // 
            this.bCollapseHeading2.BackColor = System.Drawing.Color.White;
            this.bCollapseHeading2.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8fheading;
            this.bCollapseHeading2.Name = "bCollapseHeading2";
            this.bCollapseHeading2.Size = new System.Drawing.Size(172, 22);
            this.bCollapseHeading2.Text = "2nd Heading Level";
            this.bCollapseHeading2.Click += new System.EventHandler(this.bCollapseHeading2_Click);
            // 
            // bCollapseHeading3
            // 
            this.bCollapseHeading3.BackColor = System.Drawing.Color.White;
            this.bCollapseHeading3.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8fheading;
            this.bCollapseHeading3.Name = "bCollapseHeading3";
            this.bCollapseHeading3.Size = new System.Drawing.Size(172, 22);
            this.bCollapseHeading3.Text = "3rd Heading Level";
            this.bCollapseHeading3.Click += new System.EventHandler(this.bCollapseHeading3_Click);
            // 
            // bExpand
            // 
            this.bExpand.BackColor = System.Drawing.Color.White;
            this.bExpand.Image = global::DebateSidebarWordAddIn.Properties.Resources.ff;
            this.bExpand.Name = "bExpand";
            this.bExpand.Size = new System.Drawing.Size(172, 22);
            this.bExpand.Text = "Expand All";
            this.bExpand.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.bExpand.Click += new System.EventHandler(this.bExpand_Click);
            // 
            // bPasteMenubar
            // 
            this.bPasteMenubar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bPasteMenubar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bUnderlineMode,
            this.bHightlightMode,
            this.bPasteText,
            this.bRemoveReturns,
            this.bHeading1,
            this.bHeading2,
            this.bHeading3,
            this.bHeading4,
            this.bMinimizeUnread,
            this.bSelectSimilar,
            this.bCaselist,
            this.bRemoveFormatting,
            this.bSettings});
            this.bPasteMenubar.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8pastereturns;
            this.bPasteMenubar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bPasteMenubar.Name = "bPasteMenubar";
            this.bPasteMenubar.Size = new System.Drawing.Size(32, 22);
            this.bPasteMenubar.Text = "Paste Text";
            this.bPasteMenubar.ButtonClick += new System.EventHandler(this.FormatMacro_Click);
            // 
            // bUnderlineMode
            // 
            this.bUnderlineMode.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8fsmallall;
            this.bUnderlineMode.Name = "bUnderlineMode";
            this.bUnderlineMode.Size = new System.Drawing.Size(179, 22);
            this.bUnderlineMode.Text = "Underline Mode";
            this.bUnderlineMode.Click += new System.EventHandler(this.FormatMacro_Click);
            // 
            // bHightlightMode
            // 
            this.bHightlightMode.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8fhighlite;
            this.bHightlightMode.Name = "bHightlightMode";
            this.bHightlightMode.Size = new System.Drawing.Size(179, 22);
            this.bHightlightMode.Text = "Highlight Mode";
            this.bHightlightMode.Click += new System.EventHandler(this.FormatMacro_Click);
            // 
            // bPasteText
            // 
            this.bPasteText.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8pastereturns;
            this.bPasteText.Name = "bPasteText";
            this.bPasteText.Size = new System.Drawing.Size(179, 22);
            this.bPasteText.Text = "Paste Text";
            this.bPasteText.Click += new System.EventHandler(this.FormatMacro_Click);
            // 
            // bRemoveReturns
            // 
            this.bRemoveReturns.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8returns;
            this.bRemoveReturns.Name = "bRemoveReturns";
            this.bRemoveReturns.Size = new System.Drawing.Size(179, 22);
            this.bRemoveReturns.Text = "Remove Returns";
            this.bRemoveReturns.Click += new System.EventHandler(this.FormatMacro_Click);
            // 
            // bHeading1
            // 
            this.bHeading1.Image = ((System.Drawing.Image)(resources.GetObject("bHeading1.Image")));
            this.bHeading1.Name = "bHeading1";
            this.bHeading1.Size = new System.Drawing.Size(179, 22);
            this.bHeading1.Text = "Heading 1";
            this.bHeading1.Click += new System.EventHandler(this.FormatMacro_Click);
            // 
            // bHeading2
            // 
            this.bHeading2.Image = ((System.Drawing.Image)(resources.GetObject("bHeading2.Image")));
            this.bHeading2.Name = "bHeading2";
            this.bHeading2.Size = new System.Drawing.Size(179, 22);
            this.bHeading2.Text = "Heading 2";
            this.bHeading2.Click += new System.EventHandler(this.FormatMacro_Click);
            // 
            // bHeading3
            // 
            this.bHeading3.Image = ((System.Drawing.Image)(resources.GetObject("bHeading3.Image")));
            this.bHeading3.Name = "bHeading3";
            this.bHeading3.Size = new System.Drawing.Size(179, 22);
            this.bHeading3.Text = "Heading 3";
            this.bHeading3.Click += new System.EventHandler(this.FormatMacro_Click);
            // 
            // bHeading4
            // 
            this.bHeading4.Image = ((System.Drawing.Image)(resources.GetObject("bHeading4.Image")));
            this.bHeading4.Name = "bHeading4";
            this.bHeading4.Size = new System.Drawing.Size(179, 22);
            this.bHeading4.Text = "Heading 4";
            this.bHeading4.Click += new System.EventHandler(this.FormatMacro_Click);
            // 
            // bMinimizeUnread
            // 
            this.bMinimizeUnread.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8fsmallallmore;
            this.bMinimizeUnread.Name = "bMinimizeUnread";
            this.bMinimizeUnread.Size = new System.Drawing.Size(179, 22);
            this.bMinimizeUnread.Text = "Minimize Unread";
            this.bMinimizeUnread.Click += new System.EventHandler(this.FormatMacro_Click);
            // 
            // bSelectSimilar
            // 
            this.bSelectSimilar.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8fsimilar;
            this.bSelectSimilar.Name = "bSelectSimilar";
            this.bSelectSimilar.Size = new System.Drawing.Size(179, 22);
            this.bSelectSimilar.Text = "Select Similar";
            this.bSelectSimilar.Click += new System.EventHandler(this.FormatMacro_Click);
            // 
            // bCaselist
            // 
            this.bCaselist.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8check;
            this.bCaselist.Name = "bCaselist";
            this.bCaselist.Size = new System.Drawing.Size(179, 22);
            this.bCaselist.Text = "Caselist Cites";
            this.bCaselist.Click += new System.EventHandler(this.FormatMacro_Click);
            // 
            // bRemoveFormatting
            // 
            this.bRemoveFormatting.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8fclear;
            this.bRemoveFormatting.Name = "bRemoveFormatting";
            this.bRemoveFormatting.Size = new System.Drawing.Size(179, 22);
            this.bRemoveFormatting.Text = "Remove Formatting";
            this.bRemoveFormatting.Click += new System.EventHandler(this.FormatMacro_Click);
            // 
            // bSettings
            // 
            this.bSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSettings.Image = global::DebateSidebarWordAddIn.Properties.Resources.settings;
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(179, 22);
            this.bSettings.Text = "Settings";
            this.bSettings.Click += new System.EventHandler(this.FormatMacro_Click);
            // 
            // bSpeechMenubar
            // 
            this.bSpeechMenubar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bSpeechMenubar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bManageSpeech,
            this.bSendToSpeech,
            this.bReadSpeech,
            this.bTimer});
            this.bSpeechMenubar.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8ssend;
            this.bSpeechMenubar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bSpeechMenubar.Name = "bSpeechMenubar";
            this.bSpeechMenubar.Size = new System.Drawing.Size(32, 22);
            this.bSpeechMenubar.Text = "Send to Speech";
            this.bSpeechMenubar.ButtonClick += new System.EventHandler(this.FormatMacro_Click);
            // 
            // bManageSpeech
            // 
            this.bManageSpeech.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8s2ar;
            this.bManageSpeech.Name = "bManageSpeech";
            this.bManageSpeech.Size = new System.Drawing.Size(158, 22);
            this.bManageSpeech.Text = "Manage Speech";
            this.bManageSpeech.Click += new System.EventHandler(this.FormatMacro_Click);
            // 
            // bSendToSpeech
            // 
            this.bSendToSpeech.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8ssend;
            this.bSendToSpeech.Name = "bSendToSpeech";
            this.bSendToSpeech.Size = new System.Drawing.Size(158, 22);
            this.bSendToSpeech.Text = "Send to Speech";
            this.bSendToSpeech.Click += new System.EventHandler(this.FormatMacro_Click);
            // 
            // bReadSpeech
            // 
            this.bReadSpeech.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8spbreak;
            this.bReadSpeech.Name = "bReadSpeech";
            this.bReadSpeech.Size = new System.Drawing.Size(158, 22);
            this.bReadSpeech.Text = "Read Speech";
            this.bReadSpeech.Click += new System.EventHandler(this.FormatMacro_Click);
            // 
            // bTimer
            // 
            this.bTimer.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8timerlogo;
            this.bTimer.Name = "bTimer";
            this.bTimer.Size = new System.Drawing.Size(158, 22);
            this.bTimer.Text = "Timer";
            this.bTimer.Click += new System.EventHandler(this.FormatMacro_Click);
            // 
            // bSwitchWindow
            // 
            this.bSwitchWindow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bSwitchWindow.DropDown = this.dropdownWindows;
            this.bSwitchWindow.Image = global::DebateSidebarWordAddIn.Properties.Resources.windows;
            this.bSwitchWindow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bSwitchWindow.Name = "bSwitchWindow";
            this.bSwitchWindow.Size = new System.Drawing.Size(29, 22);
            this.bSwitchWindow.Text = "Switch Current Windows";
            // 
            // dropdownWindows
            // 
            this.dropdownWindows.Name = "dropdownWindows";
            this.dropdownWindows.OwnerItem = this.bSwitchWindow;
            this.dropdownWindows.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.dropdownWindows.ShowImageMargin = false;
            this.dropdownWindows.ShowItemToolTips = false;
            this.dropdownWindows.Size = new System.Drawing.Size(128, 26);
            this.dropdownWindows.Opening += new System.ComponentModel.CancelEventHandler(this.dropdownWindows_Opening);
            this.dropdownWindows.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.dropdownWindows_ItemClicked);
            // 
            // bSearch
            // 
            this.bSearch.AcceptsReturn = true;
            this.bSearch.MaxLength = 20;
            this.bSearch.Name = "bSearch";
            this.bSearch.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.bSearch.Size = new System.Drawing.Size(80, 25);
            this.bSearch.ToolTipText = "Search current file or Debate Files document titles";
            this.bSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bSearch_KeyDown);
            this.bSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bSearch_KeyUp);
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
            this.Size = new System.Drawing.Size(251, 163);
            this.Load += new System.EventHandler(this.Sidebar_Load);
            this.toolStripContainer4.ContentPanel.ResumeLayout(false);
            this.toolStripContainer4.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer4.TopToolStripPanel.PerformLayout();
            this.toolStripContainer4.ResumeLayout(false);
            this.toolStripContainer4.PerformLayout();
            this.contextFiles.ResumeLayout(false);
            this.contextHeadings.ResumeLayout(false);
            this.Menubar.ResumeLayout(false);
            this.Menubar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer4;
        private System.Windows.Forms.ContextMenuStrip contextHeadings;
        private System.Windows.Forms.ToolStrip Menubar;
        private System.Windows.Forms.ToolStripSplitButton bPasteMenubar;
        private System.Windows.Forms.ToolStripMenuItem bPasteText;
        private System.Windows.Forms.ToolStripMenuItem bRemoveReturns;
        private System.Windows.Forms.ToolStripMenuItem bUnderlineMode;
        private System.Windows.Forms.ToolStripMenuItem bHightlightMode;
        private System.Windows.Forms.ToolStripMenuItem bHeading1;
        private System.Windows.Forms.ToolStripMenuItem bHeading2;
        private System.Windows.Forms.ToolStripMenuItem bHeading3;
        private System.Windows.Forms.ToolStripMenuItem bMinimizeUnread;
        private System.Windows.Forms.ToolStripMenuItem bSelectSimilar;
        private System.Windows.Forms.ToolStripMenuItem bCaselist;
        private System.Windows.Forms.ToolStripMenuItem bRemoveFormatting;
        private System.Windows.Forms.ToolStripMenuItem bSettings;
        private System.Windows.Forms.ToolStripSplitButton bSpeechMenubar;
        private System.Windows.Forms.ToolStripMenuItem bManageSpeech;
        private System.Windows.Forms.ToolStripMenuItem bSendToSpeech;
        private System.Windows.Forms.ToolStripMenuItem bReadSpeech;
        private System.Windows.Forms.ToolStripTextBox bSearch;
        private System.Windows.Forms.TreeView treeFiles;
        private System.Windows.Forms.ToolStripMenuItem contextCollapse;
        private System.Windows.Forms.ToolStripMenuItem contextExpand;
        private System.Windows.Forms.ToolStripMenuItem bHeading4;
        private System.Windows.Forms.ToolStripMenuItem contextRefresh;
        public System.Windows.Forms.ToolStripSplitButton bRefreshMenubar;
        public System.Windows.Forms.ToolStripDropDownButton bSwitchWindow;
        private System.Windows.Forms.ToolStripMenuItem contextPromote;
        private System.Windows.Forms.ToolStripMenuItem contextDemote;
        private System.Windows.Forms.ContextMenuStrip contextFiles;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextFilesCollapse;
        private System.Windows.Forms.ToolStripMenuItem contextFilesExpand;
        public System.Windows.Forms.ToolStripMenuItem contextCollapseHeading2;
        public System.Windows.Forms.ToolStripMenuItem contextCollapseHeading3;
        public System.Windows.Forms.TreeView treeDoc;
        private System.Windows.Forms.ToolStripMenuItem contextRemove;
        private System.Windows.Forms.ToolStripMenuItem bTimer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripMenuItem bExpand;
        public System.Windows.Forms.ToolStripMenuItem bCollapse;
        public System.Windows.Forms.ToolStripMenuItem bCollapseHeading2;
        public System.Windows.Forms.ToolStripMenuItem bCollapseHeading3;
        private System.Windows.Forms.ContextMenuStrip dropdownWindows;
        public System.Windows.Forms.ToolStripButton bFilesShow;
    }
}
