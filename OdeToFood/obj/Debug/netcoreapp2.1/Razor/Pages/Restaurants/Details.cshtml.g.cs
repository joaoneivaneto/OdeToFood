#pragma checksum "C:\Users\joaon\source\repos\OdeToFood\OdeToFood\Pages\Restaurants\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0e35b9af4e26ed9070f1ebc6c8e42dbbe50affa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OdeToFood.Pages.Restaurants.Pages_Restaurants_Details), @"mvc.1.0.razor-page", @"/Pages/Restaurants/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Restaurants/Details.cshtml", typeof(OdeToFood.Pages.Restaurants.Pages_Restaurants_Details), @"{restaurantId:int}")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{restaurantId:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0e35b9af4e26ed9070f1ebc6c8e42dbbe50affa", @"/Pages/Restaurants/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0820fb6dbe507f6ce740cdfd07cdc5236e4275df", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restaurants_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\joaon\source\repos\OdeToFood\OdeToFood\Pages\Restaurants\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
            BeginContext(118, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(125, 21, false);
#line 8 "C:\Users\joaon\source\repos\OdeToFood\OdeToFood\Pages\Restaurants\Details.cshtml"
Write(Model.Restaurant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(146, 22, true);
            WriteLiteral("</h2>\r\n<div>\r\n    Id: ");
            EndContext();
            BeginContext(169, 19, false);
#line 10 "C:\Users\joaon\source\repos\OdeToFood\OdeToFood\Pages\Restaurants\Details.cshtml"
   Write(Model.Restaurant.Id);

#line default
#line hidden
            EndContext();
            BeginContext(188, 31, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Location: ");
            EndContext();
            BeginContext(220, 25, false);
#line 13 "C:\Users\joaon\source\repos\OdeToFood\OdeToFood\Pages\Restaurants\Details.cshtml"
         Write(Model.Restaurant.Location);

#line default
#line hidden
            EndContext();
            BeginContext(245, 29, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Cuisine:");
            EndContext();
            BeginContext(275, 24, false);
#line 16 "C:\Users\joaon\source\repos\OdeToFood\OdeToFood\Pages\Restaurants\Details.cshtml"
       Write(Model.Restaurant.cuisine);

#line default
#line hidden
            EndContext();
            BeginContext(299, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
#line 18 "C:\Users\joaon\source\repos\OdeToFood\OdeToFood\Pages\Restaurants\Details.cshtml"
 if(Model.Message != null)
            {

#line default
#line hidden
            BeginContext(352, 46, true);
            WriteLiteral("                <div class=\"alert alert-info\">");
            EndContext();
            BeginContext(399, 13, false);
#line 20 "C:\Users\joaon\source\repos\OdeToFood\OdeToFood\Pages\Restaurants\Details.cshtml"
                                         Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(412, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 21 "C:\Users\joaon\source\repos\OdeToFood\OdeToFood\Pages\Restaurants\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(435, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3ded38b2c45486b9846fc7585f024e4", async() => {
                BeginContext(480, 15, true);
                WriteLiteral("All Restaurants");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OdeToFood.Pages.Restaurants.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Restaurants.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Restaurants.DetailsModel>)PageContext?.ViewData;
        public OdeToFood.Pages.Restaurants.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
