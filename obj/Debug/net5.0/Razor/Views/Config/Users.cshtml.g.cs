#pragma checksum "C:\Users\DELL\Desktop\SrAuto\Views\Config\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c96a41d615a11955bcfef41b4c8a4967425ba166"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Config_Users), @"mvc.1.0.view", @"/Views/Config/Users.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c96a41d615a11955bcfef41b4c8a4967425ba166", @"/Views/Config/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32e69c13948662ff2d3868e9c487c07ace6955c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Config_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CreateUserModal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div>\r\n\r\n    <h2 class=\"my-5 banner-title text-center\">USUARIOS</h2>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c96a41d615a11955bcfef41b4c8a4967425ba1663384", async() => {
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
    <button class=""btn btn-light mb-4 btn-block mt-3"" data-toggle=""modal"" data-target=""#createUserModal"">NUEVO</button>

    <table class=""table table-sm text-center table-light"">
        <thead class=""thead-dark"">
            <tr>
                <th></th>
                <th></th>
                <th>CORREO</th>
                <th>CONTRASEÑA</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 20 "C:\Users\DELL\Desktop\SrAuto\Views\Config\Users.cshtml"
             foreach (var u in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 23 "C:\Users\DELL\Desktop\SrAuto\Views\Config\Users.cshtml"
                    Write(
                            await Html.PartialAsync("_GenericDeleteModal",
                                new ViewDataDictionary(ViewData){
                                    { "modalId", @u.UserID },
                                    { "modalNameId", "UserID" },
                                    { "modalTitle", "¿Seguro que desea eliminar este Usuario?" },
                                    { "modalFormAction", "Delete" },
                                    { "modalFormController", "User" }
                                }
                            )
                        );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <button class=\"btn\" data-toggle=\"modal\" data-target=\"#genericDeleteModal-");
#nullable restore
#line 34 "C:\Users\DELL\Desktop\SrAuto\Views\Config\Users.cshtml"
                                                                                            Write(u.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            <i class=\"bi bi-trash-fill\"></i>\r\n                        </button>\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 39 "C:\Users\DELL\Desktop\SrAuto\Views\Config\Users.cshtml"
                   Write(await Html.PartialAsync("_UpdateUserModal", u));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <button class=\"btn\" data-toggle=\"modal\" data-target=\"#updateUserModal-");
#nullable restore
#line 40 "C:\Users\DELL\Desktop\SrAuto\Views\Config\Users.cshtml"
                                                                                         Write(u.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            <i class=\"bi bi-pen-fill\"></i>\r\n                        </button>\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\DELL\Desktop\SrAuto\Views\Config\Users.cshtml"
                   Write(u.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\DELL\Desktop\SrAuto\Views\Config\Users.cshtml"
                   Write(u.pass);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 47 "C:\Users\DELL\Desktop\SrAuto\Views\Config\Users.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<!--Modal Info-->\r\n");
#nullable restore
#line 53 "C:\Users\DELL\Desktop\SrAuto\Views\Config\Users.cshtml"
Write(await Html.PartialAsync("_InfoModal"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n");
#nullable restore
#line 56 "C:\Users\DELL\Desktop\SrAuto\Views\Config\Users.cshtml"
          
            if (ViewData["showInfoModal"] == null){ ViewData["showInfoModal"] = "hide"; }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("        $(\'#InfoModal\').modal(\'");
#nullable restore
#line 59 "C:\Users\DELL\Desktop\SrAuto\Views\Config\Users.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
