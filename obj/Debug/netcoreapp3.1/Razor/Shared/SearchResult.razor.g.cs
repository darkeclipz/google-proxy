#pragma checksum "C:\Users\Lars\Documents\GoogleProxy\Shared\SearchResult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8beafe23846614e3a8890e5d26081cc8e2ec55c6"
// <auto-generated/>
#pragma warning disable 1591
namespace GoogleProxy.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lars\Documents\GoogleProxy\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lars\Documents\GoogleProxy\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lars\Documents\GoogleProxy\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lars\Documents\GoogleProxy\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lars\Documents\GoogleProxy\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lars\Documents\GoogleProxy\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lars\Documents\GoogleProxy\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lars\Documents\GoogleProxy\_Imports.razor"
using GoogleProxy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lars\Documents\GoogleProxy\_Imports.razor"
using GoogleProxy.Shared;

#line default
#line hidden
#nullable disable
    public partial class SearchResult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "a");
            __builder.AddAttribute(1, "href", 
#nullable restore
#line 1 "C:\Users\Lars\Documents\GoogleProxy\Shared\SearchResult.razor"
          Uri.OriginalString

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "target", "_new");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "result fade-in");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "host");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "b");
            __builder.AddContent(11, 
#nullable restore
#line 4 "C:\Users\Lars\Documents\GoogleProxy\Shared\SearchResult.razor"
                Uri.Host

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "small");
            __builder.AddAttribute(14, "class", "path");
            __builder.AddContent(15, 
#nullable restore
#line 5 "C:\Users\Lars\Documents\GoogleProxy\Shared\SearchResult.razor"
                                 Uri.PathAndQuery

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\Lars\Documents\GoogleProxy\Shared\SearchResult.razor"
       
    [Parameter]
    public Uri Uri { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
