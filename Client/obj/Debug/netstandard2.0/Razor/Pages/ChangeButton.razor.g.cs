#pragma checksum "/Users/taniguchi/blazorhosted/Client/Pages/ChangeButton.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b980570858b96b80367ab534a84f579ee0b10d8b"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorhosted.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/Users/taniguchi/blazorhosted/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "/Users/taniguchi/blazorhosted/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "/Users/taniguchi/blazorhosted/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "/Users/taniguchi/blazorhosted/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 5 "/Users/taniguchi/blazorhosted/Client/_Imports.razor"
using blazorhosted.Client;

#line default
#line hidden
#line 6 "/Users/taniguchi/blazorhosted/Client/_Imports.razor"
using blazorhosted.Client.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/changebutton")]
    public class ChangeButton : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
#line 3 "/Users/taniguchi/blazorhosted/Client/Pages/ChangeButton.razor"
 if(modeSwich)
{

#line default
#line hidden
            builder.AddContent(0, "    ");
            builder.AddMarkupContent(1, "<p>Mode is ON!</p>\n");
#line 6 "/Users/taniguchi/blazorhosted/Client/Pages/ChangeButton.razor"
}
else
{

#line default
#line hidden
            builder.AddContent(2, "    ");
            builder.AddMarkupContent(3, "<p>Mode is OFF</p>\n");
#line 10 "/Users/taniguchi/blazorhosted/Client/Pages/ChangeButton.razor"
}

#line default
#line hidden
#line 11 "/Users/taniguchi/blazorhosted/Client/Pages/ChangeButton.razor"
 switch(modeSwich)
{
    case false:

#line default
#line hidden
            builder.AddContent(4, "    ");
            builder.AddMarkupContent(5, "<p>Mode is OFF</p>\n");
#line 15 "/Users/taniguchi/blazorhosted/Client/Pages/ChangeButton.razor"
    break;

    case true:

#line default
#line hidden
            builder.AddContent(6, "    ");
            builder.AddMarkupContent(7, "<p>Mode is ON!</p>\n");
#line 19 "/Users/taniguchi/blazorhosted/Client/Pages/ChangeButton.razor"
    break;
}

#line default
#line hidden
            builder.OpenElement(8, "button");
            builder.AddAttribute(9, "class", "btn btn-primary");
            builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 21 "/Users/taniguchi/blazorhosted/Client/Pages/ChangeButton.razor"
                                           modeChange

#line default
#line hidden
            ));
            builder.AddMarkupContent(11, "\n    ChangeMode\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 26 "/Users/taniguchi/blazorhosted/Client/Pages/ChangeButton.razor"
 
    bool modeSwich = false;
    void modeChange()
    {
        modeSwich = !modeSwich;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
