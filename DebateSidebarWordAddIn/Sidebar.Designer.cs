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
            this.bSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.Menubar = new System.Windows.Forms.ToolStrip();
            this.bCollapse = new System.Windows.Forms.ToolStripMenuItem();
            this.bCollapseHeading2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bCollapseHeading3 = new System.Windows.Forms.ToolStripMenuItem();
            this.bExpand = new System.Windows.Forms.ToolStripMenuItem();
            this.bRefreshMenubar = new System.Windows.Forms.ToolStripSplitButton();
            this.bSearch = new System.Windows.Forms.ToolStripTextBox();
            this.dropdownWindows = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.toolStripContainer4.ContentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer4.ContentPanel.Size = new System.Drawing.Size(360, 369);
            this.toolStripContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer4.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer4.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer4.Name = "toolStripContainer4";
            this.toolStripContainer4.Size = new System.Drawing.Size(360, 400);
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
            this.treeFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.treeFiles.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeFiles.FullRowSelect = true;
            this.treeFiles.ItemHeight = 24;
            this.treeFiles.Location = new System.Drawing.Point(0, 149);
            this.treeFiles.Margin = new System.Windows.Forms.Padding(0);
            this.treeFiles.Name = "treeFiles";
            this.treeFiles.Size = new System.Drawing.Size(360, 220);
            this.treeFiles.TabIndex = 3;
            this.treeFiles.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeFiles_NodeMouseDoubleClick);
            // 
            // contextFiles
            // 
            this.contextFiles.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderToolStripMenuItem,
            this.contextFilesCollapse,
            this.contextFilesExpand});
            this.contextFiles.Name = "contextTreeFiles";
            this.contextFiles.Size = new System.Drawing.Size(169, 94);
            this.contextFiles.Opening += new System.ComponentModel.CancelEventHandler(this.contextFiles_Opening);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openFolderToolStripMenuItem.Image")));
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(168, 30);
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.contextFilesFolder_Click);
            // 
            // contextFilesCollapse
            // 
            this.contextFilesCollapse.Image = ((System.Drawing.Image)(resources.GetObject("contextFilesCollapse.Image")));
            this.contextFilesCollapse.Name = "contextFilesCollapse";
            this.contextFilesCollapse.Size = new System.Drawing.Size(168, 30);
            this.contextFilesCollapse.Text = "Collapse All";
            this.contextFilesCollapse.Click += new System.EventHandler(this.contextFilesCollapse_Click);
            // 
            // contextFilesExpand
            // 
            this.contextFilesExpand.Image = ((System.Drawing.Image)(resources.GetObject("contextFilesExpand.Image")));
            this.contextFilesExpand.Name = "contextFilesExpand";
            this.contextFilesExpand.Size = new System.Drawing.Size(168, 30);
            this.contextFilesExpand.Text = "Expand All";
            this.contextFilesExpand.Click += new System.EventHandler(this.contextFilesExpand_Click);
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
            this.treeDoc.ItemHeight = 24;
            this.treeDoc.Location = new System.Drawing.Point(0, 0);
            this.treeDoc.Margin = new System.Windows.Forms.Padding(0);
            this.treeDoc.Name = "treeDoc";
            this.treeDoc.ShowLines = false;
            this.treeDoc.Size = new System.Drawing.Size(360, 369);
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
            this.contextPromote,
            this.contextDemote,
            this.contextRemove,
            this.toolStripSeparator1,
            this.contextCollapse,
            this.contextCollapseHeading2,
            this.contextCollapseHeading3,
            this.contextExpand,
            this.bSettings});
            this.contextHeadings.Name = "treeDocContentMenu";
            this.contextHeadings.Size = new System.Drawing.Size(211, 280);
            // 
            // contextRefresh
            // 
            this.contextRefresh.Image = ((System.Drawing.Image)(resources.GetObject("contextRefresh.Image")));
            this.contextRefresh.Name = "contextRefresh";
            this.contextRefresh.Size = new System.Drawing.Size(210, 30);
            this.contextRefresh.Text = "Refresh";
            this.contextRefresh.Click += new System.EventHandler(this.contextRefresh_Click);
            // 
            // contextPromote
            // 
            this.contextPromote.Image = ((System.Drawing.Image)(resources.GetObject("contextPromote.Image")));
            this.contextPromote.Name = "contextPromote";
            this.contextPromote.Size = new System.Drawing.Size(210, 30);
            this.contextPromote.Text = "Promote";
            this.contextPromote.Click += new System.EventHandler(this.contextPromote_Click);
            // 
            // contextDemote
            // 
            this.contextDemote.Image = ((System.Drawing.Image)(resources.GetObject("contextDemote.Image")));
            this.contextDemote.Name = "contextDemote";
            this.contextDemote.Size = new System.Drawing.Size(210, 30);
            this.contextDemote.Text = "Demote";
            this.contextDemote.Click += new System.EventHandler(this.contextDemote_Click);
            // 
            // contextRemove
            // 
            this.contextRemove.Image = ((System.Drawing.Image)(resources.GetObject("contextRemove.Image")));
            this.contextRemove.Name = "contextRemove";
            this.contextRemove.Size = new System.Drawing.Size(210, 30);
            this.contextRemove.Text = "Remove";
            this.contextRemove.Click += new System.EventHandler(this.contextRemove_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // contextCollapse
            // 
            this.contextCollapse.Image = ((System.Drawing.Image)(resources.GetObject("contextCollapse.Image")));
            this.contextCollapse.Name = "contextCollapse";
            this.contextCollapse.Size = new System.Drawing.Size(210, 30);
            this.contextCollapse.Text = "Collapse All";
            this.contextCollapse.Click += new System.EventHandler(this.contextCollapse_Click);
            // 
            // contextCollapseHeading2
            // 
            this.contextCollapseHeading2.Image = ((System.Drawing.Image)(resources.GetObject("contextCollapseHeading2.Image")));
            this.contextCollapseHeading2.Name = "contextCollapseHeading2";
            this.contextCollapseHeading2.Size = new System.Drawing.Size(210, 30);
            this.contextCollapseHeading2.Text = "2nd Heading Level";
            this.contextCollapseHeading2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.contextCollapseHeading2.Click += new System.EventHandler(this.contextCollapseHeading2_Click);
            // 
            // contextCollapseHeading3
            // 
            this.contextCollapseHeading3.Image = ((System.Drawing.Image)(resources.GetObject("contextCollapseHeading3.Image")));
            this.contextCollapseHeading3.Name = "contextCollapseHeading3";
            this.contextCollapseHeading3.Size = new System.Drawing.Size(210, 30);
            this.contextCollapseHeading3.Text = "3rd Heading Level";
            this.contextCollapseHeading3.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.contextCollapseHeading3.Click += new System.EventHandler(this.contextCollapseHeading3_Click);
            // 
            // contextExpand
            // 
            this.contextExpand.Image = ((System.Drawing.Image)(resources.GetObject("contextExpand.Image")));
            this.contextExpand.Name = "contextExpand";
            this.contextExpand.Size = new System.Drawing.Size(210, 30);
            this.contextExpand.Text = "Expand All";
            this.contextExpand.Click += new System.EventHandler(this.contextExpand_Click);
            // 
            // bSettings
            // 
            this.bSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSettings.Image = ((System.Drawing.Image)(resources.GetObject("bSettings.Image")));
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(210, 30);
            this.bSettings.Text = "Settings";
            // 
            // Menubar
            // 
            this.Menubar.BackColor = System.Drawing.Color.White;
            this.Menubar.Dock = System.Windows.Forms.DockStyle.None;
            this.Menubar.GripMargin = new System.Windows.Forms.Padding(0);
            this.Menubar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Menubar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bCollapse,
            this.bCollapseHeading2,
            this.bCollapseHeading3,
            this.bExpand,
            this.bRefreshMenubar,
            this.bSearch});
            this.Menubar.Location = new System.Drawing.Point(4, 0);
            this.Menubar.Name = "Menubar";
            this.Menubar.Padding = new System.Windows.Forms.Padding(0);
            this.Menubar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menubar.Size = new System.Drawing.Size(279, 31);
            this.Menubar.TabIndex = 1;
            this.Menubar.Text = "toolStrip2";
            // 
            // bCollapse
            // 
            this.bCollapse.BackColor = System.Drawing.Color.White;
            this.bCollapse.Image = ((System.Drawing.Image)(resources.GetObject("bCollapse.Image")));
            this.bCollapse.Name = "bCollapse";
            this.bCollapse.Size = new System.Drawing.Size(38, 31);
            this.bCollapse.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // bCollapseHeading2
            // 
            this.bCollapseHeading2.BackColor = System.Drawing.Color.White;
            this.bCollapseHeading2.Image = ((System.Drawing.Image)(resources.GetObject("bCollapseHeading2.Image")));
            this.bCollapseHeading2.Name = "bCollapseHeading2";
            this.bCollapseHeading2.Size = new System.Drawing.Size(38, 31);
            // 
            // bCollapseHeading3
            // 
            this.bCollapseHeading3.BackColor = System.Drawing.Color.White;
            this.bCollapseHeading3.Image = ((System.Drawing.Image)(resources.GetObject("bCollapseHeading3.Image")));
            this.bCollapseHeading3.Name = "bCollapseHeading3";
            this.bCollapseHeading3.Size = new System.Drawing.Size(38, 31);
            // 
            // bExpand
            // 
            this.bExpand.BackColor = System.Drawing.Color.White;
            this.bExpand.Image = ((System.Drawing.Image)(resources.GetObject("bExpand.Image")));
            this.bExpand.Name = "bExpand";
            this.bExpand.Size = new System.Drawing.Size(38, 31);
            this.bExpand.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // bRefreshMenubar
            // 
            this.bRefreshMenubar.BackColor = System.Drawing.Color.White;
            this.bRefreshMenubar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bRefreshMenubar.Image = ((System.Drawing.Image)(resources.GetObject("bRefreshMenubar.Image")));
            this.bRefreshMenubar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bRefreshMenubar.Name = "bRefreshMenubar";
            this.bRefreshMenubar.Size = new System.Drawing.Size(43, 28);
            this.bRefreshMenubar.Text = "Refresh Navigation Pane";
            this.bRefreshMenubar.ButtonClick += new System.EventHandler(this.bRefresh_Click);
            // 
            // bSearch
            // 
            this.bSearch.AcceptsReturn = true;
            this.bSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bSearch.MaxLength = 20;
            this.bSearch.Name = "bSearch";
            this.bSearch.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.bSearch.Size = new System.Drawing.Size(80, 31);
            this.bSearch.ToolTipText = "Search current file or Debate Files document titles";
            this.bSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bSearch_KeyDown);
            this.bSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bSearch_KeyUp);
            // 
            // dropdownWindows
            // 
            this.dropdownWindows.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.dropdownWindows.Name = "dropdownWindows";
            this.dropdownWindows.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.dropdownWindows.ShowImageMargin = false;
            this.dropdownWindows.ShowItemToolTips = false;
            this.dropdownWindows.Size = new System.Drawing.Size(36, 4);
            this.dropdownWindows.Opening += new System.ComponentModel.CancelEventHandler(this.dropdownWindows_Opening);
            this.dropdownWindows.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.dropdownWindows_ItemClicked);
            // 
            // Sidebar
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.CausesValidation = false;
            this.Controls.Add(this.toolStripContainer4);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Sidebar";
            this.Size = new System.Drawing.Size(360, 400);
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
        private System.Windows.Forms.ToolStripTextBox bSearch;
        private System.Windows.Forms.TreeView treeFiles;
        private System.Windows.Forms.ToolStripMenuItem contextCollapse;
        private System.Windows.Forms.ToolStripMenuItem contextExpand;
        private System.Windows.Forms.ToolStripMenuItem contextRefresh;
        public System.Windows.Forms.ToolStripSplitButton bRefreshMenubar;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip dropdownWindows;
        private System.Windows.Forms.ToolStripMenuItem bSettings;
        public System.Windows.Forms.ToolStripMenuItem bCollapse;
        public System.Windows.Forms.ToolStripMenuItem bExpand;
        public System.Windows.Forms.ToolStripMenuItem bCollapseHeading2;
        public System.Windows.Forms.ToolStripMenuItem bCollapseHeading3;
    }
}
