using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalendarSyncUtil
{
    public partial class HomeSync
    {
        private void HomeSync_Load(object sender, RibbonUIEventArgs e)
        {
           
            
        }

        private void btnSyncSettings_Click(object sender, RibbonControlEventArgs e)
        {

            SyncSettings syncSettings = new SyncSettings();
            syncSettings.ShowDialog();
        }

        private void btnLaunchSync_Click(object sender, RibbonControlEventArgs e)
        {
            SyncProgress syncProgress = new SyncProgress();
            syncProgress.Show();
        }
    }
}
