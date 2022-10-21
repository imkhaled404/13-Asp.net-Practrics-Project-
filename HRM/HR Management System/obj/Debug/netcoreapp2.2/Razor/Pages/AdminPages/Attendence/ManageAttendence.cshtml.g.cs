#pragma checksum "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Attendence\ManageAttendence.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "058f3779c4e5b4435d1ce83f3586f85e65eed17f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_AdminPages_Attendence_ManageAttendence), @"mvc.1.0.razor-page", @"/Pages/AdminPages/Attendence/ManageAttendence.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/AdminPages/Attendence/ManageAttendence.cshtml", typeof(AspNetCore.Pages_AdminPages_Attendence_ManageAttendence), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"058f3779c4e5b4435d1ce83f3586f85e65eed17f", @"/Pages/AdminPages/Attendence/ManageAttendence.cshtml")]
    public class Pages_AdminPages_Attendence_ManageAttendence : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::HR_Management_System.TagHelpers.EmpAttendance __HR_Management_System_TagHelpers_EmpAttendance;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Attendence\ManageAttendence.cshtml"
  
    ViewData["Title"] = "ManageAttendence";
    Layout = "~/Views/Shared/_AdminDashboardLayout.cshtml";

#line default
#line hidden
            BeginContext(171, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(263, 46, true);
            WriteLiteral("\n\n\n\n<center><h1>Set Attendence</h1></center>\n\n");
            EndContext();
#line 16 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Attendence\ManageAttendence.cshtml"
 if (Model.TodayIsHoliDay != true)
{

#line default
#line hidden
            BeginContext(346, 641, true);
            WriteLiteral(@"    <div class=""wrap-fpanel"">
        <div class=""row"">
            <div class=""col-sm-12"" data-offset=""0"">
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <div class=""panel-title"">
                            <strong>List of Employees</strong>
                        </div>
                    </div>

                    <div class=""card shadow mb-4 mt-2"">

                        <div class=""card-header"">
                            <div class=""d-flex flex-row mb-0"">
                                <p>Date:</p>
                                <p class=""ml-2"">");
            EndContext();
            BeginContext(988, 32, false);
#line 33 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Attendence\ManageAttendence.cshtml"
                                           Write(DateTime.Now.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1020, 900, true);
            WriteLiteral(@"</p>
                            </div>
                        </div>


                        <div class=""card-body"">
                            <div class=""table-responsive"">
                                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                                    <thead>
                                        <tr role=""row"">
                                            <th>Emp ID</th>
                                            <th>Emp Name</th>
                                            <th>Department</th>
                                            <th>Designation</th>
                                            <th>Status</th>
                                            <th>Action</th>
                                        </tr>
                                    </thead>
                                    <tbody>

");
            EndContext();
#line 53 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Attendence\ManageAttendence.cshtml"
                                         if (Model.SortedEmployees != null)
                                        {
                                            if (Model.SortedEmployees.Count > 0)
                                            {
                                                for (int i = 0; i < Model.SortedEmployees.Count; i++)
                                                {

#line default
#line hidden
            BeginContext(2317, 147, true);
            WriteLiteral("                                                    <tr class=\"odd\">\n                                                        <td class=\"sorting_1\">");
            EndContext();
            BeginContext(2465, 27, false);
#line 60 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Attendence\ManageAttendence.cshtml"
                                                                         Write(Model.SortedEmployees[i].Id);

#line default
#line hidden
            EndContext();
            BeginContext(2492, 66, true);
            WriteLiteral("</td>\n                                                        <td>");
            EndContext();
            BeginContext(2559, 29, false);
#line 61 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Attendence\ManageAttendence.cshtml"
                                                       Write(Model.SortedEmployees[i].Name);

#line default
#line hidden
            EndContext();
            BeginContext(2588, 66, true);
            WriteLiteral("</td>\n                                                        <td>");
            EndContext();
            BeginContext(2655, 35, false);
#line 62 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Attendence\ManageAttendence.cshtml"
                                                       Write(Model.SortedEmployees[i].Department);

#line default
#line hidden
            EndContext();
            BeginContext(2690, 66, true);
            WriteLiteral("</td>\n                                                        <td>");
            EndContext();
            BeginContext(2757, 36, false);
#line 63 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Attendence\ManageAttendence.cshtml"
                                                       Write(Model.SortedEmployees[i].Designation);

#line default
#line hidden
            EndContext();
            BeginContext(2793, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 64 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Attendence\ManageAttendence.cshtml"
                                                          
                                                            var t = DateTime.Today;
                                                            var att = Model.SortedEmployees[i].Attendances.SingleOrDefault(a => a.Month == t.Month && a.Year == a.Year && a.Day == t.Day);

                                                            if (att == null)
                                                            {

#line default
#line hidden
            BeginContext(3269, 84, true);
            WriteLiteral("                                                                <td>No Defined</td>\n");
            EndContext();
#line 71 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Attendence\ManageAttendence.cshtml"
                                                            }
                                                            else
                                                            {

#line default
#line hidden
            BeginContext(3542, 68, true);
            WriteLiteral("                                                                <td>");
            EndContext();
            BeginContext(3611, 21, false);
#line 74 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Attendence\ManageAttendence.cshtml"
                                                               Write(att.Status.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(3632, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 75 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Attendence\ManageAttendence.cshtml"
                                                            }

                                                        

#line default
#line hidden
            BeginContext(3759, 121, true);
            WriteLiteral("                                                        <td>\n                                                            ");
            EndContext();
            BeginContext(3880, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("emp-attendance", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "058f3779c4e5b4435d1ce83f3586f85e65eed17f10431", async() => {
            }
            );
            __HR_Management_System_TagHelpers_EmpAttendance = CreateTagHelper<global::HR_Management_System.TagHelpers.EmpAttendance>();
            __tagHelperExecutionContext.Add(__HR_Management_System_TagHelpers_EmpAttendance);
#line 79 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Attendence\ManageAttendence.cshtml"
__HR_Management_System_TagHelpers_EmpAttendance.Id = Model.SortedEmployees[i].Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("id", __HR_Management_System_TagHelpers_EmpAttendance.Id, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3947, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(4390, 120, true);
            WriteLiteral("                                                        </td>\n                                                    </tr>\n");
            EndContext();
#line 86 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Attendence\ManageAttendence.cshtml"
                                                }
                                            }
                                        }

#line default
#line hidden
            BeginContext(4648, 247, true);
            WriteLiteral("                                    </tbody>\n                                </table>\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n");
            EndContext();
#line 98 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Attendence\ManageAttendence.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(4904, 60, true);
            WriteLiteral("    <center class=\"mt-5\"><h1>Today is Holiday</h1></center>\n");
            EndContext();
#line 102 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Attendence\ManageAttendence.cshtml"
}

#line default
#line hidden
            BeginContext(4966, 1090, true);
            WriteLiteral(@"




<script>

    function SetAttendance(id, status, link_control) {


        $.ajax({
            url: ""https://localhost:44303/emp/presentabsentemployeeasync?"" + `id=${id}` + `&status=${status}`, success: function (data, result) {
                //alert(data);
                if (data == ""present"") {

                    var gg = link_control.parentElement;
                    gg = gg.parentElement;
                    gg = gg.previousElementSibling;

                    gg.innerText = ""Present""

                }
                else if (data == ""absent"") {
                    var gg = link_control.parentElement;
                    gg = gg.parentElement;
                    gg = gg.previousElementSibling;

                    gg.innerText = ""Absent""
                }
                else if (data == ""holiday"") {
                    var gg = link_control.parentElement;
                    gg = gg.parentElement;
                    gg = gg.previousElementSibling;

                    gg.innerText = ""Holi");
            WriteLiteral("day\"\n                }\n            }\n        });\n    }\n\n</script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HR_Management_System.Pages.ManageAttendenceModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.ManageAttendenceModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.ManageAttendenceModel>)PageContext?.ViewData;
        public HR_Management_System.Pages.ManageAttendenceModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591