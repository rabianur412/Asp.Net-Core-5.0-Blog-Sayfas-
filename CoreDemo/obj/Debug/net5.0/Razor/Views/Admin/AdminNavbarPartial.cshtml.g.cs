#pragma checksum "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\Admin\AdminNavbarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7173c5409fe0563a591985a47f361cb8d6f64ad6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminNavbarPartial), @"mvc.1.0.view", @"/Views/Admin/AdminNavbarPartial.cshtml")]
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
#line 1 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7173c5409fe0563a591985a47f361cb8d6f64ad6", @"/Views/Admin/AdminNavbarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminNavbarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/profile.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/contacts.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/mailbox.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/Blog/ExportStaticExcelBlogList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/Blog/ExportDynamicExcelBlogList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<nav class=""navbar-default navbar-static-side"" role=""navigation"">
    <div class=""sidebar-collapse"">
        <ul class=""nav metismenu"" id=""side-menu"">
            <li class=""nav-header"">
                <div class=""dropdown profile-element"">
                    <img alt=""image"" width=""60"" height=""70"" class=""rounded-circle"" src=""/admin/img/rabia2.jpg"" />
                    <a data-toggle=""dropdown"" class=""dropdown-toggle"" href=""#"">
                        <span class=""block m-t-xs font-bold"">Rabia Nur Kavi</span>
                        <span class=""text-muted text-xs block"">Yazılım Mühendisi <b class=""caret""></b></span>
                    </a>
                    <ul class=""dropdown-menu animated fadeInRight m-t-xs"">
                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7173c5409fe0563a591985a47f361cb8d6f64ad66132", async() => {
                WriteLiteral("Profile");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7173c5409fe0563a591985a47f361cb8d6f64ad67324", async() => {
                WriteLiteral("Contacts");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7173c5409fe0563a591985a47f361cb8d6f64ad68517", async() => {
                WriteLiteral("Mailbox");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                        <li class=""dropdown-divider""></li>
                        <li><a class=""dropdown-item"" href=""login.html"">Logout</a></li>
                    </ul>
                </div>
                <div class=""logo-element"">
                    IN+
                </div>
            </li>
            <li>
                <a href=""/Admin/Widget/Index/""><i class=""fa fa-th-large""></i> <span class=""nav-label"">Panel</span>  </a>
            </li>
            <li>
                <a href=""/Admin/Chart/Index/""><i class=""fa fa-pie-chart""></i> <span class=""nav-label"">Metrikler</span>  </a>
            </li>
            <li>
                <a href=""mailbox.html""><i class=""fa fa-envelope""></i> <span class=""nav-label"">Mesajlar </span><span class=""label label-warning float-right"">0/0</span></a>
                <ul class=""nav nav-second-level collapse"">
                    <li><a href=""/Admin/AdminMessage/InBox/"">Gelen Kutusu</a></li>
                    <li><a href=""/Admin/AdminMessa");
            WriteLiteral(@"ge/SendBox"">Giden Kutusu</a></li>
                    <li><a href=""/Admin/AdminMessage/ComposeMessage"">Yeni Mesaj Oluştur</a></li>
                </ul>
            </li>
            <li>
                <a href=""/Admin/Category/Index/""><i class=""fa fa-list""></i> <span class=""nav-label"">Kategoriler</span>  </a>
            </li>
            <li>
                <a href=""/Admin/AdminBlog/Index/""><i class=""fa fa-pencil-square-o""></i> <span class=""nav-label"">Bloglar</span>  </a>
            </li>
            <li>
                <a href=""/Admin/AdminComment/Index/""><i class=""fa fa-comment""></i> <span class=""nav-label"">Yorumlar</span>  </a>
            </li>
            <li>
                <a href=""/Admin/Writer/WriterProfileList/""><i class=""fa fa-user""></i> <span class=""nav-label"">Yazarlar</span>  </a>
            </li>
            <li>
                <a href=""/Admin/AdminRole/Index""><i class=""fa fa-user-secret""></i> <span class=""nav-label"">Rolleme Ayarları</span>  </a>
            </li>
   ");
            WriteLiteral(@"         <li>
            <li>
                <a href=""/Admin/AdminNotification/Index/""><i class=""fa fa-bell""></i> <span class=""nav-label"">Bildirimler</span>  </a>
            </li>
            <li>
                <a href=""/Admin/AdminContact/Index/""><i class=""fa fa-phone""></i> <span class=""nav-label"">İletişim</span>  </a>
            </li>
            <li>
                <a href=""/Admin/AdminAbout/Index/""><i class=""fa fa-pencil-square""></i> <span class=""nav-label"">Hakkımızda</span>  </a>
            </li>
            <li>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7173c5409fe0563a591985a47f361cb8d6f64ad612428", async() => {
                WriteLiteral("<i class=\"fa fa-pencil\"></i> <span class=\"nav-label\">Statik Rapor</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n            <li>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7173c5409fe0563a591985a47f361cb8d6f64ad613631", async() => {
                WriteLiteral("<i class=\"fa fa-pencil-square\"></i> <span class=\"nav-label\">Dinamik Rapor</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </li>
            <li>
                <a href=""/Admin/Writer/WriterProfileList/""><i class=""fa fa-gear""></i> <span class=""nav-label"">Ayarlar</span>  </a>
            </li>
            <li>
                <a href=""/Login/LogOut""><i class=""fa fa-apple""></i> <span class=""nav-label"">Çıkış Yap</span></a>
            </li>

        </ul>
    </div>
</nav>
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
