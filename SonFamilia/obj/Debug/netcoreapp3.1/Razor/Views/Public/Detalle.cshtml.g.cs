#pragma checksum "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Detalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bc8754324eef3451e1182df8d7b16dfb643504e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Public_Detalle), @"mvc.1.0.view", @"/Views/Public/Detalle.cshtml")]
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
#line 1 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\_ViewImports.cshtml"
using SonFamilia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\_ViewImports.cshtml"
using SonFamilia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bc8754324eef3451e1182df8d7b16dfb643504e", @"/Views/Public/Detalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9350116f029f0e5aaad6a144f285542ddd80731", @"/Views/_ViewImports.cshtml")]
    public class Views_Public_Detalle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("160px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Detalle.cshtml"
  
    ViewData["Title"] = "Detalle";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"ftco-section bg-light\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12\">\r\n                <h4 class=\"excerpt d-block text-center\">");
#nullable restore
#line 10 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Detalle.cshtml"
                                                   Write(Model.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>

            </div>
            <div style=""box-shadow: 2px 2px 2px 2px rgba(0, 0, 0, 0.2); "" class=""ftco-animate col-lg-12"">

                <div class=""row  align-items-center justify-content-center"">
                    <div class=""col-lg-6 text-center "">
");
#nullable restore
#line 17 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Detalle.cshtml"
                         foreach (var imagencita in ViewBag.listimagenes)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6bc8754324eef3451e1182df8d7b16dfb643504e4746", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 677, "~/images/", 677, 9, true);
#nullable restore
#line 19 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Detalle.cshtml"
AddHtmlAttributeValue("", 686, imagencita.ImagenUrl, 686, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 19 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Detalle.cshtml"
AddHtmlAttributeValue("", 714, imagencita.ImagenUrl, 714, 21, false);

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
            WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Detalle.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"col-lg-6 \">\r\n                        <a>Publicado el ");
#nullable restore
#line 23 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Detalle.cshtml"
                                   Write(Model.FechaRegistro.ToString("dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <a> de ");
#nullable restore
#line 24 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Detalle.cshtml"
                          Write(Model.FechaRegistro.ToString("MM"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                        <a> del año ");
#nullable restore
#line 25 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Detalle.cshtml"
                               Write(Model.FechaRegistro.ToString("yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" por: ");
#nullable restore
#line 25 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Detalle.cshtml"
                                                                          Write(Model.Usuario.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                        <hr />\r\n                        <h6>Descripción</h6>\r\n                        <span class=\"d-block\">");
#nullable restore
#line 28 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Detalle.cshtml"
                                         Write(Model.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </div>
                </div>
            </div>
            <a href=""/public"" class=""btn text-right"">Volver</a>
        </div>
    </div>
</section>
<div class=""container"">
    <div class=""row"">
       
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
