#pragma checksum "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2918b3b9454ab130181e7344bc4e8edb0a706b29"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2918b3b9454ab130181e7344bc4e8edb0a706b29", @"/Views/Public/Index.cshtml")]
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
            WriteLiteral("\r\n<section class=\"ftco-section bg-light\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 ftco-animate\">\r\n                    <div class=\"block-7\">\r\n                        <div class=\"img\"");
            BeginWriteAttribute("style", " style=\"", 341, "\"", 392, 4);
            WriteAttributeValue("", 349, "background-image:", 349, 17, true);
            WriteAttributeValue(" ", 366, "url(images/", 367, 12, true);
#nullable restore
#line 13 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Index.cshtml"
WriteAttributeValue("", 378, item.Imagen, 378, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 390, ");", 390, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        <div class=\"text-center p-4\">\r\n                            <span class=\"excerpt d-block\">");
#nullable restore
#line 15 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Index.cshtml"
                                                     Write(item.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                           \r\n                            <span class=\" d-block\">");
#nullable restore
#line 17 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Index.cshtml"
                                              Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                            <a href=\"#\" class=\"btn btn-primary d-block px-2 py-3\">Ver más</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 23 "C:\Users\ndiaz\source\repos\SonFamilia\SonFamilia\Views\Public\Index.cshtml"
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
