#pragma checksum "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a799b7f6462c937a46f013af3ad8fa658e162d46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a799b7f6462c937a46f013af3ad8fa658e162d46", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Index.cshtml"
  
    ViewData["Title"] = "TINY PLANTS";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"bd-example\">\r\n    <div id=\"carouselExampleCaptions\" class=\"carousel slide\" data-ride=\"carousel\">\r\n        <ol class=\"carousel-indicators\">\r\n");
#nullable restore
#line 11 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Index.cshtml"
             for (int i = 0; i < Model.FeaturedProducts.Count; i++)
            {
                if (i == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li data-target=\"#carouselExampleCaptions\" data-slide-to=\"i\" class=\"active\"></li>\r\n");
#nullable restore
#line 16 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li data-target=\"#carouselExampleCaptions\" data-slide-to=\"i\"></li>\r\n");
#nullable restore
#line 20 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ol>\r\n        <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 24 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Index.cshtml"
             for (int i = 0; i < Model.FeaturedProducts.Count; i++)
            {
                if (i == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"carousel-item active\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 961, "\"", 999, 1);
#nullable restore
#line 29 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Index.cshtml"
WriteAttributeValue("", 967, Model.FeaturedProducts[i].Image, 967, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100 hero\" alt=\"...\">\r\n                        <div class=\"carousel-caption d-none d-md-block\">\r\n                            <h5>");
#nullable restore
#line 31 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Index.cshtml"
                           Write(Model.FeaturedProducts[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p>");
#nullable restore
#line 32 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Index.cshtml"
                          Write(Model.FeaturedProducts[i].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 35 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"carousel-item\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1456, "\"", 1494, 1);
#nullable restore
#line 39 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Index.cshtml"
WriteAttributeValue("", 1462, Model.FeaturedProducts[i].Image, 1462, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100 hero\" alt=\"...\">\r\n                        <div class=\"carousel-caption d-none d-md-block\">\r\n                            <h5>");
#nullable restore
#line 41 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Index.cshtml"
                           Write(Model.FeaturedProducts[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p>");
#nullable restore
#line 42 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Index.cshtml"
                          Write(Model.FeaturedProducts[i].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 45 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleCaptions"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleCaptions"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        </a>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dotnet_ECommerce.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<dotnet_ECommerce.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<dotnet_ECommerce.Pages.IndexModel>)PageContext?.ViewData;
        public dotnet_ECommerce.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
