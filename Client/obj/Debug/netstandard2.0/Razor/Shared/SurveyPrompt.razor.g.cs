#pragma checksum "C:\Users\taniguchi\source\repos\githubblazor\Blazor\Client\Shared\SurveyPrompt.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fcc2fa87fa60b58784b85fd4e34c866161918b6"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorhosted.Client.Shared
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
    public class SurveyPrompt : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "alert alert-secondary mt-4");
            builder.AddAttribute(2, "role", "alert");
            builder.AddMarkupContent(3, "\r\n    <span class=\"oi oi-pencil mr-2\" aria-hidden=\"true\"></span>\r\n    ");
            builder.OpenElement(4, "strong");
            builder.AddContent(5, 
#line 3 "C:\Users\taniguchi\source\repos\githubblazor\Blazor\Client\Shared\SurveyPrompt.razor"
             Title

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(6, "\r\n\r\n    ");
            builder.AddMarkupContent(7, "<span class=\"text-nowrap\">\r\n        Please take our\r\n        <a target=\"_blank\" class=\"font-weight-bold\" href=\"https://go.microsoft.com/fwlink/?linkid=2098127\">brief survey</a>\r\n    </span>\r\n    and tell us what you think.\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 12 "C:\Users\taniguchi\source\repos\githubblazor\Blazor\Client\Shared\SurveyPrompt.razor"
       
    // Demonstrates how a parent component can supply parameters
    [Parameter] public string Title { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
