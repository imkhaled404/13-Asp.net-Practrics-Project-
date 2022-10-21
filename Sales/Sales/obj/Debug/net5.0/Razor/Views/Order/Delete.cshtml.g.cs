#pragma checksum "F:\ASP.Net Core\Project\Sales\Sales\Views\Order\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1414f2a1c14be73b1c93a40c894fdfbb95a77d41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Delete), @"mvc.1.0.view", @"/Views/Order/Delete.cshtml")]
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
#line 1 "F:\ASP.Net Core\Project\Sales\Sales\Views\_ViewImports.cshtml"
using Sales;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ASP.Net Core\Project\Sales\Sales\Views\_ViewImports.cshtml"
using Sales.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1414f2a1c14be73b1c93a40c894fdfbb95a77d41", @"/Views/Order/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8955c3f005dbc98a449f7df8e874bc009fdccd62", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sales.Models.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "F:\ASP.Net Core\Project\Sales\Sales\Views\Order\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Are you sure you want to delete this order?</h2>\n<hr />\n<table class=\"table table-bordered\">\n    <tr style=\"background-color:lightgray\">\n        <th class=\"text-center\">");
#nullable restore
#line 11 "F:\ASP.Net Core\Project\Sales\Sales\Views\Order\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n        <th class=\"text-center\">");
#nullable restore
#line 12 "F:\ASP.Net Core\Project\Sales\Sales\Views\Order\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.OrderNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n        <th class=\"text-center\">");
#nullable restore
#line 13 "F:\ASP.Net Core\Project\Sales\Sales\Views\Order\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n    </tr>\n    <tr style=\"background-color:antiquewhite\">\n        <td>");
#nullable restore
#line 16 "F:\ASP.Net Core\Project\Sales\Sales\Views\Order\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;");
#nullable restore
#line 16 "F:\ASP.Net Core\Project\Sales\Sales\Views\Order\Delete.cshtml"
                                                                Write(Html.DisplayFor(model => model.Customer.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral(",&nbsp;&nbsp;[Ph.:");
#nullable restore
#line 16 "F:\ASP.Net Core\Project\Sales\Sales\Views\Order\Delete.cshtml"
                                                                                                                                    Write(Html.DisplayFor(model => model.Customer.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("]<br />");
#nullable restore
#line 16 "F:\ASP.Net Core\Project\Sales\Sales\Views\Order\Delete.cshtml"
                                                                                                                                                                                          Write(Html.DisplayFor(model => model.Customer.City.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(", &nbsp;");
#nullable restore
#line 16 "F:\ASP.Net Core\Project\Sales\Sales\Views\Order\Delete.cshtml"
                                                                                                                                                                                                                                                     Write(Html.DisplayFor(model => model.Customer.City.Country.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td class=\"text-center\">");
#nullable restore
#line 17 "F:\ASP.Net Core\Project\Sales\Sales\Views\Order\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.OrderNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td class=\"text-center\">");
#nullable restore
#line 18 "F:\ASP.Net Core\Project\Sales\Sales\Views\Order\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
    </tr>
</table>
<h3>Order Items</h3>
<table class=""table table-bordered"">
    <tr style=""background-color:lightgray"">
        <th class=""text-center"">Product</th>
        <th class=""text-center"">Quantity</th>
        <th class=""text-center"">Unit Price</th>
        <th class=""text-center"">Total Price</th>
    </tr>
");
#nullable restore
#line 29 "F:\ASP.Net Core\Project\Sales\Sales\Views\Order\Delete.cshtml"
     for (int i = 0; i < Model.OrderItems.Count; i++)
    {
        var backgrundColor = string.Empty;
        if ((i / 2) * 2 == i)
        {
            backgrundColor = "antiquewhite";
        }
        else
        {
            backgrundColor = "bisque";
        }
        var totalId = "totalPrice" + i.ToString();
        var qtyId = "Quantity" + i.ToString();
        var untPrcId = "UnitPrice" + i.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("style", " style=\"", 1744, "\"", 1784, 2);
            WriteAttributeValue("", 1752, "background-color:", 1752, 17, true);
#nullable restore
#line 43 "F:\ASP.Net Core\Project\Sales\Sales\Views\Order\Delete.cshtml"
WriteAttributeValue("", 1769, backgrundColor, 1769, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            <td>");
#nullable restore
#line 44 "F:\ASP.Net Core\Project\Sales\Sales\Views\Order\Delete.cshtml"
           Write(Html.DisplayFor(model => model.OrderItems[i].Product.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td");
            BeginWriteAttribute("id", " id=\"", 1890, "\"", 1901, 1);
#nullable restore
#line 45 "F:\ASP.Net Core\Project\Sales\Sales\Views\Order\Delete.cshtml"
WriteAttributeValue("", 1895, qtyId, 1895, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-center\" data-tag=\"Quantity\">");
#nullable restore
#line 45 "F:\ASP.Net Core\Project\Sales\Sales\Views\Order\Delete.cshtml"
                                                               Write(Html.DisplayFor(model => model.OrderItems[i].Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td");
            BeginWriteAttribute("id", " id=\"", 2019, "\"", 2033, 1);
#nullable restore
#line 46 "F:\ASP.Net Core\Project\Sales\Sales\Views\Order\Delete.cshtml"
WriteAttributeValue("", 2024, untPrcId, 2024, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-right\" data-tag=\"UnitPrice\">");
#nullable restore
#line 46 "F:\ASP.Net Core\Project\Sales\Sales\Views\Order\Delete.cshtml"
                                                                  Write(Html.DisplayFor(model => model.OrderItems[i].UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td");
            BeginWriteAttribute("id", " id=\"", 2152, "\"", 2165, 1);
#nullable restore
#line 47 "F:\ASP.Net Core\Project\Sales\Sales\Views\Order\Delete.cshtml"
WriteAttributeValue("", 2157, totalId, 2157, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-right\" data-tag=\"sum\"></td>\n        </tr>\n");
#nullable restore
#line 49 "F:\ASP.Net Core\Project\Sales\Sales\Views\Order\Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td colspan=\"3\" class=\"text-right text-uppercase\">");
#nullable restore
#line 51 "F:\ASP.Net Core\Project\Sales\Sales\Views\Order\Delete.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.TotalAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td class=\"text-right font-weight-bolder\">");
#nullable restore
#line 52 "F:\ASP.Net Core\Project\Sales\Sales\Views\Order\Delete.cshtml"
                                             Write(Html.DisplayFor(model => model.TotalAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n</table>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1414f2a1c14be73b1c93a40c894fdfbb95a77d4112776", async() => {
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1414f2a1c14be73b1c93a40c894fdfbb95a77d4113041", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 57 "F:\ASP.Net Core\Project\Sales\Sales\Views\Order\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1414f2a1c14be73b1c93a40c894fdfbb95a77d4114806", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $(""[data-tag=sum]"").each(function (i) {
                var id = $(this).attr(""id"");
                var num = id.replace(/[^\d.-]/g, '');
                console.log(num);
                $(this).html((parseFloat($(""#Quantity"" + num).html().trim()) * parseFloat($(""#UnitPrice"" + num).html().trim())).toFixed(2));
            });
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sales.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591