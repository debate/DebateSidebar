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
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextCollapseHeading3 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextExpand = new System.Windows.Forms.ToolStripMenuItem();
            this.bSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.Menubar = new System.Windows.Forms.ToolStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bExpand = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripContainer4.ContentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer4.ContentPanel.Size = new System.Drawing.Size(299, 371);
            this.toolStripContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer4.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer4.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer4.Name = "toolStripContainer4";
            this.toolStripContainer4.Size = new System.Drawing.Size(299, 399);
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
            this.treeFiles.Location = new System.Drawing.Point(0, 450);
            this.treeFiles.Margin = new System.Windows.Forms.Padding(0);
            this.treeFiles.Name = "treeFiles";
            this.treeFiles.Size = new System.Drawing.Size(278, 250);
            this.treeFiles.TabIndex = 3;
            this.treeFiles.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeFiles_NodeMouseDoubleClick);
            // 
            // contextFiles
            // 
            this.contextFiles.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderToolStripMenuItem});
            this.contextFiles.Name = "contextTreeFiles";
            this.contextFiles.Size = new System.Drawing.Size(169, 34);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openFolderToolStripMenuItem.Image")));
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(168, 30);
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.contextFilesFolder_Click);
            // 
            // treeDoc
            // 
            this.treeDoc.AllowDrop = true;
            this.treeDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeDoc.ContextMenuStrip = this.contextHeadings;
            this.treeDoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeDoc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.treeDoc.FullRowSelect = true;
            this.treeDoc.Indent = 10;
            this.treeDoc.ItemHeight = 22;
            this.treeDoc.Location = new System.Drawing.Point(0, 0);
            this.treeDoc.Margin = new System.Windows.Forms.Padding(0);
            this.treeDoc.Name = "treeDoc";
            this.treeDoc.ShowLines = false;
            this.treeDoc.Size = new System.Drawing.Size(278, 450);
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
            this.toolStripMenuItem2,
            this.contextCollapseHeading3,
            this.contextExpand,
            this.bSettings});
            this.contextHeadings.Name = "treeDocContentMenu";
            this.contextHeadings.Size = new System.Drawing.Size(186, 154);
            // 
            // contextRefresh
            // 
            this.contextRefresh.Image = ((System.Drawing.Image)(resources.GetObject("contextRefresh.Image")));
            this.contextRefresh.Name = "contextRefresh";
            this.contextRefresh.Size = new System.Drawing.Size(185, 30);
            this.contextRefresh.Text = "Refresh";
            this.contextRefresh.Click += new System.EventHandler(this.contextRefresh_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8fclear;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(185, 30);
            this.toolStripMenuItem2.Text = "Remove";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.contextRemove_Click);
            // 
            // contextCollapseHeading3
            // 
            this.contextCollapseHeading3.Image = ((System.Drawing.Image)(resources.GetObject("contextCollapseHeading3.Image")));
            this.contextCollapseHeading3.Name = "contextCollapseHeading3";
            this.contextCollapseHeading3.Size = new System.Drawing.Size(185, 30);
            this.contextCollapseHeading3.Text = "Expand Level 3";
            this.contextCollapseHeading3.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.contextCollapseHeading3.Click += new System.EventHandler(this.contextCollapseHeading3_Click);
            // 
            // contextExpand
            // 
            this.contextExpand.Image = ((System.Drawing.Image)(resources.GetObject("contextExpand.Image")));
            this.contextExpand.Name = "contextExpand";
            this.contextExpand.Size = new System.Drawing.Size(185, 30);
            this.contextExpand.Text = "Expand Level 4";
            this.contextExpand.Click += new System.EventHandler(this.contextExpand_Click);
            // 
            // bSettings
            // 
            this.bSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSettings.Image = ((System.Drawing.Image)(resources.GetObject("bSettings.Image")));
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(185, 30);
            this.bSettings.Text = "Settings";
            this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
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
            this.bExpand,
            this.bSearch});
            this.Menubar.Location = new System.Drawing.Point(4, 0);
            this.Menubar.Name = "Menubar";
            this.Menubar.Padding = new System.Windows.Forms.Padding(0);
            this.Menubar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menubar.Size = new System.Drawing.Size(230, 28);
            this.Menubar.TabIndex = 1;
            this.Menubar.Text = "toolStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(38, 31);
            this.toolStripMenuItem1.ToolTipText = "Refresh after each edit ";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // bExpand
            // 
            this.bExpand.BackColor = System.Drawing.Color.White;
            this.bExpand.Image = global::DebateSidebarWordAddIn.Properties.Resources.ff;
            this.bExpand.Name = "bExpand";
            this.bExpand.Size = new System.Drawing.Size(38, 31);
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
            this.bSearch.Size = new System.Drawing.Size(150, 31);
            this.bSearch.ToolTipText = "Seaches first folders and files then document text";
            this.bSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bSearch_KeyDown);
            this.bSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bSearch_KeyUp);
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
            this.Size = new System.Drawing.Size(299, 399);
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
        public System.Windows.Forms.ToolStripMenuItem contextCollapseHeading3;
        public System.Windows.Forms.TreeView treeDoc;
        private System.Windows.Forms.ToolStripMenuItem bSettings;
        public System.Windows.Forms.ToolStripMenuItem bExpand;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}
