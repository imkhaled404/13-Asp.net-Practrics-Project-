#pragma checksum "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Settings\LeaveCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40d088fdf2bdd927a18b79d91d1d7aaf8619a045"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_AdminPages_Settings_LeaveCategory), @"mvc.1.0.razor-page", @"/Pages/AdminPages/Settings/LeaveCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/AdminPages/Settings/LeaveCategory.cshtml", typeof(AspNetCore.Pages_AdminPages_Settings_LeaveCategory), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40d088fdf2bdd927a18b79d91d1d7aaf8619a045", @"/Pages/AdminPages/Settings/LeaveCategory.cshtml")]
    public class Pages_AdminPages_Settings_LeaveCategory : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AddLeaveCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Settings\LeaveCategory.cshtml"
  
    ViewData["Title"] = "LeaveCategory";
    Layout = "~/Views/Shared/_AdminDashboardLayout.cshtml";

#line default
#line hidden
            BeginContext(256, 365, true);
            WriteLiteral(@"

<center><h1>Leave Category</h1></center>


<div class=""container-fluid"">
    <div class=""wrap-fpanel"">
        <div class=""row"">
            <div class=""col-sm-12"" data-offset=""0"">
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <div class=""panel-heading"">
                            <h5>");
            EndContext();
            BeginContext(621, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40d088fdf2bdd927a18b79d91d1d7aaf8619a0454489", async() => {
                BeginContext(654, 45, true);
                WriteLiteral("<i class=\"fa fa-plus\"></i> Add Leave Category");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(703, 1279, true);
            WriteLiteral(@"</h5>
                           
                        </div>
                        <div class=""panel-title"">
                            <strong class=""mb-2"">List of All Leave Category</strong>
                        </div>
                    </div>


                   


                    <div class=""card shadow mb-4 mt-4"">
                        <div class=""card-body"">
                            <div class=""table-responsive"">
                                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                                    <colgroup>
                                        <col />
                                        <col class=""col-7""/>
                                        <col />
                                        <col />
                                    </colgroup>
                                    <thead>
                                        <tr>
                                            <th>SL</th>
                     ");
            WriteLiteral("                       <th>Category Name</th>\n                                            <th>Days</th>\n                                            <th>Action</th>\n                                        </tr>\n                                    </thead>\n");
            EndContext();
#line 51 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Settings\LeaveCategory.cshtml"
                                     if (Model.LeaveCategories != null)
                                    {
                                        if (Model.LeaveCategories.Count > 0)
                                        {
                                            

#line default
#line hidden
#line 55 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Settings\LeaveCategory.cshtml"
                                             if (Model.LeaveCategories.Count > 10)
                                            {

#line default
#line hidden
            BeginContext(2340, 517, true);
            WriteLiteral(@"                                                <tfoot>
                                                    <tr>
                                                        <th>SL</th>
                                                        <th>Category Name</th>
                                                        <th>Days</th>
                                                        <th>Action</th>
                                                    </tr>
                                                </tfoot>
");
            EndContext();
#line 65 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Settings\LeaveCategory.cshtml"
                                            }

#line default
#line hidden
            BeginContext(2904, 53, true);
            WriteLiteral("                                            <tbody>\n\n");
            EndContext();
#line 69 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Settings\LeaveCategory.cshtml"
                                                 for (int i = 0; i < Model.LeaveCategories.Count; i++)
                                                {

#line default
#line hidden
            BeginContext(3110, 117, true);
            WriteLiteral("                                                    <tr>\n                                                        <td>");
            EndContext();
            BeginContext(3229, 5, false);
#line 72 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Settings\LeaveCategory.cshtml"
                                                        Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(3235, 66, true);
            WriteLiteral("</td>\n                                                        <td>");
            EndContext();
            BeginContext(3302, 30, false);
#line 73 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Settings\LeaveCategory.cshtml"
                                                       Write(Model.LeaveCategories[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(3332, 66, true);
            WriteLiteral("</td>\n                                                        <td>");
            EndContext();
            BeginContext(3399, 29, false);
#line 74 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Settings\LeaveCategory.cshtml"
                                                       Write(Model.LeaveCategories[i].Days);

#line default
#line hidden
            EndContext();
            BeginContext(3428, 228, true);
            WriteLiteral("</td>\n                                                        <td>\n                                                            <div class=\"row\">\n                                                                <div class=\"col-6\">");
            EndContext();
            BeginContext(3656, 134, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40d088fdf2bdd927a18b79d91d1d7aaf8619a04510904", async() => {
                BeginContext(3727, 59, true);
                WriteLiteral("<span class=\"oi Edit-HyperLink\" data-glyph=\"pencil\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Settings\LeaveCategory.cshtml"
                                                                                                                WriteLiteral(Model.LeaveCategories[i].Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3790, 90, true);
            WriteLiteral("</div>\n                                                                <div class=\"col-6\">");
            EndContext();
            BeginContext(3880, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40d088fdf2bdd927a18b79d91d1d7aaf8619a04513489", async() => {
                BeginContext(3953, 60, true);
                WriteLiteral("<span class=\"oi Delete-HyperLink\" data-glyph=\"trash\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Settings\LeaveCategory.cshtml"
                                                                                                                  WriteLiteral(Model.LeaveCategories[i].Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4017, 194, true);
            WriteLiteral("</div>\n                                                            </div>\n                                                        </td>\n                                                    </tr>\n");
            EndContext();
#line 82 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Settings\LeaveCategory.cshtml"
                                                }

#line default
#line hidden
            BeginContext(4261, 54, true);
            WriteLiteral("\n                                            </tbody>\n");
            EndContext();
#line 85 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Settings\LeaveCategory.cshtml"
                                        }
                                    }

#line default
#line hidden
            BeginContext(4395, 135, true);
            WriteLiteral("                                </table>\n                            </div>\n                        </div>\n                    </div>\n\n");
            EndContext();
            BeginContext(5004, 78, true);
            WriteLiteral("\n\n\n\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HR_Management_System.Pages.LeaveCategoryModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.LeaveCategoryModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.LeaveCategoryModel>)PageContext?.ViewData;
        public HR_Management_System.Pages.LeaveCategoryModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
