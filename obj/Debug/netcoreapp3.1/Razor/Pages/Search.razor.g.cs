#pragma checksum "C:\Users\Lars\Documents\GoogleProxy\Pages\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0c8f50f9619cd364ca0d939b78c66ae453176c8"
// <auto-generated/>
#pragma warning disable 1591
namespace GoogleProxy.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/search/{Query}")]
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Search results</h1>\r\n\r\n");
            __builder.OpenElement(1, "span");
            __builder.AddContent(2, 
#nullable restore
#line 5 "C:\Users\Lars\Documents\GoogleProxy\Pages\Search.razor"
       Query

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\Lars\Documents\GoogleProxy\Pages\Search.razor"
       
    [Parameter]
    public string Query { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
