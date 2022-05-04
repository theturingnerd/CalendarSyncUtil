namespace CalendarSyncUtil
{
    partial class HomeSync : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public HomeSync()
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
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnLaunchSync = this.Factory.CreateRibbonButton();
            this.btnSyncSettings = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.ControlId.OfficeId = "TabMail";
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabMail";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnLaunchSync);
            this.group1.Items.Add(this.btnSyncSettings);
            this.group1.Label = "SyncTool";
            this.group1.Name = "group1";
            // 
            // btnLaunchSync
            // 
            this.btnLaunchSync.Image = global::CalendarSyncUtil.Properties.Resources.Arrows_Sync_icon;
            this.btnLaunchSync.Label = "Sync Calendars";
            this.btnLaunchSync.Name = "btnLaunchSync";
            this.btnLaunchSync.ShowImage = true;
            this.btnLaunchSync.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnLaunchSync_Click);
            // 
            // btnSyncSettings
            // 
            this.btnSyncSettings.Image = global::CalendarSyncUtil.Properties.Resources.settings_icon;
            this.btnSyncSettings.Label = "Sync Settings";
            this.btnSyncSettings.Name = "btnSyncSettings";
            this.btnSyncSettings.ShowImage = true;
            this.btnSyncSettings.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSyncSettings_Click);
            // 
            // HomeSync
            // 
            this.Name = "HomeSync";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.HomeSync_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnLaunchSync;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSyncSettings;
    }

    partial class ThisRibbonCollection
    {
        internal HomeSync HomeSync
        {
            get { return this.GetRibbon<HomeSync>(); }
        }
    }
}
