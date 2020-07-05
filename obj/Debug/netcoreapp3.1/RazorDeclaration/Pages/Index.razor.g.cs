#pragma checksum "C:\Users\Lars\Documents\GoogleProxy\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "171850aee4a63229509209eeaa49c556db62c84c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\Lars\Documents\GoogleProxy\Pages\Index.razor"
       
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

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
