#pragma checksum "C:\Users\joaon\source\repos\OdeToFood\OdeToFood\Pages\Restaurants\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fcd5993049c885724bd968a95e3d4cf6994c19f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OdeToFood.Pages.Restaurants.Pages_Restaurants_List), @"mvc.1.0.razor-page", @"/Pages/Restaurants/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Restaurants/List.cshtml", typeof(OdeToFood.Pages.Restaurants.Pages_Restaurants_List), null)]
namespace OdeToFood.Pages.Restaurants
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\joaon\source\repos\OdeToFood\OdeToFood\Pages\_ViewImports.cshtml"
using OdeToFood;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fcd5993049c885724bd968a95e3d4cf6994c19f", @"/Pages/Restaurants/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0820fb6dbe507f6ce740cdfd07cdc5236e4275df", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restaurants_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 45, true);
            WriteLiteral("<h1>Restaurants</h1>\r\n<table class=\"table\">\r\n");
            EndContext();
#line 7 "C:\Users\joaon\source\repos\OdeToFood\OdeToFood\Pages\Restaurants\List.cshtml"
     foreach (var restaurant in Model.Restaurants)
    {

#line default
#line hidden
            BeginContext(164, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(187, 15, false);
#line 10 "C:\Users\joaon\source\repos\OdeToFood\OdeToFood\Pages\Restaurants\List.cshtml"
       Write(restaurant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(202, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(222, 19, false);
#line 11 "C:\Users\joaon\source\repos\OdeToFood\OdeToFood\Pages\Restaurants\List.cshtml"
       Write(restaurant.Location);

#line default
#line hidden
            EndContext();
            BeginContext(241, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(261, 18, false);
#line 12 "C:\Users\joaon\source\repos\OdeToFood\OdeToFood\Pages\Restaurants\List.cshtml"
       Write(restaurant.cuisine);

#line default
#line hidden
            EndContext();
            BeginContext(279, 18, true);
            WriteLiteral("</td>\r\n    </tr>\r\n");
            EndContext();
#line 14 "C:\Users\joaon\source\repos\OdeToFood\OdeToFood\Pages\Restaurants\List.cshtml"
    }

#line default
#line hidden
            BeginContext(304, 12, true);
            WriteLiteral("\r\n</table>\r\n");
            EndContext();
            BeginContext(317, 13, false);
#line 17 "C:\Users\joaon\source\repos\OdeToFood\OdeToFood\Pages\Restaurants\List.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OdeToFood.Pages.Restaurants.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Restaurants.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Restaurants.ListModel>)PageContext?.ViewData;
        public OdeToFood.Pages.Restaurants.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591