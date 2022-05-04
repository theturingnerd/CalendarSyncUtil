using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarSyncUtil.Datamodel
{
    public class SyncPair
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime LastUpdate { get; set; }
        public DateTime LastSync { get; set; }
        public string Target_MAPIObject_EntryId { get; set; }
        public string Source_MAPIObject_EntryId { get; set; }

        public string Target_FriendlyPathName { get; set; }
        public string Source_FriendlyPathName { get; set; }

        public bool isMaskedTarget { get; set; }


        public List<string> Errors { get; set; }

        public SyncPair(string sourceMAPIEntryId, string sourcePathName, string targetMAPIEntryId, string targetPathName, bool maskTarget)
        {
            Source_MAPIObject_EntryId= sourceMAPIEntryId;
            Source_FriendlyPathName= sourcePathName;
            Target_MAPIObject_EntryId= targetMAPIEntryId;
            Target_FriendlyPathName= targetPathName;

            Errors = new List<string>();
            LastUpdate = DateTime.Now;
            LastSync = DateTime.MinValue;

            isMaskedTarget = maskTarget;
        }

        /// <summary>
        /// for JSON Serialization
        /// </summary>
        public SyncPair()
        {
            Errors = new List<string>();
        }

        public override string ToString()
        {
            return $"{Source_FriendlyPathName} => {Target_FriendlyPathName} Masked?={isMaskedTarget}";
        }

    }
}
