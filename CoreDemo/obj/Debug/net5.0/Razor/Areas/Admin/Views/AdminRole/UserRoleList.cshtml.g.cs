#pragma checksum "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRole\UserRoleList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "febfca4d83bf55637c7b21ef6f8bf3a0cc2bb0b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminRole_UserRoleList), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminRole/UserRoleList.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"febfca4d83bf55637c7b21ef6f8bf3a0cc2bb0b9", @"/Areas/Admin/Views/AdminRole/UserRoleList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b881055197282d0a2ab51004156381e82f1e1fbc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminRole_UserRoleList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
  
    ViewData["Title"] = "UserRoleList";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Kullanıcı Rol Listesi</h1>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Kullanıcı</th>\r\n        <th>Rol Ata</th>\r\n    </tr>\r\n");
#nullable restore
#line 14 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
     foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 17 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
                   Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 439, "\"", 482, 2);
            WriteAttributeValue("", 446, "/Admin/AdminRole/AssignRole/", 446, 28, true);
#nullable restore
#line 18 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
WriteAttributeValue("", 474, item.Id, 474, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Rol Ata</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 20 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
            }

#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral(" ");
            }
            );
            WriteLiteral("</table>\r\n<a href=\"/Admin/AdminRole/Index\" class=\"btn btn-success\">Rol Listesine Dön</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
