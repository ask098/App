#pragma checksum "C:\Repositorio\App\Wayuu\Wayuu.WebApp\Views\Schools\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7e80ebf4671697e00dd744a064f29531153fb19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Schools_Index), @"mvc.1.0.view", @"/Views/Schools/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Schools/Index.cshtml", typeof(AspNetCore.Views_Schools_Index))]
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
#line 1 "C:\Repositorio\App\Wayuu\Wayuu.WebApp\Views\_ViewImports.cshtml"
using Wayuu.WebApp;

#line default
#line hidden
#line 2 "C:\Repositorio\App\Wayuu\Wayuu.WebApp\Views\_ViewImports.cshtml"
using Wayuu.WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7e80ebf4671697e00dd744a064f29531153fb19", @"/Views/Schools/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd2b49c7e0052c48d2c6232e96e86d1d90ffafb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Schools_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Wayuu.Entities.School>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Repositorio\App\Wayuu\Wayuu.WebApp\Views\Schools\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(77, 20, true);
            WriteLiteral("\r\n<h1>Schools</h1>\r\n");
            EndContext();
#line 7 "C:\Repositorio\App\Wayuu\Wayuu.WebApp\Views\Schools\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(127, 145, true);
            WriteLiteral("    <div>Nombre Escuela:</div>\r\n    <div> <input type=\"text\" name=\"schoolName\" /> </div>\r\n    <div> <input type=\"submit\" value=\"Crear\" /></div>\r\n");
            EndContext();
#line 12 "C:\Repositorio\App\Wayuu\Wayuu.WebApp\Views\Schools\Index.cshtml"
}

#line default
#line hidden
            BeginContext(275, 86, true);
            WriteLiteral("\r\n<br />\r\n<table>\r\n    <tr>\r\n        <td>ID</td>\r\n        <td>Nombre</td>\r\n    </tr>\r\n");
            EndContext();
#line 20 "C:\Repositorio\App\Wayuu\Wayuu.WebApp\Views\Schools\Index.cshtml"
     foreach (var school in Model)
    {

#line default
#line hidden
            BeginContext(404, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(435, 65, false);
#line 23 "C:\Repositorio\App\Wayuu\Wayuu.WebApp\Views\Schools\Index.cshtml"
           Write(Html.ActionLink("Ver Detalle", "Details", new { id = school.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(500, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(524, 11, false);
#line 24 "C:\Repositorio\App\Wayuu\Wayuu.WebApp\Views\Schools\Index.cshtml"
           Write(school.Name);

#line default
#line hidden
            EndContext();
            BeginContext(535, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 26 "C:\Repositorio\App\Wayuu\Wayuu.WebApp\Views\Schools\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(564, 8, true);
            WriteLiteral("</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Wayuu.Entities.School>> Html { get; private set; }
    }
}
#pragma warning restore 1591
