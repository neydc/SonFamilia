#pragma checksum "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Veterinario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b08d7166c7505b77f717b79cd683a247c579f2ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Veterinario_Index), @"mvc.1.0.view", @"/Views/Veterinario/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b08d7166c7505b77f717b79cd683a247c579f2ed", @"/Views/Veterinario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9350116f029f0e5aaad6a144f285542ddd80731", @"/Views/_ViewImports.cshtml")]
    public class Views_Veterinario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Veterinario\Index.cshtml"
  
    ViewData["Title"] = "Veterinarios";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""hero-wrap hero-wrap-2"" style=""background-image: url('images/bg_2.jpg');"" data-stellar-background-ratio=""0.5"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-end"">
            <div class=""col-md-9 ftco-animate pb-5"">
                <p class=""breadcrumbs mb-2""><span class=""mr-2""><a href=""/"">Inicio <i class=""ion-ios-arrow-forward""></i></a></span> <span>Veterinarios <i class=""ion-ios-arrow-forward""></i></span></p>
                <h1 class=""mb-0 bread"">Conoce a nuestros doctores veterinarios</h1>
            </div>
        </div>
    </div>
</section>

<section class=""ftco-section bg-light"">
    <div class=""container"">
        <div class=""row"">
");
#nullable restore
#line 21 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Veterinario\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-3 ftco-animate\">\r\n                    <div class=\"staff\">\r\n                        <div class=\"img-wrap d-flex align-items-stretch\">\r\n                            <div class=\"img align-self-stretch\"");
            BeginWriteAttribute("style", " style=\"", 1103, "\"", 1154, 4);
            WriteAttributeValue("", 1111, "background-image:", 1111, 17, true);
            WriteAttributeValue(" ", 1128, "url(images/", 1129, 12, true);
#nullable restore
#line 26 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Veterinario\Index.cshtml"
WriteAttributeValue("", 1140, item.Imagen, 1140, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1152, ");", 1152, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        </div>\r\n                        <div class=\"text pt-3 px-3 pb-4 text-center\">\r\n                            <h3>");
#nullable restore
#line 29 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Veterinario\Index.cshtml"
                           Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <span class=\"position mb-2\">");
#nullable restore
#line 30 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Veterinario\Index.cshtml"
                                                   Write(item.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <div class=\"faded\">\r\n                                <p>");
#nullable restore
#line 32 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Veterinario\Index.cshtml"
                              Write(item.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                <ul class=""ftco-social text-center"">
                                    <li class=""ftco-animate""><a href=""#"" class=""d-flex align-items-center justify-content-center""><span class=""fa fa-twitter""></span></a></li>
                                    <li class=""ftco-animate""><a href=""#"" class=""d-flex align-items-center justify-content-center""><span class=""fa fa-facebook""></span></a></li>
                                    <li class=""ftco-animate""><a href=""#"" class=""d-flex align-items-center justify-content-center""><span class=""fa fa-google""></span></a></li>
                                    <li class=""ftco-animate""><a href=""#"" class=""d-flex align-items-center justify-content-center""><span class=""fa fa-instagram""></span></a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 43 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Veterinario\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("           \r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
