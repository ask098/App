#pragma checksum "C:\Repositorio\App\Wayuu\Wayuu.WebApp\Views\Logs\GetALL.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ce309a766a38609b8dfe6575d620255720e5d6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Logs_GetALL), @"mvc.1.0.view", @"/Views/Logs/GetALL.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Logs/GetALL.cshtml", typeof(AspNetCore.Views_Logs_GetALL))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ce309a766a38609b8dfe6575d620255720e5d6b", @"/Views/Logs/GetALL.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd2b49c7e0052c48d2c6232e96e86d1d90ffafb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Logs_GetALL : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Wayuu.Entities.WayuuLog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Repositorio\App\Wayuu\Wayuu.WebApp\Views\Logs\GetALL.cshtml"
  
    ViewData["Title"] = "GetALL";

#line default
#line hidden
            BeginContext(89, 21, true);
            WriteLiteral("\r\n<h1>GetALL</h1>\r\n\r\n");
            EndContext();
            BeginContext(168, 84, true);
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(253, 38, false);
#line 16 "C:\Repositorio\App\Wayuu\Wayuu.WebApp\Views\Logs\GetALL.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(291, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(347, 44, false);
#line 19 "C:\Repositorio\App\Wayuu\Wayuu.WebApp\Views\Logs\GetALL.cshtml"
           Write(Html.DisplayNameFor(model => model.DateTime));

#line default
#line hidden
            EndContext();
            BeginContext(391, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(447, 40, false);
#line 22 "C:\Repositorio\App\Wayuu\Wayuu.WebApp\Views\Logs\GetALL.cshtml"
           Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(487, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(543, 43, false);
#line 25 "C:\Repositorio\App\Wayuu\Wayuu.WebApp\Views\Logs\GetALL.cshtml"
           Write(Html.DisplayNameFor(model => model.Message));

#line default
#line hidden
            EndContext();
            BeginContext(586, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(634, 42, true);
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "C:\Repositorio\App\Wayuu\Wayuu.WebApp\Views\Logs\GetALL.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(708, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(757, 37, false);
#line 34 "C:\Repositorio\App\Wayuu\Wayuu.WebApp\Views\Logs\GetALL.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(794, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(850, 43, false);
#line 37 "C:\Repositorio\App\Wayuu\Wayuu.WebApp\Views\Logs\GetALL.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateTime));

#line default
#line hidden
            EndContext();
            BeginContext(893, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(949, 39, false);
#line 40 "C:\Repositorio\App\Wayuu\Wayuu.WebApp\Views\Logs\GetALL.cshtml"
           Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
            EndContext();
            BeginContext(988, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1044, 42, false);
#line 43 "C:\Repositorio\App\Wayuu\Wayuu.WebApp\Views\Logs\GetALL.cshtml"
           Write(Html.DisplayFor(modelItem => item.Message));

#line default
#line hidden
            EndContext();
            BeginContext(1086, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
            BeginContext(1414, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 51 "C:\Repositorio\App\Wayuu\Wayuu.WebApp\Views\Logs\GetALL.cshtml"
}

#line default
#line hidden
            BeginContext(1432, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Wayuu.Entities.WayuuLog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
