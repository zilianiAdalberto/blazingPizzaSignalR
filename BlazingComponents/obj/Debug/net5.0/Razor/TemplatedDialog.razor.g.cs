#pragma checksum "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingComponents\TemplatedDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e721df4a456ded9d901fd1289c504a5333d964cb"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class TemplatedDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingComponents\TemplatedDialog.razor"
 if (Show)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "dialog-container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "dialog");
#nullable restore
#line 5 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingComponents\TemplatedDialog.razor"
__builder.AddContent(4, ChildContent);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 8 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingComponents\TemplatedDialog.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingComponents\TemplatedDialog.razor"
       
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter] public bool Show { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
