#pragma checksum "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0aaa45f6a24fb446259b7b4f22f411f977cfb523"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingPizza.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.OpenElement(2, "ul");
            __builder.AddAttribute(3, "class", "pizza-cards");
#nullable restore
#line 9 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Index.razor"
         if (specials != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Index.razor"
             foreach (var special in specials)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "li");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Index.razor"
                                () => OrderState.ShowConfigurePizzaDialog(special)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 13 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Index.razor"
                                                                                                                    special.ImageUrl

#line default
#line hidden
#nullable disable
            ) + "\')");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "pizza-info");
            __builder.OpenElement(9, "span");
            __builder.AddAttribute(10, "class", "title");
#nullable restore
#line 15 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Index.razor"
__builder.AddContent(11, special.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n                        ");
#nullable restore
#line 16 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Index.razor"
__builder.AddContent(13, special.Description);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "\n                        ");
            __builder.OpenElement(15, "span");
            __builder.AddAttribute(16, "class", "price");
#nullable restore
#line 17 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Index.razor"
__builder.AddContent(17, special.GetFormattedBasePrice());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Index.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n\n");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "sidebar");
#nullable restore
#line 26 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Index.razor"
     if (Order.Pizzas.Any())
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "order-contents");
            __builder.AddMarkupContent(23, "<h2>Your order</h2>");
#nullable restore
#line 31 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Index.razor"
             foreach (var configuredPizza in Order.Pizzas)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazingPizza.Client.Shared.ConfiguredPizzaItem>(24);
            __builder.AddAttribute(25, "Pizza", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazingPizza.Pizza>(
#nullable restore
#line 33 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Index.razor"
                                            configuredPizza

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "OnRemoved", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 33 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Index.razor"
                                                                          () => RemovePizza(configuredPizza)

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 34 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Index.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(27, "<div class=\"empty-cart\">Choose a pizza<br>to get started</div>");
#nullable restore
#line 40 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "order-total" + " " + (
#nullable restore
#line 42 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Index.razor"
                              Order.Pizzas.Any() ? "" : "hidden"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "\n        Total:\n        ");
            __builder.OpenElement(31, "span");
            __builder.AddAttribute(32, "class", "total-price");
#nullable restore
#line 44 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Index.razor"
__builder.AddContent(33, Order.GetFormattedTotalPrice());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n        ");
            __builder.OpenElement(35, "a");
            __builder.AddAttribute(36, "href", "checkout");
            __builder.AddAttribute(37, "class", 
#nullable restore
#line 45 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Index.razor"
                                    Order.Pizzas.Count == 0 ? "btn btn-warning disabled" : "btn btn-warning"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(38, "\n            Order >\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n\n");
            __builder.OpenComponent<BlazingComponents.TemplatedDialog>(40);
            __builder.AddAttribute(41, "Show", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 51 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Index.razor"
                       OrderState.ShowingConfigureDialog

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<BlazingPizza.Client.Shared.ConfigurePizzaDialog>(43);
                __builder2.AddAttribute(44, "Pizza", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazingPizza.Pizza>(
#nullable restore
#line 53 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Index.razor"
               OrderState.ConfiguringPizza

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "OnCancel", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 54 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Index.razor"
                  OrderState.CancelConfigurePizzaDialog

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(46, "OnConfirm", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 55 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Index.razor"
                   OrderState.ConfirmConfigurePizzaDialog

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Index.razor"
       
    List<PizzaSpecial> specials;
    Order Order => OrderState.Order;

    protected override async Task OnInitializedAsync()
    {
        specials = await HttpClient.GetFromJsonAsync<List<PizzaSpecial>>("specials");
    }

    async Task RemovePizza(Pizza configuredPizza)
    {
        if (await JS.Confirm($"Remove {configuredPizza.Special.Name} pizza from the order?"))
        {
            OrderState.RemoveConfiguredPizza(configuredPizza);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrderState OrderState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
