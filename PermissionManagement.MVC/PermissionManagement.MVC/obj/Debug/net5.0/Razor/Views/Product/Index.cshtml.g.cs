#pragma checksum "F:\ASP.Net Core\Project\PermissionManagement.MVC\PermissionManagement.MVC\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f140a8269f941993b485603f9d382a529316b68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "F:\ASP.Net Core\Project\PermissionManagement.MVC\PermissionManagement.MVC\Views\_ViewImports.cshtml"
using PermissionManagement.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ASP.Net Core\Project\PermissionManagement.MVC\PermissionManagement.MVC\Views\_ViewImports.cshtml"
using PermissionManagement.MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\ASP.Net Core\Project\PermissionManagement.MVC\PermissionManagement.MVC\Views\Product\Index.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\ASP.Net Core\Project\PermissionManagement.MVC\PermissionManagement.MVC\Views\Product\Index.cshtml"
using PermissionManagement.MVC.Constants;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f140a8269f941993b485603f9d382a529316b68", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce82a5c279a49daceb98c466d6bdd74dc6bd23cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Product Management</h1>\n<br />\n");
#nullable restore
#line 6 "F:\ASP.Net Core\Project\PermissionManagement.MVC\PermissionManagement.MVC\Views\Product\Index.cshtml"
 if ((AuthorizationService.AuthorizeAsync(User, Permissions.Products.Create)).Result.Succeeded)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button class=\"btn btn-success\">Create</button>\n");
#nullable restore
#line 9 "F:\ASP.Net Core\Project\PermissionManagement.MVC\PermissionManagement.MVC\Views\Product\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\ASP.Net Core\Project\PermissionManagement.MVC\PermissionManagement.MVC\Views\Product\Index.cshtml"
 if ((AuthorizationService.AuthorizeAsync(User, Permissions.Products.View)).Result.Succeeded)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button class=\"btn btn-info\">View</button>\n");
#nullable restore
#line 13 "F:\ASP.Net Core\Project\PermissionManagement.MVC\PermissionManagement.MVC\Views\Product\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "F:\ASP.Net Core\Project\PermissionManagement.MVC\PermissionManagement.MVC\Views\Product\Index.cshtml"
 if ((AuthorizationService.AuthorizeAsync(User, Permissions.Products.Edit)).Result.Succeeded)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button class=\"btn btn-warning\">Modify</button>\n");
#nullable restore
#line 17 "F:\ASP.Net Core\Project\PermissionManagement.MVC\PermissionManagement.MVC\Views\Product\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "F:\ASP.Net Core\Project\PermissionManagement.MVC\PermissionManagement.MVC\Views\Product\Index.cshtml"
 if ((AuthorizationService.AuthorizeAsync(User, Permissions.Products.Delete)).Result.Succeeded)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button class=\"btn btn-danger\">Delete</button>\n");
#nullable restore
#line 21 "F:\ASP.Net Core\Project\PermissionManagement.MVC\PermissionManagement.MVC\Views\Product\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
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
