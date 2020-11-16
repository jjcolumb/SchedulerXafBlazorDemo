using DevExpress.ExpressApp.Blazor;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchedulerXafBlazorDemo.Module.Blazor.Editors
{
    public interface IModelComponentViewItem : IModelViewItem { }
    [ViewItem(typeof(IModelComponentViewItem))]
    public class IComponentView : ViewItem
    {
        class ComponentContentHolder : IComponentContentHolder
        {
            private readonly RenderFragment componentContent;
            public ComponentContentHolder(RenderFragment componentContent)
            {
                this.componentContent = componentContent;
            }
            RenderFragment IComponentContentHolder.ComponentContent => componentContent;
        }
        public IComponentView(IModelComponentViewItem model, Type classType) : base(classType, model.Id) { }
        protected override object CreateControlCore()
        {
            RenderFragment iframeFragment;
            iframeFragment = b =>
            {
                b.OpenElement(1, "div");
                b.OpenElement(2, "iframe");
                //b.AddAttribute(2, "src", "https://en.wikipedia.org/wiki/IFrame");
                b.AddAttribute(2, "id", "frame_id");
                b.AddAttribute(2, "src", "https://localhost:44318/scheduler");
                b.AddAttribute(2, "width", "100%");
                b.AddAttribute(2, "height", "800px"); 
                b.AddAttribute(2, "frameborder", "0");
                b.AddAttribute(2, "border-radius", "20px");
                b.CloseElement();
                b.CloseElement();

            };           

            return new ComponentContentHolder(iframeFragment);
        }
    }
}
