#pragma checksum "C:\Users\juan-\Downloads\MercaTec (1)\MercaTec\MercaTec\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efa873d53391cc9ebfc7359c24c5a535d51ca565"
// <auto-generated/>
#pragma warning disable 1591
namespace MercaTec.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\juan-\Downloads\MercaTec (1)\MercaTec\MercaTec\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\juan-\Downloads\MercaTec (1)\MercaTec\MercaTec\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\juan-\Downloads\MercaTec (1)\MercaTec\MercaTec\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\juan-\Downloads\MercaTec (1)\MercaTec\MercaTec\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\juan-\Downloads\MercaTec (1)\MercaTec\MercaTec\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\juan-\Downloads\MercaTec (1)\MercaTec\MercaTec\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\juan-\Downloads\MercaTec (1)\MercaTec\MercaTec\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\juan-\Downloads\MercaTec (1)\MercaTec\MercaTec\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\juan-\Downloads\MercaTec (1)\MercaTec\MercaTec\_Imports.razor"
using MercaTec;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\juan-\Downloads\MercaTec (1)\MercaTec\MercaTec\_Imports.razor"
using MercaTec.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "style", "background-color:#FAB70F");
            __builder.AddAttribute(3, "b-m3qk32trv9");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "background-image: none; background: linear-gradient(180deg, rgba(219,140,13,1) 0%, rgba(223,111,12,1) 64%); ");
            __builder.AddAttribute(6, "class", "sidebar shadow");
            __builder.AddAttribute(7, "b-m3qk32trv9");
            __builder.OpenComponent<MercaTec.Shared.NavMenu>(8);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "main");
            __builder.AddAttribute(12, "b-m3qk32trv9");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "content px-4");
            __builder.AddAttribute(15, "b-m3qk32trv9");
            __builder.AddContent(16, 
#nullable restore
#line 12 "C:\Users\juan-\Downloads\MercaTec (1)\MercaTec\MercaTec\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
