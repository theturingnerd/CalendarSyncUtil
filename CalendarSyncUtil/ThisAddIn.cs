using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Diagnostics;

namespace CalendarSyncUtil
{
    public partial class ThisAddIn
    {
        public static Outlook.Application _appRef;
        public static Outlook.Application GetApplication()
        {
            return _appRef;   
        }
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            Outlook.MAPIFolder ikbiCalendar = Application.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderCalendar); //ikbi calendar
            ThisAddIn._appRef = Application;


            //var fOlder = Application.Session.PickFolder();

            /* **** Manual Selection
            //wendys calendar 
            var wendysCalendar = Application.Session.GetFolderFromID("00000000BA41AA7D4F10F144AD7F5FCCD59230DC010031B2076591D0954394A6DFAD1C95CFD300000000010D0000");

            //multi-sync cal
            var calTargetFolder = Application.Session.GetFolderFromID("000000001062ED8428684641A9F5B1C2850F15A201004359A227171D3E4EBF72D43270DAF2210002444A5B130000");

            ****/

            //System.Windows.Forms.MessageBox.Show("pick the SOURCE calendar to sync FROM");
            //var sourceCalendar = Application.Session.PickFolder();

            //System.Windows.Forms.MessageBox.Show("pick the TARGET calendar to sync TO");
            //var targetCalendar = Application.Session.PickFolder();

            //RunCalendarSync(sourceCalendar, targetCalendar, "EXTERNAL");




            //RunCalendarSync(ikbiCalendar, calTargetFolder, "IK");
            //RunCalendarSync(wendysCalendar, calTargetFolder, "W");
            //RunCalendarSync(ikbiCalendar, wendysCalendar, "I");
            //CleanCalendar(calTargetFolder);
        }

     

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see https://go.microsoft.com/fwlink/?LinkId=506785
        }

  
       
     
       

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }


        
        #endregion
    }
}
