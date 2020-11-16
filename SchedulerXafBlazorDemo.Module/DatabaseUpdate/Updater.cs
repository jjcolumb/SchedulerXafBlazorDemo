using System;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;
using SchedulerXafBlazorDemo.Module.BusinessObjects;
using Bogus;

namespace SchedulerXafBlazorDemo.Module.DatabaseUpdate {
    // For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
            base(objectSpace, currentDBVersion) {
        }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();

            //if (ObjectSpace.GetObjectsCount(typeof(Appoiment), null) == 0)
            //{
            //    var events = new Faker<Appoiment>()
            //        .CustomInstantiator(f => new Appoiment(((XPObjectSpace)ObjectSpace).Session))
            //        .RuleFor(o => o.Caption, f => f.Name.FullName())
            //        .RuleFor(o => o.Location, f => f.Address.FullAddress())
            //        .RuleFor(o => o.AllDay, f => f.Random.Bool())
            //        .RuleFor(o => o.StartDate, f => f.Date.Recent(1))
            //        .RuleFor(o => o.Label, f => f.Random.Int(1, 9))
            //        .RuleFor(o => o.Status, f => f.Random.Int(1, 9))
            //        .RuleFor(o => o.EndDate, f => f.Date.Recent(1));
            //    var users = events.Generate(5);



            //    ObjectSpace.CommitChanges();
            //}
        }
        public override void UpdateDatabaseBeforeUpdateSchema() {
            base.UpdateDatabaseBeforeUpdateSchema();
            //if(CurrentDBVersion < new Version("1.1.0.0") && CurrentDBVersion > new Version("0.0.0.0")) {
            //    RenameColumn("DomainObject1Table", "OldColumnName", "NewColumnName");
            //}
        }
    }
}
