using System;
using System.Collections.Generic;
using System.Text;

namespace SchedulerXafBlazorDemo.Module.BusinessObjects
{
    public class AppointmentPOCO
    {
        public AppointmentPOCO() { }

        public Guid OidPoco { get; set; }
        public int AppointmentType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int Label { get; set; }
        public int Status { get; set; }
        public bool AllDay { get; set; }
        public string Recurrence { get; set; }
    }

    public static partial class DateTimeUtils
    {
        public static DateTime CreateWeekStart()
        {
            System.Globalization.DateTimeFormatInfo dInfo = new System.Globalization.DateTimeFormatInfo();
            dInfo.ShortDatePattern = "dd/MM/yyyy";
            DateTime dtMin = DateTime.Today;
            DateTime dtMax = DateTime.Today.AddDays(6);
            TimeSpan tsMax = dtMax - dtMin;
            Random rn = new Random();
            int rnDays = rn.Next(1, tsMax.Days);
            DateTime dtRan = dtMin.AddDays(rnDays);
            return dtRan;
        }

    }
}
