#pragma checksum "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Views\Inventory\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "879673f1f5c1f07342b0407f0d4c841174acb14e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventory_Create), @"mvc.1.0.view", @"/Views/Inventory/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"879673f1f5c1f07342b0407f0d4c841174acb14e", @"/Views/Inventory/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_Viewimports.cshtml")]
    public class Views_Inventory_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dotnet_ECommerce.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Views\Inventory\Create.cshtml"
  
    ViewData["Title"] = "Create Item";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1>Create</h1>\r\n    <hr />\n    <div class=\"row\">\n        <div class=\"col\">\n");
#nullable restore
#line 12 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Views\Inventory\Create.cshtml"
             using (Html.BeginForm("Create", "Inventory", FormMethod.Post, new { enctype = "multipart/form-data" }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "879673f1f5c1f07342b0407f0d4c841174acb14e5600", async() => {
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "879673f1f5c1f07342b0407f0d4c841174acb14e5876", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 15 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Views\Inventory\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n                    <div class=\"form-group\">  \n                        ");
#nullable restore
#line 18 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Views\Inventory\Create.cshtml"
                   Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 19 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Views\Inventory\Create.cshtml"
                   Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 20 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Views\Inventory\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>  \n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 23 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Views\Inventory\Create.cshtml"
                   Write(Html.LabelFor(model => model.Sku, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 24 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Views\Inventory\Create.cshtml"
                   Write(Html.EditorFor(model => model.Sku, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 25 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Views\Inventory\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Sku, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 28 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Views\Inventory\Create.cshtml"
                   Write(Html.LabelFor(model => model.Price, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 29 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Views\Inventory\Create.cshtml"
                   Write(Html.EditorFor(model => model.Price, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 30 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Views\Inventory\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Price, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 33 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Views\Inventory\Create.cshtml"
                   Write(Html.LabelFor(model => model.Description, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 34 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Views\Inventory\Create.cshtml"
                   Write(Html.EditorFor(model => model.Description, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 35 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Views\Inventory\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 38 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Views\Inventory\Create.cshtml"
                   Write(Html.LabelFor(model => model.IsFeatured, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 39 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Views\Inventory\Create.cshtml"
                   Write(Html.EditorFor(model => model.IsFeatured, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
#nullable restore
#line 40 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Views\Inventory\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.IsFeatured, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">  \n                        ");
#nullable restore
#line 43 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Views\Inventory\Create.cshtml"
                   Write(Html.LabelFor(model => model.File, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("  \n                        <div>  \n                            ");
#nullable restore
#line 45 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Views\Inventory\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.File, new { type = "file" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("  \n                            ");
#nullable restore
#line 46 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Views\Inventory\Create.cshtml"
                       Write(Html.ValidationMessageFor(m => m.File));

#line default
#line hidden
#nullable disable
                WriteLiteral("  \n                        </div>  \n                    </div> \n                    <div class=\"form-group\">\n                        <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "879673f1f5c1f07342b0407f0d4c841174acb14e14765", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    </div>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 54 "F:\ASP.Net Core\Project\plants-eCommerce\dotnet_ECommerce\dotnet_ECommerce\Views\Inventory\Create.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dotnet_ECommerce.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
