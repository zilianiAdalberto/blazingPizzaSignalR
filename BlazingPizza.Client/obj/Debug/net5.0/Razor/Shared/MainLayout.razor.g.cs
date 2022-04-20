#pragma checksum "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bef5039829ff0d61bae771d915bc2cc1b2568e2"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingPizza.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary.Map;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\_Imports.razor"
using BlazingComponents;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-bar");
            __builder.AddMarkupContent(2, "<a class=\"logo\" href><img src=\"img/logo.svg\"></a>\n\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(3);
            __builder.AddAttribute(4, "href", "");
            __builder.AddAttribute(5, "class", "nav-tab");
            __builder.AddAttribute(6, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 8 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Shared\MainLayout.razor"
                                            NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "<img src=\"img/pizza-slice.svg\">\n        ");
                __builder2.AddMarkupContent(9, "<div>Get Pizza</div>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\n\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(11);
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(13);
                __builder2.AddAttribute(14, "href", "myorders");
                __builder2.AddAttribute(15, "class", "nav-tab");
                __builder2.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(17, "<img src=\"img/bike.svg\">\n            ");
                    __builder3.AddMarkupContent(18, "<div>My Orders</div>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\n\n    ");
            __builder.OpenComponent<BlazingPizza.Client.Shared.LoginDisplay>(20);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n\n");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "content");
#nullable restore
#line 24 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Shared\MainLayout.razor"
__builder.AddContent(24, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
