using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Diagnostics;

namespace CalendarSyncUtil
{
    public partial class SyncSettings : Form
    {
        public SyncSettings()
        {
            InitializeComponent();
        }

        private List<Datamodel.SyncPair> syncPairs = new List<Datamodel.SyncPair>();
        SyncOperations syncOperations = new SyncOperations();

        private void pickSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var folderPicked = ThisAddIn.GetApplication().Session.PickFolder();
            if (folderPicked != null)
            {
                sourceId.Text = folderPicked.FullFolderPath;
                sourceId.Tag = folderPicked.EntryID;
            }
        }

        private void pickTarget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var folderPicked = ThisAddIn.GetApplication().Session.PickFolder();
            if (folderPicked != null)
            {
                targetId.Text = folderPicked.FullFolderPath;
                targetId.Tag = folderPicked.EntryID;
            }
        }

        private void addPair_Click(object sender, EventArgs e)
        {
            var pair = new Datamodel.SyncPair(sourceId.Tag.ToString(), sourceId.Text, targetId.Tag.ToString(), targetId.Text, isMaskedTargetCheckBox.Checked);
            pairList.Items.Add(pair);
            syncPairs.Add(pair);
            sourceId.Tag = null;
            sourceId.Text = string.Empty;
            targetId.Tag = null;
            targetId.Text= string.Empty;
        }

        private void RemovePair_Click(object sender, EventArgs e)
        {
            if (pairList.Items.Count == 0 || pairList.SelectedItems.Count == 0)
                return;
            else
            {
                int idx = syncPairs.FindIndex(p => p.ToString() == pairList.SelectedItem.ToString());
                syncPairs.RemoveAt(idx);
                pairList.Items.Remove(pairList.SelectedItem);


            }
        }

        private void LoadSettings()
        {
            var loadedPairs = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Datamodel.SyncPair>>(Properties.Settings.Default.SyncPairs);
            if(loadedPairs != null)
            {
                syncPairs = loadedPairs;
            }
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.SyncPairs = Newtonsoft.Json.JsonConvert.SerializeObject(syncPairs);
            Properties.Settings.Default.Save();
        }

        private void SyncSettings_Load(object sender, EventArgs e)
        {
            LoadSettings();
            if (syncPairs != null)
            {
                foreach (var pair in syncPairs)
                {
                    pairList.Items.Add(pair);
                }
            }
        }

        private void SyncSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void cleanCalButton_Click(object sender, EventArgs e)
        {
            var folderPicked = ThisAddIn.GetApplication().Session.PickFolder();
            syncOperations.CleanCalendar(folderPicked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var folderPicked = ThisAddIn.GetApplication().Session.PickFolder();

            syncOperations.CleanCalendarPrefixEntries(folderPicked);
        }
    }
}
