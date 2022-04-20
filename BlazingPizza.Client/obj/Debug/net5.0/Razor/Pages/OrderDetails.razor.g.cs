#pragma checksum "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\OrderDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6db709da49db5426da24a9aaf493c11055ea64d4"
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
#line 3 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\OrderDetails.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\OrderDetails.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/myorders/{orderId:int}")]
    public partial class OrderDetails : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
#nullable restore
#line 8 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\OrderDetails.razor"
     if (invalidOrder)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<h2>Nope</h2>\n        ");
            __builder.AddMarkupContent(3, "<p>Sorry, this order could not be loaded.</p>");
#nullable restore
#line 12 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\OrderDetails.razor"
    }
    else if (orderWithStatus == null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "Loading...");
#nullable restore
#line 15 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\OrderDetails.razor"
                               
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "track-order");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "track-order-title");
            __builder.OpenElement(9, "h2");
            __builder.AddMarkupContent(10, "\n                    Order placed ");
#nullable restore
#line 22 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\OrderDetails.razor"
__builder.AddContent(11, orderWithStatus.Order.CreatedTime.ToLongDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n                ");
            __builder.OpenElement(13, "p");
            __builder.AddAttribute(14, "class", "ml-auto mb-0");
            __builder.AddMarkupContent(15, "\n                    Status: ");
            __builder.OpenElement(16, "strong");
#nullable restore
#line 25 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\OrderDetails.razor"
__builder.AddContent(17, orderWithStatus.StatusText);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "track-order-body");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "track-order-details");
            __builder.OpenComponent<BlazingPizza.Client.Shared.OrderReview>(23);
            __builder.AddAttribute(24, "Order", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazingPizza.Order>(
#nullable restore
#line 30 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\OrderDetails.razor"
                                        orderWithStatus.Order

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "track-order-map");
            __builder.OpenComponent<BlazingPizza.ComponentsLibrary.Map.Map>(28);
            __builder.AddAttribute(29, "Zoom", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 33 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\OrderDetails.razor"
                               13

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "Markers", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazingPizza.ComponentsLibrary.Map.Marker>>(
#nullable restore
#line 33 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\OrderDetails.razor"
                                            orderWithStatus.MapMarkers

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\OrderDetails.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\alberto.ziliani\repos\SignalR\Blazing-Pizza\BlazingPizza.Client\Pages\OrderDetails.razor"
       
    [Parameter] public int OrderId { get; set; }

    OrderWithStatus orderWithStatus;
    bool invalidOrder;
    CancellationTokenSource pollingCancellationToken;

    protected override void OnParametersSet()
    {
        // If we were already polling for a different order, stop doing so
        pollingCancellationToken?.Cancel();

        // Start a new poll loop
        PollForUpdates();
    }

    private async void PollForUpdates()
    {
        invalidOrder = false;
        pollingCancellationToken = new CancellationTokenSource();
        while (!pollingCancellationToken.IsCancellationRequested)
        {
            try
            {
                orderWithStatus = await OrdersClient.GetOrder(OrderId);
                StateHasChanged();

                if (orderWithStatus.IsDelivered)
                {
                    pollingCancellationToken.Cancel();
                }
                else
                {
                    await Task.Delay(4000);
                }
            }
            catch (AccessTokenNotAvailableException ex)
            {
                pollingCancellationToken.Cancel();
                ex.Redirect();
            }
            catch (Exception ex)
            {
                invalidOrder = true;
                pollingCancellationToken.Cancel();
                Console.Error.WriteLine(ex);
                StateHasChanged();
            }
        }
    }

    void IDisposable.Dispose()
    {
        pollingCancellationToken?.Cancel();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrdersClient OrdersClient { get; set; }
    }
}
#pragma warning restore 1591
