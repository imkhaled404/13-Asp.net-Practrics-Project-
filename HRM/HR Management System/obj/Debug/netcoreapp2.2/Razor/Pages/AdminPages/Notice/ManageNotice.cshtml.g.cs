#pragma checksum "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Notice\ManageNotice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c05388e4242ec08c1bc912df22a00a4607afaab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_AdminPages_Notice_ManageNotice), @"mvc.1.0.razor-page", @"/Pages/AdminPages/Notice/ManageNotice.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/AdminPages/Notice/ManageNotice.cshtml", typeof(AspNetCore.Pages_AdminPages_Notice_ManageNotice), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c05388e4242ec08c1bc912df22a00a4607afaab", @"/Pages/AdminPages/Notice/ManageNotice.cshtml")]
    public class Pages_AdminPages_Notice_ManageNotice : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "ViewNotice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "EditNotice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'You are about to delete a record. This cannot be undone. Are you sure?\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Notice\ManageNotice.cshtml"
  
    ViewData["Title"] = "ManageNotice";
    Layout = "~/Views/Shared/_AdminDashboardLayout.cshtml";

#line default
#line hidden
            BeginContext(216, 537, true);
            WriteLiteral(@"
<center><h1>Manage Notice</h1></center>

<div class=""container-fluid"">
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
            BeginContext(753, 389, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c05388e4242ec08c1bc912df22a00a4607afaab5650", async() => {
                BeginContext(772, 363, true);
                WriteLiteral(@"
                                        <label>Search:<input type=""search"" class=""form-control form-control-sm"" placeholder=""Search by Title"" aria-controls=""dataTable"" name=""src_string""></label>
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
            BeginContext(1142, 870, true);
            WriteLiteral(@"

                                </div>
                            </div>
                        </div>


                        <div class=""card-body"">
                            <div class=""table-responsive"">
                                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                                    <thead>
                                        <tr role=""row"">
                                            <th >SL</th>
                                            <th >Created Date</th>
                                            <th >Title</th>
                                            <th >Status</th>
                                            <th >Action</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
            EndContext();
#line 46 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Notice\ManageNotice.cshtml"
                                         if (Model.Notices != null)
                                        {
                                            if (Model.Notices.Count > 0)
                                            {
                                                for (int i = 0; i < Model.Notices.Count; i++)
                                                {

#line default
#line hidden
            BeginContext(2385, 147, true);
            WriteLiteral("                                                    <tr class=\"odd\">\n                                                        <td class=\"sorting_1\">");
            EndContext();
            BeginContext(2534, 5, false);
#line 53 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Notice\ManageNotice.cshtml"
                                                                          Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(2540, 67, true);
            WriteLiteral("</td>\n                                                        <td >");
            EndContext();
            BeginContext(2608, 28, false);
#line 54 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Notice\ManageNotice.cshtml"
                                                        Write(Model.Notices[i].CreatedDate);

#line default
#line hidden
            EndContext();
            BeginContext(2636, 67, true);
            WriteLiteral("</td>\n                                                        <td >");
            EndContext();
            BeginContext(2704, 22, false);
#line 55 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Notice\ManageNotice.cshtml"
                                                        Write(Model.Notices[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(2726, 162, true);
            WriteLiteral("</td>\n                                                        <td >\n                                                            <span class=\"label label-success\">");
            EndContext();
            BeginContext(2889, 45, false);
#line 57 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Notice\ManageNotice.cshtml"
                                                                                         Write(Model.IsPublished(Model.Notices[i].Published));

#line default
#line hidden
            EndContext();
            BeginContext(2934, 362, true);
            WriteLiteral(@"</span>
                                                        </td>
                                                        <td >
                                                            <div class=""row"">
                                                                <div class=""col-4"">
                                                                    ");
            EndContext();
            BeginContext(3296, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c05388e4242ec08c1bc912df22a00a4607afaab11602", async() => {
                BeginContext(3365, 36, true);
                WriteLiteral("<span class=\"fa fa-list-alt\"></span>");
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
#line 62 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Notice\ManageNotice.cshtml"
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
            BeginContext(3405, 224, true);
            WriteLiteral("\n                                                                </div>\n                                                                <div class=\"col-4\">\n                                                                    ");
            EndContext();
            BeginContext(3629, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c05388e4242ec08c1bc912df22a00a4607afaab14279", async() => {
                BeginContext(3690, 59, true);
                WriteLiteral("<span class=\"oi Edit-HyperLink\" data-glyph=\"pencil\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Notice\ManageNotice.cshtml"
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
            BeginContext(3753, 224, true);
            WriteLiteral("\n                                                                </div>\n                                                                <div class=\"col-4\">\n                                                                    ");
            EndContext();
            BeginContext(3977, 229, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c05388e4242ec08c1bc912df22a00a4607afaab16966", async() => {
                BeginContext(4142, 60, true);
                WriteLiteral("<span class=\"oi Delete-HyperLink\" data-glyph=\"trash\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 68 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Notice\ManageNotice.cshtml"
                                                                                                   WriteLiteral(Model.Notices[i].Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4206, 275, true);
            WriteLiteral(@"
                                                                </div>
                                                            </div>
                                                                        </td>
                                                    </tr>
");
            EndContext();
#line 73 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Notice\ManageNotice.cshtml"
                                                }
                                            }
                                        }

#line default
#line hidden
            BeginContext(4619, 259, true);
            WriteLiteral(@"

                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HR_Management_System.Pages.ManageNoticeModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.ManageNoticeModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.ManageNoticeModel>)PageContext?.ViewData;
        public HR_Management_System.Pages.ManageNoticeModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
