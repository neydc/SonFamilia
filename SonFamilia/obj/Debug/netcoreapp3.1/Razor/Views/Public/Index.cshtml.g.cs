#pragma checksum "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b69daa7857418c450c431191329c78605fcc894"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Public_Index), @"mvc.1.0.view", @"/Views/Public/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b69daa7857418c450c431191329c78605fcc894", @"/Views/Public/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9350116f029f0e5aaad6a144f285542ddd80731", @"/Views/_ViewImports.cshtml")]
    public class Views_Public_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Index.cshtml"
  
    ViewData["Title"] = "Publicación";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"ftco-section bg-light\">\r\n    <div class=\"container\">\r\n        <div class=\"row d-flex\">\r\n            <div class=\"col-lg-12 text-right\">\r\n                <a class=\"btn btn-primary\" href=\"/public/crear\">Crear Post</a>\r\n            </div>\r\n");
#nullable restore
#line 12 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 d-flex ftco-animate\">\r\n                    <div class=\"blog-entry align-self-stretch\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 511, "\"", 545, 2);
            WriteAttributeValue("", 518, "/public/detalle?id=", 518, 19, true);
#nullable restore
#line 16 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Index.cshtml"
WriteAttributeValue("", 537, item.Id, 537, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"block-20 rounded\"");
            BeginWriteAttribute("style", " style=\"", 571, "\"", 624, 4);
            WriteAttributeValue("", 579, "background-image:", 579, 17, true);
            WriteAttributeValue(" ", 596, "url(\'images/", 597, 13, true);
#nullable restore
#line 16 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Index.cshtml"
WriteAttributeValue("", 609, item.Imagen, 609, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 621, "\');", 621, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </a>\r\n                        <div class=\"text p-4\">\r\n                            <div class=\"meta mb-2\">\r\n                                <span class=\"excerpt d-block\">");
#nullable restore
#line 20 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Index.cshtml"
                                                         Write(item.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <div><a href=\"#\">");
#nullable restore
#line 21 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Index.cshtml"
                                            Write(item.FechaRegistro.ToString("d,M,yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n");
            WriteLiteral("                                <div><a href=\"#\">");
#nullable restore
#line 23 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Index.cshtml"
                                            Write(item.Usuario.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                            </div>\r\n                            <span class=\" d-block\">");
#nullable restore
#line 25 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Index.cshtml"
                                              Write(item.Descripcion.Substring(0, 30));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</span>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1266, "\"", 1300, 2);
            WriteAttributeValue("", 1273, "/public/detalle?id=", 1273, 19, true);
#nullable restore
#line 26 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Index.cshtml"
WriteAttributeValue("", 1292, item.Id, 1292, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary d-block px-2 py-3\">Ver más</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1387, "\"", 1422, 2);
            WriteAttributeValue("", 1394, "/public/eliminar?id=", 1394, 20, true);
#nullable restore
#line 27 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Index.cshtml"
WriteAttributeValue("", 1414, item.Id, 1414, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary d-block px-2 py-3\">Eliminar</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 31 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div class=""row mt-5"">
            <div class=""col text-center"">
                <div class=""block-27"">
                    <ul>
                        <li><a href=""#"">&lt;</a></li>
                        <li class=""active""><span>1</span></li>
                        <li><a href=""#"">2</a></li>
                        <li><a href=""#"">3</a></li>
                        <li><a href=""#"">4</a></li>
                        <li><a href=""#"">5</a></li>
                        <li><a href=""#"">&gt;</a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>

");
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
