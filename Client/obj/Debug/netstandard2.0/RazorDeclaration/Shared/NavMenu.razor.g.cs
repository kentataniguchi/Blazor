#pragma checksum "/Users/taniguchi/blazorhosted/Client/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f69780c8a191c7d82b95fc88717c3fe4b54dddfb"
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
    public class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 33 "/Users/taniguchi/blazorhosted/Client/Shared/NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
