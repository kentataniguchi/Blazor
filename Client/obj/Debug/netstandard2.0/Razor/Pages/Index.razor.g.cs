#pragma checksum "C:\Users\taniguchi\source\repos\githubblazor\Blazor\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a77b19b3283be85bb42745f927a83b2abe739fcb"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorhosted.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 2 "C:\Users\taniguchi\source\repos\githubblazor\Blazor\Client\Pages\Index.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "p");
            builder.AddContent(1, 
#line 5 "C:\Users\taniguchi\source\repos\githubblazor\Blazor\Client\Pages\Index.razor"
    siteName

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(2, "\r\n");
            builder.AddMarkupContent(3, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            builder.OpenComponent<blazorhosted.Client.Shared.SurveyPrompt>(4);
            builder.AddAttribute(5, "Title", "How is Blazor working for you?");
            builder.CloseComponent();
            builder.AddMarkupContent(6, "\r\n\r\n");
            builder.AddMarkupContent(7, "<p>現在時刻が0秒～29秒なら/Counterに飛びます。</p>\r\n");
            builder.AddMarkupContent(8, "<p>現在時刻が30秒～59秒なら/FetchDataに飛びます。</p>\r\n");
            builder.OpenElement(9, "button");
            builder.AddAttribute(10, "class", "btn　btnprimary");
            builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 14 "C:\Users\taniguchi\source\repos\githubblazor\Blazor\Client\Pages\Index.razor"
                                         Jump

#line default
#line hidden
            ));
            builder.AddMarkupContent(12, "Click　to　jump　another　Page");
            builder.CloseElement();
            builder.AddMarkupContent(13, "\r\n\r\n");
            builder.OpenElement(14, "div");
            builder.AddMarkupContent(15, "\r\n    ");
            builder.OpenComponent<blazorhosted.Client.Shared.ScaleText>(16);
            builder.AddAttribute(17, "Size", "1");
            builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(19, "小");
            }
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(20, "\r\n    ");
            builder.OpenComponent<blazorhosted.Client.Shared.ScaleText>(21);
            builder.AddAttribute(22, "Size", "2");
            builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(24, "中");
            }
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(25, "\r\n    ");
            builder.OpenComponent<blazorhosted.Client.Shared.ScaleText>(26);
            builder.AddAttribute(27, "Size", "3");
            builder.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(29, "大");
            }
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(30, "\r\n    ");
            builder.OpenComponent<blazorhosted.Client.Shared.ScaleText>(31);
            builder.AddAttribute(32, "Size", "4");
            builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(34, "特大");
            }
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(35, "\r\n");
            builder.CloseElement();
            builder.AddMarkupContent(36, "\r\n");
            builder.OpenElement(37, "div");
            builder.AddMarkupContent(38, "\r\n    ");
            builder.OpenElement(39, "input");
            builder.AddAttribute(40, "type", "checkbox");
            builder.AddAttribute(41, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 23 "C:\Users\taniguchi\source\repos\githubblazor\Blazor\Client\Pages\Index.razor"
                                   mySwich

#line default
#line hidden
            ));
            builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => mySwich = __value, mySwich));
            builder.SetUpdatesAttributeName("checked");
            builder.CloseElement();
            builder.AddMarkupContent(43, "\r\n    ");
            builder.OpenElement(44, "input");
            builder.AddAttribute(45, "type", "text");
            builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 24 "C:\Users\taniguchi\source\repos\githubblazor\Blazor\Client\Pages\Index.razor"
                               myText

#line default
#line hidden
            ));
            builder.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => myText = __value, myText));
            builder.SetUpdatesAttributeName("value");
            builder.CloseElement();
            builder.AddMarkupContent(48, "\r\n    ");
            builder.OpenElement(49, "input");
            builder.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 25 "C:\Users\taniguchi\source\repos\githubblazor\Blazor\Client\Pages\Index.razor"
                   myDate

#line default
#line hidden
            , format: "yyyy-MM-dd"));
            builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => myDate = __value, myDate, format: "yyyy-MM-dd"));
            builder.SetUpdatesAttributeName("value");
            builder.CloseElement();
            builder.AddMarkupContent(52, "\r\n    ");
            builder.OpenElement(53, "p");
            builder.AddContent(54, 
#line 26 "C:\Users\taniguchi\source\repos\githubblazor\Blazor\Client\Pages\Index.razor"
        mySwich

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(55, "\r\n    ");
            builder.OpenElement(56, "p");
            builder.AddContent(57, 
#line 27 "C:\Users\taniguchi\source\repos\githubblazor\Blazor\Client\Pages\Index.razor"
        myText

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(58, "\r\n    ");
            builder.OpenElement(59, "p");
            builder.AddContent(60, 
#line 28 "C:\Users\taniguchi\source\repos\githubblazor\Blazor\Client\Pages\Index.razor"
        myDate

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(61, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 31 "C:\Users\taniguchi\source\repos\githubblazor\Blazor\Client\Pages\Index.razor"
      
    private bool mySwich = false;
    private string myText = "REWRITE ME";
    [Parameter]
    private DateTime myDate{get;set;} = new DateTime(2020,1,1);
    [CascadingParameter(Name="siteName")]
    protected string siteName{get;set;}

    void Jump(){
        var　sec　=　DateTimeOffset.Now.Second;
        if(sec >= 0 && sec <= 29){
            UriHelper.NavigateTo("/Counter");
        }
        else{
            UriHelper.NavigateTo("/FetchData");
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper UriHelper { get; set; }
    }
}
#pragma warning restore 1591
