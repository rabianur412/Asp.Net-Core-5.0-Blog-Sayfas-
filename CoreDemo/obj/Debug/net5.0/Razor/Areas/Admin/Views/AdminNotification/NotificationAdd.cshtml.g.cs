#pragma checksum "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminNotification\NotificationAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b52f5fac693affd034f4d68078022a9a61bcb17b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminNotification_NotificationAdd), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminNotification/NotificationAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b52f5fac693affd034f4d68078022a9a61bcb17b", @"/Areas/Admin/Views/AdminNotification/NotificationAdd.cshtml")]
    public class Areas_Admin_Views_AdminNotification_NotificationAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Notification>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminNotification\NotificationAdd.cshtml"
  
    ViewData["Title"] = "NotificationAdd";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminNotification\NotificationAdd.cshtml"
 using (Html.BeginForm("NotificationAdd", "AdminNotification", FormMethod.Post))
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminNotification\NotificationAdd.cshtml"
Write(Html.Label("Bildirim "));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminNotification\NotificationAdd.cshtml"
Write(Html.TextBoxFor(x => x.NotificationType, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminNotification\NotificationAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.NotificationType));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 14 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminNotification\NotificationAdd.cshtml"
Write(Html.Label("Bildirim Detayı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminNotification\NotificationAdd.cshtml"
Write(Html.TextBoxFor(x => x.NotificationDetails, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminNotification\NotificationAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.NotificationDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 19 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminNotification\NotificationAdd.cshtml"
Write(Html.HiddenFor(x => x.NotificationStatus));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminNotification\NotificationAdd.cshtml"
Write(Html.HiddenFor(x => x.NotificationColor));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminNotification\NotificationAdd.cshtml"
Write(Html.HiddenFor(x => x.NotificationTypeSymbol));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminNotification\NotificationAdd.cshtml"
Write(Html.HiddenFor(x => x.NotificationID));

#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral(" ");
            }
            );
            WriteLiteral("    <button class=\"btn btn-primary\">Bildirimi Ekle</button>\r\n");
#nullable restore
#line 26 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminNotification\NotificationAdd.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Notification> Html { get; private set; }
    }
}
#pragma warning restore 1591