using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace SchedulerXafBlazorDemo.Module.BusinessObjects
{
    [DefaultClassOptions]    
    public class Appointment : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Appointment(Session session)
            : base(session)
        {
        }


      
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        Guid id;
        string recurrence;
        bool allDay;
        int status;
        int label;
        string location;
        string description;
        string caption;
        DateTime endDate;
        DateTime startDate;
        int appointmentType;

        public int AppointmentType
        {
            get => appointmentType;
            set => SetPropertyValue(nameof(AppointmentType), ref appointmentType, value);
        }
        [ModelDefault("DisplayFormat", "{0:MMM/d/yyyy hh:mm}")]
        [ModelDefault("EditMask", "MMM/d/yyyy hh:mm")]
        [ModelDefault("EditMaskType", "DateTime")]
        public DateTime StartDate
        {
            get => startDate;
            set => SetPropertyValue(nameof(StartDate), ref startDate, value);
        }
        [ModelDefault("DisplayFormat", "{0:MMM/d/yyyy hh:mm}")]
        [ModelDefault("EditMask", "MMM/d/yyyy hh:mm")]
        [ModelDefault("EditMaskType", "DateTime")]
        public DateTime EndDate
        {
            get => endDate;
            set => SetPropertyValue(nameof(EndDate), ref endDate, value);
        }
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Caption
        {
            get => caption;
            set => SetPropertyValue(nameof(Caption), ref caption, value);
        }
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Description
        {
            get => description;
            set => SetPropertyValue(nameof(Description), ref description, value);
        }
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Location
        {
            get => location;
            set => SetPropertyValue(nameof(Location), ref location, value);
        }
        public int Label
        {
            get => label;
            set => SetPropertyValue(nameof(Label), ref label, value);
        }
        public int Status
        {
            get => status;
            set => SetPropertyValue(nameof(Status), ref status, value);
        }
        public bool AllDay
        {
            get => allDay;
            set => SetPropertyValue(nameof(AllDay), ref allDay, value);
        }
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Recurrence
        {
            get => recurrence;
            set => SetPropertyValue(nameof(Recurrence), ref recurrence, value);
        }
        public Guid Id
        {
            get => id;
            set => SetPropertyValue(nameof(Id), ref id, value);
        }
    }
}