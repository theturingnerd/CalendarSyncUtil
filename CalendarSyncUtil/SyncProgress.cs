using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarSyncUtil
{
    public partial class SyncProgress : Form
    {
        private List<Datamodel.SyncPair> syncPairs = new List<Datamodel.SyncPair>();
        SyncOperations SyncOperations = new SyncOperations();
        public SyncProgress()
        {
            InitializeComponent();
        }

        private void LoadSettings()
        {
            var loadedPairs = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Datamodel.SyncPair>>(Properties.Settings.Default.SyncPairs);
            if (loadedPairs != null)
            {
                syncPairs = loadedPairs;
            }
        }

        private void RunSync()
        {
            foreach(Datamodel.SyncPair pair in syncPairs)
            {
                var sourceCalendar = ThisAddIn.GetApplication().Session.GetFolderFromID(pair.Source_MAPIObject_EntryId);
                var targetCalendar = ThisAddIn.GetApplication().Session.GetFolderFromID(pair.Target_MAPIObject_EntryId);
                LogItem($"Starting Sync of {pair.Source_FriendlyPathName} TO {pair.Target_FriendlyPathName}");
                int totalSync = SyncOperations.RunCalendarSync(sourceCalendar, targetCalendar, pair.Source_FriendlyPathName, pair.isMaskedTarget);
                LogItem($"Synchronized {totalSync} items. Finished.");
            }
        }

        /// <summary>
        /// Called after our sync operation
        /// </summary>
        private void SaveSettings()
        {
            Properties.Settings.Default.SyncPairs = Newtonsoft.Json.JsonConvert.SerializeObject(syncPairs);
        }


        private void SyncProgress_Load(object sender, EventArgs e)
        {
            LoadSettings();
            RunSync();
        }

        private void LogItem(string logString)
        {
            syncLogBox.Items.Add($"{DateTime.Now} - {logString}");

        }
    }
}
