#pragma checksum "H:\Project\Check\HRM\HR Management System\Pages\EmployeePages\Employee_Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d9b8a4e1eafe19827aead12792db6300fe7d21f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_EmployeePages_Employee_Dashboard), @"mvc.1.0.razor-page", @"/Pages/EmployeePages/Employee_Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/EmployeePages/Employee_Dashboard.cshtml", typeof(AspNetCore.Pages_EmployeePages_Employee_Dashboard), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d9b8a4e1eafe19827aead12792db6300fe7d21f", @"/Pages/EmployeePages/Employee_Dashboard.cshtml")]
    public class Pages_EmployeePages_Employee_Dashboard : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ViewNotice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "H:\Project\Check\HRM\HR Management System\Pages\EmployeePages\Employee_Dashboard.cshtml"
  
    ViewData["Title"] = "Employee_Dashboard";

    Layout = "~/Views/Shared/_EmployeeLayout.cshtml";


#line default
#line hidden
            BeginContext(262, 450, true);
            WriteLiteral(@"

<center><h2>Dashboard</h2></center>


<div class=""wrap-fpanel"">
    <div class=""row"">
        <div class=""col-sm-12"" data-offset=""0"">
            <div class=""panel panel-default"">


                <div class=""card shadow mb-4"">

                    <div class=""row"">
                        <div class=""col-sm-6 col-md-6"">
                            <div id=""dataTable_filter"" class=""dataTables_filter ml-4 mt-4"">
                                ");
            EndContext();
            BeginContext(712, 351, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d9b8a4e1eafe19827aead12792db6300fe7d21f4530", async() => {
                BeginContext(731, 325, true);
                WriteLiteral(@"
                                    <label>Search:<input type=""search"" class=""form-control form-control-sm"" placeholder=""Search by Title"" name=""src_string""></label>
                                    <span><button class=""btn btn-primary form-control-sm"" type=""submit"">Search</button></span>
                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1063, 745, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>


                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                                <thead>
                                    <tr role=""row"">
                                        <th>SL</th>
                                        <th>Created Date</th>
                                        <th>Title</th>

                                        <th>Action</th>
                                    </tr>
                                </thead>
                                <tbody>
");
            EndContext();
#line 49 "H:\Project\Check\HRM\HR Management System\Pages\EmployeePages\Employee_Dashboard.cshtml"
                                     if (Model.Notices != null)
                                    {
                                        if (Model.Notices.Count > 0)
                                        {
                                            for (int i = 0; i < Model.Notices.Count; i++)
                                            {

#line default
#line hidden
            BeginContext(2157, 139, true);
            WriteLiteral("                                                <tr class=\"odd\">\n                                                    <td class=\"sorting_1\">");
            EndContext();
            BeginContext(2298, 5, false);
#line 56 "H:\Project\Check\HRM\HR Management System\Pages\EmployeePages\Employee_Dashboard.cshtml"
                                                                      Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(2304, 62, true);
            WriteLiteral("</td>\n                                                    <td>");
            EndContext();
            BeginContext(2367, 51, false);
#line 57 "H:\Project\Check\HRM\HR Management System\Pages\EmployeePages\Employee_Dashboard.cshtml"
                                                   Write(Model.ShortDateString(Model.Notices[i].CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2418, 62, true);
            WriteLiteral("</td>\n                                                    <td>");
            EndContext();
            BeginContext(2481, 22, false);
#line 58 "H:\Project\Check\HRM\HR Management System\Pages\EmployeePages\Employee_Dashboard.cshtml"
                                                   Write(Model.Notices[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(2503, 120, true);
            WriteLiteral("</td>\n\n                                                    <td>\n                                                        ");
            EndContext();
            BeginContext(2623, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d9b8a4e1eafe19827aead12792db6300fe7d21f9435", async() => {
                BeginContext(2686, 4, true);
                WriteLiteral("View");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "H:\Project\Check\HRM\HR Management System\Pages\EmployeePages\Employee_Dashboard.cshtml"
                                                                                     WriteLiteral(Model.Notices[i].Id);

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
            BeginContext(2694, 113, true);
            WriteLiteral("\n                                                    </td>\n                                                </tr>\n");
            EndContext();
#line 64 "H:\Project\Check\HRM\HR Management System\Pages\EmployeePages\Employee_Dashboard.cshtml"
                                            }
                                        }
                                    }

#line default
#line hidden
            BeginContext(2933, 214, true);
            WriteLiteral("\n\n                                </tbody>\n                            </table>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HR_Management_System.Pages.Employee_DashboardModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.Employee_DashboardModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.Employee_DashboardModel>)PageContext?.ViewData;
        public HR_Management_System.Pages.Employee_DashboardModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591