using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace TextareaTest.Components
{
    partial class MyTextArea
    {
        [Parameter] public string Value { get; set; } = string.Empty;
        [Parameter] public EventCallback<string> ValueChanged { get; set; }
        RenderFragment copyElement;
        void AutoResize(KeyboardEventArgs args)
        {
            copyElement = new RenderFragment(b =>
            {
                b.OpenElement(1, "div");
                b.AddContent(2, (MarkupString)Value.Replace("\n", "<br/>"));
                b.CloseElement();
            });
        }
    }
}
