namespace DebateSynergyWordAddIn
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
            this.tab2 = this.Factory.CreateRibbonTab();
            this.groupDebate = this.Factory.CreateRibbonGroup();
            this.bDebatePanelSwitch = this.Factory.CreateRibbonButton();
            this.tab2.SuspendLayout();
            this.groupDebate.SuspendLayout();
            // 
            // tab2
            // 
            this.tab2.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab2.ControlId.OfficeId = "TabHome";
            this.tab2.Groups.Add(this.groupDebate);
            this.tab2.Label = "TabHome";
            this.tab2.Name = "tab2";
            // 
            // groupDebate
            // 
            this.groupDebate.DialogLauncher = ribbonDialogLauncherImpl1;
            this.groupDebate.Items.Add(this.bDebatePanelSwitch);
            this.groupDebate.Label = "Debate";
            this.groupDebate.Name = "groupDebate";
            this.groupDebate.Position = this.Factory.RibbonPosition.BeforeOfficeId("GroupClipboard");
            this.groupDebate.DialogLauncherClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.groupDebate_DialogLauncherClick_1);
            // 
            // bDebatePanelSwitch
            // 
            this.bDebatePanelSwitch.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.bDebatePanelSwitch.Image = global::DebateSynergyWordAddIn.Properties.Resources.d8logo;
            this.bDebatePanelSwitch.Label = "Debate";
            this.bDebatePanelSwitch.Name = "bDebatePanelSwitch";
            this.bDebatePanelSwitch.ShowImage = true;
            this.bDebatePanelSwitch.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bDebatePanelSwitch_Click);
            // 
            // DebateRibbonButton
            // 
            this.Name = "DebateRibbonButton";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab2);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.DebateRibbonButton_Load);
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.groupDebate.ResumeLayout(false);
            this.groupDebate.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab2;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupDebate;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton bDebatePanelSwitch;

    }

    partial class ThisRibbonCollection
    {
        internal DebateRibbonButton DebateRibbonButton
        {
            get { return this.GetRibbon<DebateRibbonButton>(); }
        }
    }
}
