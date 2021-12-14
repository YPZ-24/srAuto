#pragma checksum "C:\Users\DELL\Desktop\SrAuto\Views\Config\Fixes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21eafd1447559fe5b0df75ccf0742d9d83a36b29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Config_Fixes), @"mvc.1.0.view", @"/Views/Config/Fixes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21eafd1447559fe5b0df75ccf0742d9d83a36b29", @"/Views/Config/Fixes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32e69c13948662ff2d3868e9c487c07ace6955c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Config_Fixes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Fix>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CreateFixModal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n\r\n    <h2 class=\"my-5 banner-title text-center\">ARREGLOS</h2>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "21eafd1447559fe5b0df75ccf0742d9d83a36b293382", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <button class=""btn btn-light mb-4 btn-block mt-3"" data-toggle=""modal"" data-target=""#createFixModal"">NUEVO</button>

    <table class=""table table-sm text-center table-light"">
        <thead class=""thead-dark"">
            <tr>
                <th></th>
                <th></th>
                <th>FIX</th>
                <th>PRICE</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 20 "C:\Users\DELL\Desktop\SrAuto\Views\Config\Fixes.cshtml"
             foreach (var f in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 23 "C:\Users\DELL\Desktop\SrAuto\Views\Config\Fixes.cshtml"
                    Write(
                            await Html.PartialAsync("_GenericDeleteModal",
                                new ViewDataDictionary(ViewData){
                                    { "modalId", @f.FixID },
                                    { "modalNameId", "FixID" },
                                    { "modalTitle", "¿Seguro que desea eliminar este Arreglo?" },
                                    { "modalFormAction", "Delete" },
                                    { "modalFormController", "Fix" }
                                }
                            )
                        );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <button class=\"btn\" data-toggle=\"modal\" data-target=\"#genericDeleteModal-");
#nullable restore
#line 34 "C:\Users\DELL\Desktop\SrAuto\Views\Config\Fixes.cshtml"
                                                                                            Write(f.FixID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            <i class=\"bi bi-trash-fill\"></i>\r\n                        </button>\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 39 "C:\Users\DELL\Desktop\SrAuto\Views\Config\Fixes.cshtml"
                   Write(await Html.PartialAsync("_UpdateFixModal", f));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <button class=\"btn\" data-toggle=\"modal\" data-target=\"#updateFixModal-");
#nullable restore
#line 40 "C:\Users\DELL\Desktop\SrAuto\Views\Config\Fixes.cshtml"
                                                                                        Write(f.FixID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            <i class=\"bi bi-pen-fill\"></i>\r\n                        </button>\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\DELL\Desktop\SrAuto\Views\Config\Fixes.cshtml"
                   Write(f.fix);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\DELL\Desktop\SrAuto\Views\Config\Fixes.cshtml"
                   Write(f.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 47 "C:\Users\DELL\Desktop\SrAuto\Views\Config\Fixes.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n\r\n<!--Modal Info-->\r\n");
#nullable restore
#line 52 "C:\Users\DELL\Desktop\SrAuto\Views\Config\Fixes.cshtml"
Write(await Html.PartialAsync("_InfoModal"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n");
#nullable restore
#line 55 "C:\Users\DELL\Desktop\SrAuto\Views\Config\Fixes.cshtml"
          
            if (ViewData["showInfoModal"] == null){ ViewData["showInfoModal"] = "hide"; }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("        $(\'#InfoModal\').modal(\'");
#nullable restore
#line 58 "C:\Users\DELL\Desktop\SrAuto\Views\Config\Fixes.cshtml"
                          Write(ViewData["showInfoModal"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\')\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Fix>> Html { get; private set; }
    }
}
#pragma warning restore 1591
