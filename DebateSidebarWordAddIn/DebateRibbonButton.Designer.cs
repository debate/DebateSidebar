namespace DebateSidebarWordAddIn
{
    partial class DebateRibbonButton : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public DebateRibbonButton()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl1 = this.Factory.CreateRibbonDialogLauncher();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.groupDebate = this.Factory.CreateRibbonGroup();
            this.bDebatePanelSwitch = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.groupDebate.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.ControlId.OfficeId = "TabHome";
            this.tab1.Groups.Add(this.groupDebate);
            this.tab1.Label = "TabHome";
            this.tab1.Name = "tab1";
            // 
            // groupDebate
            // 
            this.groupDebate.DialogLauncher = ribbonDialogLauncherImpl1;
            this.groupDebate.Items.Add(this.bDebatePanelSwitch);
            this.groupDebate.Label = "Debate";
            this.groupDebate.Name = "groupDebate";
            this.groupDebate.Position = this.Factory.RibbonPosition.BeforeOfficeId("GroupClipboard");
            this.groupDebate.DialogLauncherClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.groupDebate_DialogLauncherClick);
            // 
            // bDebatePanelSwitch
            // 
            this.bDebatePanelSwitch.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.bDebatePanelSwitch.Image = global::DebateSidebarWordAddIn.Properties.Resources.d8logo;
            this.bDebatePanelSwitch.Label = "Debate";
            this.bDebatePanelSwitch.Name = "bDebatePanelSwitch";
            this.bDebatePanelSwitch.ShowImage = true;
            this.bDebatePanelSwitch.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bDebatePanelSwitch_Click);
            // 
            // RibbonButton
            // 
            this.Name = "RibbonButton";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.groupDebate.ResumeLayout(false);
            this.groupDebate.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupDebate;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton bDebatePanelSwitch;
    }

    partial class ThisRibbonCollection
    {
        internal DebateRibbonButton RibbonButton
        {
            get { return this.GetRibbon<DebateRibbonButton>(); }
        }
    }
}
