#pragma checksum "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Employee\AddAsEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca7e834d1ecca0a0cd3fe0394cb6c75f470494bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_AdminPages_Employee_AddAsEmployee), @"mvc.1.0.razor-page", @"/Pages/AdminPages/Employee/AddAsEmployee.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/AdminPages/Employee/AddAsEmployee.cshtml", typeof(AspNetCore.Pages_AdminPages_Employee_AddAsEmployee), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca7e834d1ecca0a0cd3fe0394cb6c75f470494bf", @"/Pages/AdminPages/Employee/AddAsEmployee.cshtml")]
    public class Pages_AdminPages_Employee_AddAsEmployee : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal form-groups-bordered"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Employee\AddAsEmployee.cshtml"
  
    ViewData["Title"] = "AddAsEmployee";
    Layout = "~/Views/Shared/_AdminDashboardLayout.cshtml";

#line default
#line hidden
            BeginContext(276, 164, true);
            WriteLiteral("\n\n\n<center><h2>Add Employee</h2></center>\n\n\n<div class=\"card shadow mb-4\">\n    <div class=\"card-header py-3\">\n        <h6 class=\"m-0 font-weight-bold text-primary\">");
            EndContext();
            BeginContext(441, 20, false);
#line 17 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Employee\AddAsEmployee.cshtml"
                                                 Write(Model.Applicant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(461, 6, true);
            WriteLiteral(", ID: ");
            EndContext();
            BeginContext(468, 18, false);
#line 17 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Employee\AddAsEmployee.cshtml"
                                                                            Write(Model.Applicant.Id);

#line default
#line hidden
            EndContext();
            BeginContext(486, 172, true);
            WriteLiteral("</h6>\n    </div>\n    <div class=\"card-body\">\n\n\n\n\n        <div class=\"d-flex flex-column\" >\n            <div class=\"col-lg-4\">\n                <div>\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 658, "\"", 707, 1);
#line 27 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Employee\AddAsEmployee.cshtml"
WriteAttributeValue("", 664, Model.ImgSrc(Model.Applicant.ProfileImage), 664, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(708, 202, true);
            WriteLiteral(" class=\"shadow img-profile rounded-circle\" style=\"border:solid white 4px; object-fit:cover;\" alt=\"Alternate Text\" width=\"150\" height=\"150\"/>\n                </div>\n                <h4 class=\"mt-4 mb-4\">");
            EndContext();
            BeginContext(911, 20, false);
#line 29 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Employee\AddAsEmployee.cshtml"
                                 Write(Model.Applicant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(931, 130, true);
            WriteLiteral("</h4>\n                <div class=\"d-flex flex-row\">\n                    <h5>Department:</h5>\n\n                    <p class=\"ml-2\">");
            EndContext();
            BeginContext(1062, 26, false);
#line 33 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Employee\AddAsEmployee.cshtml"
                               Write(Model.Applicant.Department);

#line default
#line hidden
            EndContext();
            BeginContext(1088, 154, true);
            WriteLiteral("</p>\n                </div>\n\n                <div class=\"d-flex flex-row\">\n                    <h5>Designation:</h5>\n\n                    <p class=\"ml-2\">");
            EndContext();
            BeginContext(1243, 27, false);
#line 39 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Employee\AddAsEmployee.cshtml"
                               Write(Model.Applicant.Designation);

#line default
#line hidden
            EndContext();
            BeginContext(1270, 103, true);
            WriteLiteral("</p>\n                </div>\n\n\n            </div>\n\n\n\n            <div class=\"col-lg-3\">\n                ");
            EndContext();
            BeginContext(1373, 1590, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca7e834d1ecca0a0cd3fe0394cb6c75f470494bf9255", async() => {
                BeginContext(1450, 39, true);
                WriteLiteral("\n                    <input type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1489, "\"", 1516, 1);
#line 49 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Employee\AddAsEmployee.cshtml"
WriteAttributeValue("", 1497, Model.Applicant.Id, 1497, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1517, 250, true);
                WriteLiteral(" hidden name=\"id\" />\n                    <div class=\"form-group\">\n                        <label class=\"control-label\">Joining Date<span class=\"required\" aria-required=\"true\">*</span></label>\n                        <div>\n                            ");
                EndContext();
                BeginContext(1767, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ca7e834d1ecca0a0cd3fe0394cb6c75f470494bf10375", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 53 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Employee\AddAsEmployee.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.JoiningDate);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1829, 36, true);
                WriteLiteral("\n                            <small>");
                EndContext();
                BeginContext(1865, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca7e834d1ecca0a0cd3fe0394cb6c75f470494bf12331", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 54 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Employee\AddAsEmployee.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.JoiningDate);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1931, 294, true);
                WriteLiteral(@"</small>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label class=""control-label"">Username <span class=""required"" aria-required=""true"">*</span></label>
                        <div>
                            ");
                EndContext();
                BeginContext(2225, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ca7e834d1ecca0a0cd3fe0394cb6c75f470494bf14413", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 61 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Employee\AddAsEmployee.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Username);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2284, 37, true);
                WriteLiteral("\n                            <small> ");
                EndContext();
                BeginContext(2321, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca7e834d1ecca0a0cd3fe0394cb6c75f470494bf16367", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 62 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Employee\AddAsEmployee.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Username);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2384, 9, true);
                WriteLiteral("</small>\n");
                EndContext();
#line 63 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Employee\AddAsEmployee.cshtml"
                             if (Model.UsernameExisted == true)
                            {

#line default
#line hidden
                BeginContext(2487, 121, true);
                WriteLiteral("                                <small> <span class=\"text-danger\">Username existed. Try another username.</span></small>\n");
                EndContext();
#line 66 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Employee\AddAsEmployee.cshtml"
                            }

#line default
#line hidden
                BeginContext(2638, 318, true);
                WriteLiteral(@"
                        </div>
                    </div>

                    <div class=""form-group"">
                        <div>
                            <button type=""submit"" id=""sbtn"" class=""btn btn-primary"">Add as Employee</button>
                        </div>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2963, 59, true);
            WriteLiteral("\n            </div>\n\n        </div>\n    </div>\n</div>\n\n\n\n\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3040, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 88 "H:\Project\Check\HRM\HR Management System\Pages\AdminPages\Employee\AddAsEmployee.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HR_Management_System.Pages.AdminPages.Employee.AddAsEmployeeModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.AdminPages.Employee.AddAsEmployeeModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.AdminPages.Employee.AddAsEmployeeModel>)PageContext?.ViewData;
        public HR_Management_System.Pages.AdminPages.Employee.AddAsEmployeeModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
