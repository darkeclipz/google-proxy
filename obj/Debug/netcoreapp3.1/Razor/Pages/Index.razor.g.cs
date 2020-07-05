#pragma checksum "C:\Users\Lars\Documents\GoogleProxy\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c89dcb5a0221eff5254b699f1961fdae5713db45"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "header");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\Lars\Documents\GoogleProxy\Pages\Index.razor"
                              Clear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<div>\r\n        <img src=\"/logo.png\" class=\"logo\">\r\n    </div>\r\n    ");
            __builder.AddMarkupContent(5, "<h1>gproxy</h1>\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "search");
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "id", "search");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "placeholder", "What are you looking for?");
            __builder.AddAttribute(14, "value", 
#nullable restore
#line 14 "C:\Users\Lars\Documents\GoogleProxy\Pages\Index.razor"
                Query

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Lars\Documents\GoogleProxy\Pages\Index.razor"
                   async (args) => await OnSearchChangeAsync(args)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onkeydown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Lars\Documents\GoogleProxy\Pages\Index.razor"
                    (args) => OnKeyDown(args)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n");
#nullable restore
#line 19 "C:\Users\Lars\Documents\GoogleProxy\Pages\Index.razor"
 if(!HasResults && !IsSearching)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "    ");
            __builder.AddMarkupContent(20, @"<div class=""info"">
        <div>
            <h2>Search on Google while hiding your device and/or location.</h2>
            <p>
                Your search query is used to retrieve the Google search results on the server.
                The results are then displayed here. Your device doesn't make a request to
                the servers of Google, but we do it instead. Enjoy privacy while using Google.
            </p>
        </div>
        <div class=""info-icon"">
            <span class=""oi oi-eye""></span>
        </div>
    </div>
");
#nullable restore
#line 34 "C:\Users\Lars\Documents\GoogleProxy\Pages\Index.razor"
    
}
else if(IsSearching)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "    ");
            __builder.AddMarkupContent(22, "<div class=\"searching fade-in\">\r\n        Searching ...\r\n    </div>\r\n");
#nullable restore
#line 41 "C:\Users\Lars\Documents\GoogleProxy\Pages\Index.razor"
}
else 
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "    ");
            __builder.OpenElement(24, "h2");
            __builder.AddContent(25, 
#nullable restore
#line 44 "C:\Users\Lars\Documents\GoogleProxy\Pages\Index.razor"
         Results.Count()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(26, " Results");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 45 "C:\Users\Lars\Documents\GoogleProxy\Pages\Index.razor"
    foreach(var result in Results)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "        ");
            __builder.OpenComponent<GoogleProxy.Shared.SearchResult>(29);
            __builder.AddAttribute(30, "Uri", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Uri>(
#nullable restore
#line 47 "C:\Users\Lars\Documents\GoogleProxy\Pages\Index.razor"
                            result

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 48 "C:\Users\Lars\Documents\GoogleProxy\Pages\Index.razor"
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\Lars\Documents\GoogleProxy\Pages\Index.razor"
       
    private IEnumerable<Uri> Results { get; set; }
    private bool HasResults { get => Results != null; }
    private bool IsSearching { get; set; }
    private string Query { get; set; }

    protected override void OnAfterRender(bool firstRender) 
    {
        if(firstRender) 
        {
            JSRuntime.InvokeVoidAsync("focus");
        }
    }

    private async Task OnSearchChangeAsync(ChangeEventArgs args) 
    {
        IsSearching = true;
        Results = new List<Uri>();
        Query = args.Value.ToString();
        if(string.IsNullOrWhiteSpace(Query)) 
        {
            Clear();
        }
        else 
        {
            Results = await GoogleApi.GetSearchResultsAsync(Query);
        }
        IsSearching = false;
    }

    private void Clear() 
    {
        Results = null;
        Query = string.Empty;
        JSRuntime.InvokeVoidAsync("focus");
    }

    private void OnKeyDown(KeyboardEventArgs args)
    {
        if(args.Key == "Escape") 
        {
            Clear();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
