#pragma checksum "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b181f6115542605ea924fae96fd2a25e870838d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b181f6115542605ea924fae96fd2a25e870838d", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9350116f029f0e5aaad6a144f285542ddd80731", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
   

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""ftco-section bg-light"">
    <div class=""container"">
        <div class=""row d-flex"">
            <div class=""col-lg-12 text-right"">
                <a class=""btn btn-primary"" href=""/public/crear"">Crear Post</a>
            </div>
");
#nullable restore
#line 13 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Dashboard\Index.cshtml"
             if (Model.Count<1)
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h4>No tiene publicaciones</h4>\r\n");
#nullable restore
#line 17 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Dashboard\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Dashboard\Index.cshtml"
             if (Model.Count >= 1)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Dashboard\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-4 d-flex ftco-animate\">\r\n                        <div class=\"blog-entry align-self-stretch\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 719, "\"", 753, 2);
            WriteAttributeValue("", 726, "/public/detalle?id=", 726, 19, true);
#nullable restore
#line 24 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 745, item.Id, 745, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"block-20 rounded\"");
            BeginWriteAttribute("style", " style=\"", 779, "\"", 832, 4);
            WriteAttributeValue("", 787, "background-image:", 787, 17, true);
            WriteAttributeValue(" ", 804, "url(\'images/", 805, 13, true);
#nullable restore
#line 24 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 817, item.Imagen, 817, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 829, "\');", 829, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </a>\r\n                            <div class=\"text p-4\">\r\n                                <div class=\"meta mb-2\">\r\n                                    <span class=\"excerpt d-block\">");
#nullable restore
#line 28 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Dashboard\Index.cshtml"
                                                             Write(item.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <div><a href=\"#\">");
#nullable restore
#line 29 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Dashboard\Index.cshtml"
                                                Write(item.FechaRegistro.ToString("d,M,yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                                </div>\r\n                                <span class=\" d-block\">Creado el ");
#nullable restore
#line 31 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Dashboard\Index.cshtml"
                                                            Write(item.Descripcion.Substring(0, 30));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</span>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1356, "\"", 1392, 2);
            WriteAttributeValue("", 1363, "/dashboard/editar?id=", 1363, 21, true);
#nullable restore
#line 32 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 1384, item.Id, 1384, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary px-2 py-3\"><i class=\"fa-solid fa-pen-to-square\"></i></a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1509, "\"", 1547, 2);
            WriteAttributeValue("", 1516, "/dashboard/eliminar?id=", 1516, 23, true);
#nullable restore
#line 33 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 1539, item.Id, 1539, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger px-2 py-3\"><i class=\"fa-solid fa-trash-can\"></i></a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 37 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Dashboard\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Dashboard\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
