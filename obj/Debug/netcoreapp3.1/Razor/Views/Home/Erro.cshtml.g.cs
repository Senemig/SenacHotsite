#pragma checksum "C:\Users\ferna\Desktop\SENAC\Módulo 2\UC06\projetohotsite\Views\Home\Erro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5d13808c9942abc0ceb2631437509b1a175b7a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Erro), @"mvc.1.0.view", @"/Views/Home/Erro.cshtml")]
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
#line 1 "C:\Users\ferna\Desktop\SENAC\Módulo 2\UC06\projetohotsite\Views\_ViewImports.cshtml"
using Hotsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ferna\Desktop\SENAC\Módulo 2\UC06\projetohotsite\Views\_ViewImports.cshtml"
using Hotsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5d13808c9942abc0ceb2631437509b1a175b7a1", @"/Views/Home/Erro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bc39314ee689b901092e0940a38afe41bd0f7d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Erro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ferna\Desktop\SENAC\Módulo 2\UC06\projetohotsite\Views\Home\Erro.cshtml"
  
    ViewData["Title"] = "Erro";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center mt-3\">Algo deu errado!</h1>\r\n\r\n<div class=\"text-center\">\r\n    <img src=\"/images/erro.png\" alt=\"Pessoa meditando\" class=\"img-fluid\">\r\n</div>\r\n\r\n<h3 class=\"text-center\">Tente novamente mais tarde.</h3>\r\n\r\n<p class=\"text-center\">");
#nullable restore
#line 13 "C:\Users\ferna\Desktop\SENAC\Módulo 2\UC06\projetohotsite\Views\Home\Erro.cshtml"
                  Write(ViewData["Erro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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