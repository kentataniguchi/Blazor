#pragma checksum "C:\Users\taniguchi\source\repos\githubblazor\Blazor\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4d7774b3fdd2a69b29fc1f9308fb304724f4349"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazorhosted.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\taniguchi\source\repos\githubblazor\Blazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\taniguchi\source\repos\githubblazor\Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\taniguchi\source\repos\githubblazor\Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\taniguchi\source\repos\githubblazor\Blazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 5 "C:\Users\taniguchi\source\repos\githubblazor\Blazor\Client\_Imports.razor"
using blazorhosted.Client;

#line default
#line hidden
#line 6 "C:\Users\taniguchi\source\repos\githubblazor\Blazor\Client\_Imports.razor"
using blazorhosted.Client.Shared;

#line default
#line hidden
#line 2 "C:\Users\taniguchi\source\repos\githubblazor\Blazor\Client\Pages\FetchData.razor"
using blazorhosted.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 38 "C:\Users\taniguchi\source\repos\githubblazor\Blazor\Client\Pages\FetchData.razor"
       
    WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetJsonAsync<WeatherForecast[]>("WeatherForecast");
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
