#pragma checksum "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statistic1\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db1a8d822515cc6fb97f627171bb0e690841b518"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_Statistic1_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/Statistic1/Default.cshtml")]
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
#line 1 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db1a8d822515cc6fb97f627171bb0e690841b518", @"/Areas/Admin/Views/Shared/Components/Statistic1/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b881055197282d0a2ab51004156381e82f1e1fbc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_Statistic1_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-3"">
        <div class=""widget style1"">
            <div class=""row"">
                <div class=""col-4 text-center"">
                    <i class=""fa fa-paperclip fa-5x""></i>
                </div>
                <div class=""col-8 text-right"">
                    <span> Toplam Blog Sayısı </span>
                    <h2 class=""font-bold"">");
#nullable restore
#line 10 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statistic1\Default.cshtml"
                                     Write(ViewBag.cv);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""widget style1 navy-bg"">
            <div class=""row"">
                <div class=""col-4"">
                    <i class=""fa fa-cloud fa-5x""></i>
                </div>
                <div class=""col-8 text-right"">
                    <span> Ankara </span>
                    <h2 class=""font-bold"">");
#nullable restore
#line 23 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statistic1\Default.cshtml"
                                     Write(ViewBag.havaDurumu);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 'C</h2>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""widget style1 lazur-bg"">
            <div class=""row"">
                <div class=""col-4"">
                    <i class=""fa fa-envelope-o fa-5x""></i>
                </div>
                <div class=""col-8 text-right"">
                    <span> Yeni Mesaj Sayısı </span>
                    <h2 class=""font-bold"">");
#nullable restore
#line 36 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statistic1\Default.cshtml"
                                     Write(ViewBag.ms);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""widget style1 yellow-bg"">
            <div class=""row"">
                <div class=""col-4"">
                    <i class=""fa fa-comment fa-5x""></i>
                </div>
                <div class=""col-8 text-right"">
                    <span> Toplam Yorum Sayısı </span>
                    <h2 class=""font-bold"">");
#nullable restore
#line 49 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statistic1\Default.cshtml"
                                     Write(ViewBag.cc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
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
