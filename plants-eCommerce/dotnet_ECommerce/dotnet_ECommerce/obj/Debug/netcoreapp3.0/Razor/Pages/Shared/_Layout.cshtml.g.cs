#pragma checksum "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60cdcddb322a987d730c97e4f11333cf0c39038c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Shared__Layout), @"mvc.1.0.view", @"/Pages/Shared/_Layout.cshtml")]
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
#nullable restore
#line 1 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Shared\_Layout.cshtml"
using dotnet_ECommerce.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60cdcddb322a987d730c97e4f11333cf0c39038c", @"/Pages/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/LogOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60cdcddb322a987d730c97e4f11333cf0c39038c4533", async() => {
                WriteLiteral(@"
        <!-- Required meta tags -->
        <meta charset=""utf-8"">
        <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

        <!-- Bootstrap CSS -->
        <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
        <link rel=""stylesheet"" href=""/css/style.css"">
        <link rel=""icon"" href=""/images/favicon.png"">
        <title>");
#nullable restore
#line 18 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Shared\_Layout.cshtml"
          Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60cdcddb322a987d730c97e4f11333cf0c39038c6336", async() => {
                WriteLiteral("\r\n        <header>\r\n            <nav class=\"navbar navbar-light bg-light navbar-expand-lg\">\r\n                <a class=\"navbar-brand mb-0 h1\" href=\"/\">\r\n                    <img src=\"/images/logo.svg\" width=\"30\" height=\"30\" class=\"d-inline-block align-top\"");
                BeginWriteAttribute("alt", " alt=\"", 1113, "\"", 1119, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    TINY PLANTS
                </a>
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>

                <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                    <ul class=""navbar-nav mr-auto"">
                        <li class=""nav-item active"">
                            <a class=""nav-link"" href=""/"">Home</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Shop"">Products</a>
                        </li>
");
#nullable restore
#line 39 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Shared\_Layout.cshtml"
                         if (SignInManager.IsSignedIn(User))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li class=\"nav-item\">\n                                <a class=\"nav-link\" href=\"/Shop/Cart\">Cart</a>\n                            </li>\n");
#nullable restore
#line 44 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Shared\_Layout.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Shared\_Layout.cshtml"
                         if ((await AuthorizationService.AuthorizeAsync(User, "AdminOnly")).Succeeded)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li class=\"nav-item\">\n                                <a class=\"nav-link\" href=\"/Admin\">Admin</a>\n                            </li>\n");
#nullable restore
#line 50 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Shared\_Layout.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </ul>\n");
#nullable restore
#line 52 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Shared\_Layout.cshtml"
                     if (SignInManager.IsSignedIn(User))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <div class=""nav-item dropdown"">
                            <a class=""navbar-text dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            Hello, ");
#nullable restore
#line 56 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Shared\_Layout.cshtml"
                              Write(User.Claims.First(c => c.Type == "FullName").Value);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"!
                            </a>
                            <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                                <a class=""dropdown-item navbar-text"" href=""/Account/Profile"">My Profile</a>
                                <a class=""dropdown-item navbar-text"" href=""/Account/Order"">My Orders</a>
                                <div class=""dropdown-divider""></div>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60cdcddb322a987d730c97e4f11333cf0c39038c10688", async() => {
                    WriteLiteral("\r\n                                    <button class=\"dropdown-item navbar-text\" type=\"submit\">Logout</button>\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </div>\n                        </div>\n");
#nullable restore
#line 67 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Shared\_Layout.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a class=\"navbar-text\" href=\"/Account/Login\">Login</a>\r\n                        <span class=\"navbar-text\">&nbsp;/&nbsp;</span>\r\n                        <a class=\"navbar-text\" href=\"/Account/Register\">Register</a>\n");
#nullable restore
#line 73 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Shared\_Layout.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            </nav>\r\n        </header>\r\n        <main>\r\n            ");
#nullable restore
#line 78 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Pages\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </main>
        <!-- Optional JavaScript -->
        <!-- jQuery first, then Popper.js, then Bootstrap JS -->
        <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js"" integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"" crossorigin=""anonymous""></script>
        <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
        <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591