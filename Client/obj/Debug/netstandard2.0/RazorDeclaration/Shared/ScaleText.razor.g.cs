#pragma checksum "C:\Users\taniguchi\source\repos\githubblazor\Blazor\Client\Shared\ScaleText.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac9cb9cc208081cf81256114e5695ed0576cd42c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public class ScaleText : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 4 "C:\Users\taniguchi\source\repos\githubblazor\Blazor\Client\Shared\ScaleText.razor"
      
    /*
    *自作コンポーネント
    */

    private string cookedSize{get => Size + "em";}

    // Parameter属性がついたプロパティは外部から値を受け取るパラメーターとして機能する
    [Parameter]
    private string Size{get;set;}

    [Parameter]
    private RenderFragment ChildContent{get;set;}


#line default
#line hidden
    }
}
#pragma warning restore 1591
