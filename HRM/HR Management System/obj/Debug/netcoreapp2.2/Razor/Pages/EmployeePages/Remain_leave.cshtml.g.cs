#pragma checksum "H:\Project\Check\HRM\HR Management System\Pages\EmployeePages\Remain_leave.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8636098c3792131c8e2306edf35a5f3498faa3f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_EmployeePages_Remain_leave), @"mvc.1.0.razor-page", @"/Pages/EmployeePages/Remain_leave.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/EmployeePages/Remain_leave.cshtml", typeof(AspNetCore.Pages_EmployeePages_Remain_leave), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8636098c3792131c8e2306edf35a5f3498faa3f5", @"/Pages/EmployeePages/Remain_leave.cshtml")]
    public class Pages_EmployeePages_Remain_leave : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "H:\Project\Check\HRM\HR Management System\Pages\EmployeePages\Remain_leave.cshtml"
  
    ViewData["Title"] = "Remain_leave";
    Layout = "~/Views/Shared/_EmployeeLayout.cshtml";

#line default
#line hidden
            BeginContext(171, 559, true);
            WriteLiteral(@"

<center><h2>Remaining Leave Days</h2></center>



<div class=""card shadow mb-4"">
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>Leave Category</th>
                        <th>Total Days</th>
                        <th>Taken Leave Days</th>
                        <th>Remaining Dyas</th>
                    </tr>
                </thead>

                <tbody>

");
            EndContext();
#line 28 "H:\Project\Check\HRM\HR Management System\Pages\EmployeePages\Remain_leave.cshtml"
                     if (Model.LeaveCategoryRemainingDaysCollection != null)
                    {
                        if (Model.LeaveCategoryRemainingDaysCollection.Count > 0)
                        {

                            foreach (var item in Model.LeaveCategoryRemainingDaysCollection)
                            {

#line default
#line hidden
            BeginContext(1061, 77, true);
            WriteLiteral("                                <tr>\n                                    <td>");
            EndContext();
            BeginContext(1139, 17, false);
#line 36 "H:\Project\Check\HRM\HR Management System\Pages\EmployeePages\Remain_leave.cshtml"
                                   Write(item.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(1156, 46, true);
            WriteLiteral("</td>\n                                    <td>");
            EndContext();
            BeginContext(1203, 14, false);
#line 37 "H:\Project\Check\HRM\HR Management System\Pages\EmployeePages\Remain_leave.cshtml"
                                   Write(item.TotalDays);

#line default
#line hidden
            EndContext();
            BeginContext(1217, 46, true);
            WriteLiteral("</td>\n                                    <td>");
            EndContext();
            BeginContext(1264, 13, false);
#line 38 "H:\Project\Check\HRM\HR Management System\Pages\EmployeePages\Remain_leave.cshtml"
                                   Write(item.UsedDays);

#line default
#line hidden
            EndContext();
            BeginContext(1277, 46, true);
            WriteLiteral("</td>\n                                    <td>");
            EndContext();
            BeginContext(1324, 50, false);
#line 39 "H:\Project\Check\HRM\HR Management System\Pages\EmployeePages\Remain_leave.cshtml"
                                   Write(Model.RemainingDays(item.TotalDays, item.UsedDays));

#line default
#line hidden
            EndContext();
            BeginContext(1374, 81, true);
            WriteLiteral("</td>\n                                    \n                                </tr>\n");
            EndContext();
#line 42 "H:\Project\Check\HRM\HR Management System\Pages\EmployeePages\Remain_leave.cshtml"
                            }
                        }
                    }

#line default
#line hidden
            BeginContext(1533, 82, true);
            WriteLiteral("\n                </tbody>\n\n\n            </table>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HR_Management_System.Pages.EmployeePages.Remain_leaveModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.EmployeePages.Remain_leaveModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.EmployeePages.Remain_leaveModel>)PageContext?.ViewData;
        public HR_Management_System.Pages.EmployeePages.Remain_leaveModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
