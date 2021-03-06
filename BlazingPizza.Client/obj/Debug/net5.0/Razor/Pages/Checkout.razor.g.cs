#pragma checksum "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Checkout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8b49cfa8a9665933981cebff3a7fe4d99bb5bd7"
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
#nullable restore
#line 2 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Checkout.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/checkout")]
    public partial class Checkout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Checkout.razor"
                     OrderState.Order.DeliveryAddress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Checkout.razor"
                                                                      PlaceOrder

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "checkout-cols");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "checkout-order-details");
                __builder2.AddMarkupContent(10, "<h4>Review order</h4>\n                ");
                __builder2.OpenComponent<BlazingPizza.Client.Shared.OrderReview>(11);
                __builder2.AddAttribute(12, "Order", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazingPizza.Order>(
#nullable restore
#line 13 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Checkout.razor"
                                    OrderState.Order

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\n\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "checkout-delivery-address");
                __builder2.AddMarkupContent(16, "<h4>Deliver to...</h4>\n                ");
                __builder2.OpenComponent<BlazingPizza.Client.Shared.AddressEditor>(17);
                __builder2.AddAttribute(18, "Address", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazingPizza.Address>(
#nullable restore
#line 18 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Checkout.razor"
                                        OrderState.Order.DeliveryAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n\n        ");
                __builder2.OpenElement(20, "button");
                __builder2.AddAttribute(21, "type", "submit");
                __builder2.AddAttribute(22, "class", "checkout-button btn btn-warning");
                __builder2.AddAttribute(23, "disabled", 
#nullable restore
#line 22 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Checkout.razor"
                                                                                 isSubmitting

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(24, "\n            Place order\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\n\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(26);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\Checkout.razor"
       
    bool isSubmitting;

    protected override void OnInitialized()
    {
        // In the background, ask if they want to be notified about order updates
        _ = RequestNotificationSubscriptionAsync();
    }

    async Task RequestNotificationSubscriptionAsync()
    {
        var subscription = await JSRuntime.InvokeAsync<NotificationSubscription>("blazorPushNotifications.requestSubscription");
        if (subscription != null)
        {
            try
            {
                await OrdersClient.SubscribeToNotifications(subscription);
            }
            catch (AccessTokenNotAvailableException ex)
            {
                ex.Redirect();
            }
        }
    }

    async Task PlaceOrder()
    {
        isSubmitting = true;

        try
        {
            var newOrderId = await OrdersClient.PlaceOrder(OrderState.Order);
            OrderState.ResetOrder();
            NavigationManager.NavigateTo($"myorders/{newOrderId}");
        }
        catch (AccessTokenNotAvailableException ex)
        {
            ex.Redirect();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrdersClient OrdersClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrderState OrderState { get; set; }
    }
}
#pragma warning restore 1591
