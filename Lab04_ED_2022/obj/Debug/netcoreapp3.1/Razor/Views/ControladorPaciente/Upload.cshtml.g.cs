#pragma checksum "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\ControladorPaciente\Upload.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b22708c2a7ac8f1422b8af58338419e7f5ff9682"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ControladorPaciente_Upload), @"mvc.1.0.view", @"/Views/ControladorPaciente/Upload.cshtml")]
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
#line 1 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\_ViewImports.cshtml"
using Lab04_ED_2022;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\_ViewImports.cshtml"
using Lab04_ED_2022.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b22708c2a7ac8f1422b8af58338419e7f5ff9682", @"/Views/ControladorPaciente/Upload.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8106a9cf53e6ee52aa43ae5b087dc4311a323ebe", @"/Views/_ViewImports.cshtml")]
    public class Views_ControladorPaciente_Upload : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lab04_ED_2022.Models.ModeloPaciente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\ControladorPaciente\Upload.cshtml"
  
    ViewData["Title"] = "Upload";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Upload</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b22708c2a7ac8f1422b8af58338419e7f5ff96823803", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\ControladorPaciente\Upload.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\ControladorPaciente\Upload.cshtml"
           Write(Html.DisplayNameFor(model => model.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\ControladorPaciente\Upload.cshtml"
           Write(Html.DisplayNameFor(model => model.Genero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\ControladorPaciente\Upload.cshtml"
           Write(Html.DisplayNameFor(model => model.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\ControladorPaciente\Upload.cshtml"
           Write(Html.DisplayNameFor(model => model.Especializacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\ControladorPaciente\Upload.cshtml"
           Write(Html.DisplayNameFor(model => model.Ingreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\ControladorPaciente\Upload.cshtml"
           Write(Html.DisplayNameFor(model => model.Prioridad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\ControladorPaciente\Upload.cshtml"
           Write(Html.DisplayNameFor(model => model.Hora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\ControladorPaciente\Upload.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaDeNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 46 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\ControladorPaciente\Upload.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\ControladorPaciente\Upload.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\ControladorPaciente\Upload.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\ControladorPaciente\Upload.cshtml"
           Write(Html.DisplayFor(modelItem => item.Genero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\ControladorPaciente\Upload.cshtml"
           Write(Html.DisplayFor(modelItem => item.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\ControladorPaciente\Upload.cshtml"
           Write(Html.DisplayFor(modelItem => item.Especializacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\ControladorPaciente\Upload.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ingreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\ControladorPaciente\Upload.cshtml"
           Write(Html.DisplayFor(modelItem => item.Prioridad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\ControladorPaciente\Upload.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\ControladorPaciente\Upload.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaDeNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\ControladorPaciente\Upload.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 77 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\ControladorPaciente\Upload.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 78 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\ControladorPaciente\Upload.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 81 "C:\Users\megan\Desktop\ProyectosE\Lab04_ED_2022\Lab04_ED_2022\Views\ControladorPaciente\Upload.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lab04_ED_2022.Models.ModeloPaciente>> Html { get; private set; }
    }
}
#pragma warning restore 1591