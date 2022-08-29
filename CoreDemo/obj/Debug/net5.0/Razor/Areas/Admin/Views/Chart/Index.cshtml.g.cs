#pragma checksum "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Chart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b822133bef3c2b31b2795dcd1bae4958f9b2e01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Chart_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Chart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b822133bef3c2b31b2795dcd1bae4958f9b2e01", @"/Areas/Admin/Views/Chart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b881055197282d0a2ab51004156381e82f1e1fbc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Chart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Rabia Nur\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Chart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-12"">
        <div id=""chartdiv"" style=""width:800px; height:600px"">
            <h2>Burası Chart Alanıdır</h2>
        </div>
    </div>
</div>
<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
<script type=""text/javascript"">
    google.charts.load('current', { 'packages': ['CoreChart'] });
    google.charts.setOnLoadCallback(DrawonLoad);//çağırıldığı zaman çizme işlemi gerçekleşecek

    function DrawonLoad() {
        $(function () {
            $.ajax({
                type: 'GET',
                url: '/Admin/Chart/CategoryChart/',//bunu çağıracaksın
                success: function (chartsdata) {//çağırma işlemi başarılı olursa bir tane daha fonksiyon devreye girsin
                    var Data = chartsdata.jsonlist;//objeden jsonlisti çekiyoruz jsonlisti CategoryChart tan çağırdık
                    var data = new google.visualization.DataTable();//dataya görselleştirmek için gerekli olan atamayı yaptık
 ");
            WriteLiteral(@"                   data.addColumn('string', 'categoryname');//grafiğe sütun ekliyoruz; bu sütunden iki tane olacak birincisi string türü için grafiğe çekeceğimiz alanın string kısmını ikinci yere veriyoruz
                    data.addColumn('number', 'categorycount');
                    for (var i = 0; i < Data.length; i++) {//her bir datayı grafiğe yansıtmak için döngüye alıyoruz
                        data.addRow([Data[i].categoryname, Data[i].categorycount]);//satırların içine datadan gelen i. değerin categoryname ini ve category countunu ekle
                    }
                    //CHARTIN TÜRÜ BELİRLENİYOR PİECHART TÜRÜ.PARANTEZ İÇİNDE PARAMETRE GÖNDERİYORUZ SAYFANIN HANGİ KISMINA YAZMAMIZ GEREKİYOR DİVİN ARASINDA divin içindeki id yi yazdırıyoruz
                    var chart = new google.visualization.PieChart(document.getElementById('chartdiv'));
                    //chartın ekrana basılması
                    chart.draw(data, {
                        title: ""Yazılan Blog Sayılarına ");
            WriteLiteral("Göre Kategori Listesi\",\r\n                        position: \"top\",\r\n                        fontsize: \"16px\"\r\n                    });\r\n                }\r\n            });\r\n        })\r\n    }\r\n</script>\r\n");
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
