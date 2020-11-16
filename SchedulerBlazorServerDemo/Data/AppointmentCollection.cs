﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulerBlazorServerDemo.Data
{
    public static partial class AppointmentCollection
    {
        public static List<Appointment> GetAppointments()
        {
            DateTime date = DateTimeUtils.CreateWeekStart();
            var dataSource = new List<Appointment>() {
            new Appointment {
                Caption = "Install New Router in Dev Room",
                StartDate = date + (new TimeSpan(0, 10, 0, 0)),
                EndDate = date + (new TimeSpan(0, 12, 0, 0)),
                Label = 6,
                Status = 1
            },
            new Appointment {
                Caption = "Upgrade Personal Computers",
                StartDate = date + (new TimeSpan(0,  13, 0, 0)),
                EndDate = date + (new TimeSpan(0, 14, 30, 0)),
                Label = 1,
                Status = 1
            },
            new Appointment {
                Caption = "Website Re-Design Plan",
                StartDate = date + (new TimeSpan(1, 9, 30, 0)),
                EndDate = date + (new TimeSpan(1, 11, 30, 0)),
                Label = 1,
                Status = 1
            },
            new Appointment {
                Caption = "New Brochures",
                StartDate = date + (new TimeSpan(1, 13, 30, 0)),
                EndDate = date + (new TimeSpan(1, 15, 15, 0)),
                Label = 8,
                Status = 1
            },
            new Appointment {
                Caption = "Book Flights to San Fran for Sales Trip",
                StartDate = date + (new TimeSpan(1, 12, 0, 0)),
                EndDate = date + (new TimeSpan(1, 13, 0, 0)),
                AllDay = true,
                Label = 8,
                Status = 1
            },
            new Appointment {
                Caption = "Approve Personal Computer Upgrade Plan",
                StartDate = date + (new TimeSpan(2, 10, 0, 0)),
                EndDate = date + (new TimeSpan(2, 12, 0, 0)),
                Label = 8,
                Status = 1
            },
            new Appointment {
                Caption = "Final Budget Review",
                StartDate = date + (new TimeSpan(2, 13, 0, 0)),
                EndDate = date + (new TimeSpan(2, 15, 0, 0)),
                Label = 1,
                Status = 1
            },
            new Appointment {
                Caption = "Install New Database",
                StartDate = date + (new TimeSpan(3, 9, 45, 0)),
                EndDate = date + (new TimeSpan(3, 11, 15, 0)),
                Label = 6,
                Status = 1
            },
            new Appointment {
                Caption = "Approve New Online Marketing Strategy",
                StartDate = date + (new TimeSpan(3,  12, 0, 0)),
                EndDate = date + (new TimeSpan(3, 14, 0, 0)),
                Label = 1,
                Status = 1
            },
            new Appointment {
                Caption = "Customer Workshop",
                StartDate = date + (new TimeSpan(4,  11, 0, 0)),
                EndDate = date + (new TimeSpan(4, 12, 0, 0)),
                AllDay = true,
                Label = 8,
                Status = 1
            },
            new Appointment {
                Caption = "Prepare 2019 Marketing Plan",
                StartDate = date + (new TimeSpan(4,  11, 0, 0)),
                EndDate = date + (new TimeSpan(4, 13, 30, 0)),
                Label = 1,
                Status = 1
            },
            new Appointment {
                Caption = "Brochure Design Review",
                StartDate = date + (new TimeSpan(4, 14, 0, 0)),
                EndDate = date + (new TimeSpan(4, 15, 30, 0)),
                Label = 1,
                Status = 1
            },
            new Appointment {
                Caption = "Create Icons for Website",
                StartDate = date + (new TimeSpan(5, 10, 0, 0)),
                EndDate = date + (new TimeSpan(5, 11, 30, 0)),
                Label = 1,
                Status = 1
            },
            new Appointment {
                Caption = "Launch New Website",
                StartDate = date + (new TimeSpan(5, 12, 20, 0)),
                EndDate = date + (new TimeSpan(5, 14, 0, 0)),
                Label = 8,
                Status = 1
            },
            new Appointment {
                Caption = "Upgrade Server Hardware",
                StartDate = date + (new TimeSpan(6, 11, 0, 0)),
                EndDate = date + (new TimeSpan(6, 13, 30, 0)),
                Label = 8,
                Status = 1
            }
        };
            return dataSource;
        }
    }

    public class Appointment
    {
        public Appointment() { }

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
