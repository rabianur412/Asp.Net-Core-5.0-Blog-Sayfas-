#pragma checksum "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53f7bb144918fb18a39397d7fb4b3c244a75f742"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53f7bb144918fb18a39397d7fb4b3c244a75f742", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""main-content-w3layouts-agileits"">
    <div class=""container"">
        <h3 class=""tittle"">Blog Yazıları</h3>
        <div class=""inner-sec"">

            <div class=""left-blog-info-w3layouts-agileits text-left"">
                <div class=""row"">
");
#nullable restore
#line 15 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                     foreach (var item in Model)
                    {



#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 card\">\r\n                            <a href=\"single.html\">\r\n                               \r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 660, "\"", 681, 1);
#nullable restore
#line 22 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
WriteAttributeValue("", 666, item.BlogImage, 666, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 713, "\"", 719, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <div class=""card-body"">
                                <ul class=""blog-icons my-4"">
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 28 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                                                                            Write(((DateTime)item.BlogCreateDate).ToString("dd-MMMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </a>
                                    </li>
                                    <li class=""mx-2"">
                                        <a href=""#"">
                                            <i class=""far fa-comment""></i> 21
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"">
                                            <i class=""fas fa-asterisk""></i> ");
#nullable restore
#line 38 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                                                                       Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </li>\r\n                                </ul>\r\n                                <h5 class=\"card-title\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1899, "\"", 1937, 3);
            WriteAttributeValue("", 1906, "/Blog/BlogReadAll/", 1906, 18, true);
#nullable restore
#line 43 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1924, item.BlogId, 1924, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1936, "/", 1936, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                                                                         Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h5>\r\n                                <p class=\"card-text mb-3\">");
#nullable restore
#line 45 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                                                      Write(item.BlogContent.Length > 150 ? item.BlogContent.Substring
                                                          (0, item.BlogContent.Substring(0,155).LastIndexOf(" "))+"..."
                                                           : item.BlogContent + "...");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2367, "\"", 2405, 3);
            WriteAttributeValue("", 2374, "/Blog/BlogReadAll/", 2374, 18, true);
#nullable restore
#line 48 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2392, item.BlogId, 2392, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2404, "/", 2404, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Devamını Oku...</a>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 51 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
