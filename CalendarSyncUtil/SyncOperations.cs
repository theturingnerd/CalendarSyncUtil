using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Diagnostics;

namespace CalendarSyncUtil
{
    public class SyncOperations
    {
        public void CleanCalendar(Outlook.MAPIFolder calendar)
        {
            if (System.Windows.Forms.MessageBox.Show("DANGER! This will delete all calendar entries for the next 30 days!\nAre you sure you want to do this?\nLike really really sure?", "Warning", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                var outlookCalendarItems = GetAppointmentsInRange(calendar, DateTime.Now.Date.AddDays(-1), DateTime.Now.Date.AddDays(15));

                foreach (Microsoft.Office.Interop.Outlook.AppointmentItem item in calendar.Items)
                {
                    if (item.IsRecurring)
                    {
                        item.ClearRecurrencePattern();
                        item.Save();
                    }

                    item.Delete();
                }

                System.Windows.Forms.MessageBox.Show("Delete done!");
            }
            else
            {
                return;
            }

        }

        public void CleanCalendarPrefixEntries(Outlook.MAPIFolder calendar)
        {
            if (System.Windows.Forms.MessageBox.Show("DANGER! This will delete all calendar entries for the next 30 days!\nAre you sure you want to do this?\nLike really really sure?", "Warning", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                var outlookCalendarItems = GetAppointmentsInRange(calendar, DateTime.Now.Date.AddDays(-1), DateTime.Now.Date.AddDays(15));

                foreach (Microsoft.Office.Interop.Outlook.AppointmentItem item in calendar.Items)
                {
                    if (item.Subject.StartsWith("["))
                    {
                        if (item.IsRecurring)
                        {
                            item.ClearRecurrencePattern();
                            item.Save();
                        }

                        item.Delete();
                    }
                }
            }

            System.Windows.Forms.MessageBox.Show("Delete done!");
        }
            public int RunCalendarSync(Outlook.MAPIFolder calendar, Outlook.MAPIFolder calTargetFolder, string prefix, bool isMaskedTarget)
        {
            int totalItemsCreated = 0;

            var outlookCalendarItems = GetAppointmentsInRange(calendar, DateTime.Now.Date, DateTime.Now.Date.AddDays(5));
            foreach (Microsoft.Office.Interop.Outlook.AppointmentItem item in outlookCalendarItems)
            {
                if (item.IsRecurring)
                {
                    if (!IsDuplicate(calendar, calTargetFolder, item))
                    {
                        SaveCalendarEntry(calTargetFolder, item, prefix, isMaskedTarget);
                        totalItemsCreated += 1;
                    }
                    else
                    {
                        Console.Write("debug - duplicate item not saving");
                    }

                }
                else
                {
                    Console.WriteLine(item.Subject + " -> " + item.Start.ToLongDateString());
                    if (!IsDuplicate(calendar, calTargetFolder, item))
                    {
                        SaveCalendarEntry(calTargetFolder, item, prefix, isMaskedTarget);
                        totalItemsCreated += 1;
                    }
                    else
                    {
                        Console.Write("debug - duplicate item not saving");
                    }
                }
            }

            return totalItemsCreated;
        }


        /// <summary>
        /// Get recurring appointments in date range.
        /// </summary>
        /// <param name="folder"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns>Outlook.Items</returns>
        private Outlook.Items GetAppointmentsInRange(Outlook.MAPIFolder folder,
            DateTime startTime,
            DateTime endTime)
        {
            string filter = "[Start] >= '"
                + startTime.ToString("g")
                + "' AND [End] <= '"
                + endTime.ToString("g") + "'";
            Debug.WriteLine(filter);
            try
            {
                Microsoft.Office.Interop.Outlook.Items calItems = folder.Items;
                calItems.IncludeRecurrences = true;
                calItems.Sort("[Start]", Type.Missing);
                Outlook.Items restrictItems = calItems.Restrict(filter);
                if (restrictItems.Count > 0)
                {
                    return restrictItems;
                }
                else
                {
                    return null;
                }
            }
            catch { return null; }
        }

        public bool IsDuplicate(Outlook.MAPIFolder sourceFolder, Outlook.MAPIFolder targetFolder, Outlook.AppointmentItem appointmentItem)
        {
            bool isDuplicate = false;

            Outlook.Items targetedItems = GetAppointmentsInRange(targetFolder, appointmentItem.Start, appointmentItem.End);
            foreach (Outlook.AppointmentItem appointment in targetedItems)
            {
                if (appointment.Subject != "BLOCK")
                {
                    if (appointment.Subject == $"{appointmentItem.Subject}")
                        isDuplicate = true;
                }
                else
                {
                    if(appointment.StartUTC == appointmentItem.StartUTC && appointment.EndUTC == appointmentItem.EndUTC)
                    {
                        isDuplicate = true;
                    }
                }
            }

            return isDuplicate;
        }
        public void SaveCalendarEntry(Outlook.MAPIFolder folder, Outlook.AppointmentItem source, string prefix, bool isMasked)
        {
            Outlook.AppointmentItem appItem = folder.Items.Add(Outlook.OlItemType.olAppointmentItem) as Outlook.AppointmentItem;
            appItem.StartUTC = source.StartUTC;
            appItem.EndUTC = source.EndUTC;

            if (source.IsRecurring)
            {
                Outlook.RecurrencePattern sp = source.GetRecurrencePattern();
                Outlook.RecurrencePattern rp = appItem.GetRecurrencePattern();

                rp = sp;
            }

            appItem.Subject = $"{source.Subject}";
            appItem.Duration = source.Duration;
            appItem.Location = source.Location;

            appItem.Body = $"SOURCE: {prefix} \n { source.Body}";

            if(isMasked)
            {
                appItem.Body = String.Empty;
                appItem.Subject = "BLOCK";
                appItem.Sensitivity = Outlook.OlSensitivity.olPrivate;
                appItem.Location = String.Empty;
            }
            
            appItem.AllDayEvent = source.AllDayEvent;
            appItem.ReminderMinutesBeforeStart = 1;
            appItem.Importance = source.Importance;
            appItem.Save();
            //appItem.Display(true);
        }

    }
}
