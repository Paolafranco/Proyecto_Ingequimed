#pragma checksum "C:\Users\paoel\OneDrive\Escritorio\Proyecto\Proyecto_Ingequimed-Paola-Franco\Ginecologia_Ingequimed\Views\DatoPersonales\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cda00ecbc0e41184181201dd51823b5fde382031"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DatoPersonales_Delete), @"mvc.1.0.view", @"/Views/DatoPersonales/Delete.cshtml")]
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
#line 1 "C:\Users\paoel\OneDrive\Escritorio\Proyecto\Proyecto_Ingequimed-Paola-Franco\Ginecologia_Ingequimed\Views\_ViewImports.cshtml"
using Ginecologia_Ingequimed;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\paoel\OneDrive\Escritorio\Proyecto\Proyecto_Ingequimed-Paola-Franco\Ginecologia_Ingequimed\Views\_ViewImports.cshtml"
using Ginecologia_Ingequimed.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cda00ecbc0e41184181201dd51823b5fde382031", @"/Views/DatoPersonales/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8db47b89fcc310ab0791d3471a40e4d147be156", @"/Views/_ViewImports.cshtml")]
    public class Views_DatoPersonales_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ginecologia_Ingequimed.Models.DatoPersonal>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\paoel\OneDrive\Escritorio\Proyecto\Proyecto_Ingequimed-Paola-Franco\Ginecologia_Ingequimed\Views\DatoPersonales\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <h1 style=\"color:#43180E\"><font size=\"6\">Eliminar Datos</font></h1>\n<div>\n    <hr />\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 12 "C:\Users\paoel\OneDrive\Escritorio\Proyecto\Proyecto_Ingequimed-Paola-Franco\Ginecologia_Ingequimed\Views\DatoPersonales\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 15 "C:\Users\paoel\OneDrive\Escritorio\Proyecto\Proyecto_Ingequimed-Paola-Franco\Ginecologia_Ingequimed\Views\DatoPersonales\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 18 "C:\Users\paoel\OneDrive\Escritorio\Proyecto\Proyecto_Ingequimed-Paola-Franco\Ginecologia_Ingequimed\Views\DatoPersonales\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Habitos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 21 "C:\Users\paoel\OneDrive\Escritorio\Proyecto\Proyecto_Ingequimed-Paola-Franco\Ginecologia_Ingequimed\Views\DatoPersonales\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Habitos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 24 "C:\Users\paoel\OneDrive\Escritorio\Proyecto\Proyecto_Ingequimed-Paola-Franco\Ginecologia_Ingequimed\Views\DatoPersonales\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Patalogías));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 27 "C:\Users\paoel\OneDrive\Escritorio\Proyecto\Proyecto_Ingequimed-Paola-Franco\Ginecologia_Ingequimed\Views\DatoPersonales\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Patalogías));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 30 "C:\Users\paoel\OneDrive\Escritorio\Proyecto\Proyecto_Ingequimed-Paola-Franco\Ginecologia_Ingequimed\Views\DatoPersonales\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Alergias));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 33 "C:\Users\paoel\OneDrive\Escritorio\Proyecto\Proyecto_Ingequimed-Paola-Franco\Ginecologia_Ingequimed\Views\DatoPersonales\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Alergias));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 36 "C:\Users\paoel\OneDrive\Escritorio\Proyecto\Proyecto_Ingequimed-Paola-Franco\Ginecologia_Ingequimed\Views\DatoPersonales\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Embarazos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 39 "C:\Users\paoel\OneDrive\Escritorio\Proyecto\Proyecto_Ingequimed-Paola-Franco\Ginecologia_Ingequimed\Views\DatoPersonales\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Embarazos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 42 "C:\Users\paoel\OneDrive\Escritorio\Proyecto\Proyecto_Ingequimed-Paola-Franco\Ginecologia_Ingequimed\Views\DatoPersonales\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cesárea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 45 "C:\Users\paoel\OneDrive\Escritorio\Proyecto\Proyecto_Ingequimed-Paola-Franco\Ginecologia_Ingequimed\Views\DatoPersonales\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cesárea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 48 "C:\Users\paoel\OneDrive\Escritorio\Proyecto\Proyecto_Ingequimed-Paola-Franco\Ginecologia_Ingequimed\Views\DatoPersonales\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cirugías));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 51 "C:\Users\paoel\OneDrive\Escritorio\Proyecto\Proyecto_Ingequimed-Paola-Franco\Ginecologia_Ingequimed\Views\DatoPersonales\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cirugías));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cda00ecbc0e41184181201dd51823b5fde38203110194", async() => {
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cda00ecbc0e41184181201dd51823b5fde38203110459", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 56 "C:\Users\paoel\OneDrive\Escritorio\Proyecto\Proyecto_Ingequimed-Paola-Franco\Ginecologia_Ingequimed\Views\DatoPersonales\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cda00ecbc0e41184181201dd51823b5fde38203112297", async() => {
                    WriteLiteral("<font style=\"color:#424949\">Regresar</font>");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ginecologia_Ingequimed.Models.DatoPersonal> Html { get; private set; }
    }
}
#pragma warning restore 1591
