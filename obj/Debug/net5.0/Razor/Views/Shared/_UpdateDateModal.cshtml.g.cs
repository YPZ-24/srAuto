#pragma checksum "C:\Users\DELL\Desktop\SrAuto\Views\Shared\_UpdateDateModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58ab813f16485dbedad34a827b59ff35ec4f5f7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__UpdateDateModal), @"mvc.1.0.view", @"/Views/Shared/_UpdateDateModal.cshtml")]
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
#line 1 "C:\Users\DELL\Desktop\SrAuto\Views\_ViewImports.cshtml"
using SrAuto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Desktop\SrAuto\Views\_ViewImports.cshtml"
using SrAuto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58ab813f16485dbedad34a827b59ff35ec4f5f7f", @"/Views/Shared/_UpdateDateModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32e69c13948662ff2d3868e9c487c07ace6955c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__UpdateDateModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Date>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DateFix", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Pay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\DELL\Desktop\SrAuto\Views\Shared\_UpdateDateModal.cshtml"
    double total = 0;
    string displayPayButton = @Model.status == 1 ? "bloc" : "none";
    string displayFormDateFix = @Model.status == 1 ? "bloc" : "none";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 212, "\"", 246, 2);
            WriteAttributeValue("", 217, "updateDateModal-", 217, 16, true);
#nullable restore
#line 8 "C:\Users\DELL\Desktop\SrAuto\Views\Shared\_UpdateDateModal.cshtml"
WriteAttributeValue("", 233, Model.DateID, 233, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"modal-dialog modal-lg\">\r\n        <div class=\"modal-content modal-container\">\r\n            <div class=\"modal-header border-0\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-12\">\r\n                        <h4>");
#nullable restore
#line 14 "C:\Users\DELL\Desktop\SrAuto\Views\Shared\_UpdateDateModal.cshtml"
                       Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    </div>\r\n                    <div class=\"col-12\">\r\n                        <h6>");
#nullable restore
#line 17 "C:\Users\DELL\Desktop\SrAuto\Views\Shared\_UpdateDateModal.cshtml"
                       Write(Model.datet.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    </div>\r\n                    <div class=\"col-12\">\r\n                        <p>");
#nullable restore
#line 20 "C:\Users\DELL\Desktop\SrAuto\Views\Shared\_UpdateDateModal.cshtml"
                      Write(Model.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"modal-body modal-body-inputs\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58ab813f16485dbedad34a827b59ff35ec4f5f7f7232", async() => {
                WriteLiteral("\r\n                    <table class=\"table table-sm table-borderless m-0\">\r\n                        <tbody>\r\n                            <tr>\r\n                                <input type=\"hidden\" name=\"DateID\"");
                BeginWriteAttribute("value", " value=\"", 1231, "\"", 1252, 1);
#nullable restore
#line 29 "C:\Users\DELL\Desktop\SrAuto\Views\Shared\_UpdateDateModal.cshtml"
WriteAttributeValue("", 1239, Model.DateID, 1239, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <td>\r\n                                    <select name=\"FixID\" class=\"custom-select\" onchange=\"document.querySelector(\'#inFixCost\').value = 20\">\r\n");
#nullable restore
#line 32 "C:\Users\DELL\Desktop\SrAuto\Views\Shared\_UpdateDateModal.cshtml"
                                         foreach (Fix f in (List<Fix>) ViewData["fixes"]){

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58ab813f16485dbedad34a827b59ff35ec4f5f7f8587", async() => {
                    WriteLiteral("\r\n                                                $");
#nullable restore
#line 34 "C:\Users\DELL\Desktop\SrAuto\Views\Shared\_UpdateDateModal.cshtml"
                                             Write(f.price);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" - ");
#nullable restore
#line 34 "C:\Users\DELL\Desktop\SrAuto\Views\Shared\_UpdateDateModal.cshtml"
                                                          Write(f.fix);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\DELL\Desktop\SrAuto\Views\Shared\_UpdateDateModal.cshtml"
                                               WriteLiteral(f.FixID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 36 "C:\Users\DELL\Desktop\SrAuto\Views\Shared\_UpdateDateModal.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </select>
                                </td>
                                <td>
                                    <input type=""number"" name=""extraCost"" placeholder=""Extra"" class=""form-control"">
                                </td>
                                <td>
                                    <button type=""submit"" class=""btn btn-dark"">
                                        <i class=""bi bi-send-fill""></i>
                                    </button>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 993, "display:", 993, 8, true);
#nullable restore
#line 25 "C:\Users\DELL\Desktop\SrAuto\Views\Shared\_UpdateDateModal.cshtml"
AddHtmlAttributeValue(" ", 1001, displayFormDateFix, 1002, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <table class=""table table-sm text-center table-light"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th></th>
                            <th>ARREGLO</th>
                            <th>COSTO</th>
                            <th>EXTRA</th>
                            <th>TOTAL</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 62 "C:\Users\DELL\Desktop\SrAuto\Views\Shared\_UpdateDateModal.cshtml"
                         foreach (DateFix f in (List<DateFix>) Model.DateFixes){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58ab813f16485dbedad34a827b59ff35ec4f5f7f14730", async() => {
                WriteLiteral("\r\n                                        <input type=\"hidden\" name=\"DateFixID\"");
                BeginWriteAttribute("value", " value=\"", 3242, "\"", 3262, 1);
#nullable restore
#line 66 "C:\Users\DELL\Desktop\SrAuto\Views\Shared\_UpdateDateModal.cshtml"
WriteAttributeValue("", 3250, f.DateFixID, 3250, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <button type=\"submit\" class=\"btn\">\r\n                                            <i class=\"bi bi-trash-fill\"></i>\r\n                                        </button>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                                <td>");
#nullable restore
#line 72 "C:\Users\DELL\Desktop\SrAuto\Views\Shared\_UpdateDateModal.cshtml"
                               Write(f.Fix.fix);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>$");
#nullable restore
#line 73 "C:\Users\DELL\Desktop\SrAuto\Views\Shared\_UpdateDateModal.cshtml"
                                Write(f.Fix.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>$");
#nullable restore
#line 74 "C:\Users\DELL\Desktop\SrAuto\Views\Shared\_UpdateDateModal.cshtml"
                                Write(f.extraCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 75 "C:\Users\DELL\Desktop\SrAuto\Views\Shared\_UpdateDateModal.cshtml"
                                  total = total + f.Fix.price+f.extraCost;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>$");
#nullable restore
#line 76 "C:\Users\DELL\Desktop\SrAuto\Views\Shared\_UpdateDateModal.cshtml"
                                 Write(f.Fix.price+f.extraCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 78 "C:\Users\DELL\Desktop\SrAuto\Views\Shared\_UpdateDateModal.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                    <tfoot>\r\n                        <tr>\r\n                            <td colspan=\"4\" class=\"text-right\">TOTAL</td>\r\n                            <td>");
#nullable restore
#line 83 "C:\Users\DELL\Desktop\SrAuto\Views\Shared\_UpdateDateModal.cshtml"
                           Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                    </tfoot>\r\n                </table>\r\n                \r\n            </div>\r\n            <div class=\"modal-footer border-0 modal-conte-buttons\"");
            BeginWriteAttribute("style", " style=\"", 4331, "\"", 4365, 2);
            WriteAttributeValue("", 4339, "display:", 4339, 8, true);
#nullable restore
#line 89 "C:\Users\DELL\Desktop\SrAuto\Views\Shared\_UpdateDateModal.cshtml"
WriteAttributeValue(" ", 4347, displayPayButton, 4348, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58ab813f16485dbedad34a827b59ff35ec4f5f7f20013", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"DateID\"");
                BeginWriteAttribute("value", " value=\"", 4501, "\"", 4522, 1);
#nullable restore
#line 91 "C:\Users\DELL\Desktop\SrAuto\Views\Shared\_UpdateDateModal.cshtml"
WriteAttributeValue("", 4509, Model.DateID, 4509, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <button type=\"submit\" class=\"btn btn-light btn-block\">PAGAR</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Date> Html { get; private set; }
    }
}
#pragma warning restore 1591
