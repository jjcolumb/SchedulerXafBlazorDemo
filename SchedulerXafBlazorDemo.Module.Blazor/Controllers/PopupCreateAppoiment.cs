using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Blazor;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using SchedulerXafBlazorDemo.Module.Blazor.Editors;
using SchedulerXafBlazorDemo.Module.BusinessObjects;

namespace SchedulerXafBlazorDemo.Module.Blazor.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class PopupCreateAppoiment : ViewController
    {
        private PopupWindowShowAction popupCreateAppoiment;
        public PopupCreateAppoiment()
        {
            InitializeComponent();
            TargetViewId = "DashboardTest";
            popupCreateAppoiment = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this, "popupCreateAppoiment", PredefinedCategory.View);
            popupCreateAppoiment.Caption = "Create Appointment";
            popupCreateAppoiment.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.popupRemove_CustomizePopupWindowParams);
            popupCreateAppoiment.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.popupRemove_Execute);
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void popupRemove_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(Appointment));
            DetailView detailView = Application.CreateDetailView(objectSpace, objectSpace.CreateObject<Appointment>());

            detailView.ViewEditMode = ViewEditMode.Edit;
            e.View = detailView;
        }

        private void popupRemove_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {
            ((BlazorApplication)Application).ServiceProvider.GetRequiredService<IJSRuntime>().InvokeVoidAsync("RefreshIframe");
        }
    }
}
