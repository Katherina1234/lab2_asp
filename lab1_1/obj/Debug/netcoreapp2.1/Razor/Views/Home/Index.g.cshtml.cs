#pragma checksum "F:\univer\asp\lab2_1\lab1_1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c2d3ee5dbda2c8dc1931310aa2b2fae251c0e5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "F:\univer\asp\lab2_1\lab1_1\Views\_ViewImports.cshtml"
using lab1_1;

#line default
#line hidden
#line 2 "F:\univer\asp\lab2_1\lab1_1\Views\_ViewImports.cshtml"
using lab1_1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c2d3ee5dbda2c8dc1931310aa2b2fae251c0e5c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a58df08d0270e7ee09983cf0b9b091ab807fbea8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<lab1_1.Models.Sklad>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\univer\asp\lab2_1\lab1_1\Views\Home\Index.cshtml"
  
    double sum = 0;

#line default
#line hidden
            BeginContext(69, 236, true);
            WriteLiteral("<h2>Товари на складі</h2>\r\n\r\n<table class=\"table\" id=\"cl2\">\r\n\r\n    <tr class=\"cl3\"><td>№</td><td>Назва</td><td>Матеріал</td><td>Ціна</td><td>Кількість</td><td>Дата постачання</td><td>Місце на складі</td><td>Вартість</td><td></td></tr>\r\n");
            EndContext();
#line 10 "F:\univer\asp\lab2_1\lab1_1\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

        double k = 0;


#line default
#line hidden
            BeginContext(373, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(404, 7, false);
#line 16 "F:\univer\asp\lab2_1\lab1_1\Views\Home\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(411, 9, true);
            WriteLiteral("</td>\r\n\r\n");
            EndContext();
#line 18 "F:\univer\asp\lab2_1\lab1_1\Views\Home\Index.cshtml"
             foreach (var item1 in ViewBag.Tovars)
            {
                if (item1.id == item.tovar_num)
                {

                    k = item1.vartist;
                    sum += item.kilk * k;

#line default
#line hidden
            BeginContext(640, 24, true);
            WriteLiteral("                    <td>");
            EndContext();
            BeginContext(665, 10, false);
#line 25 "F:\univer\asp\lab2_1\lab1_1\Views\Home\Index.cshtml"
                   Write(item1.name);

#line default
#line hidden
            EndContext();
            BeginContext(675, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(707, 14, false);
#line 26 "F:\univer\asp\lab2_1\lab1_1\Views\Home\Index.cshtml"
                   Write(item1.material);

#line default
#line hidden
            EndContext();
            BeginContext(721, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(753, 13, false);
#line 27 "F:\univer\asp\lab2_1\lab1_1\Views\Home\Index.cshtml"
                   Write(item1.vartist);

#line default
#line hidden
            EndContext();
            BeginContext(766, 5, true);
            WriteLiteral("</td>");
            EndContext();
#line 27 "F:\univer\asp\lab2_1\lab1_1\Views\Home\Index.cshtml"
                                           }
            }

#line default
#line hidden
            BeginContext(789, 16, true);
            WriteLiteral("            <td>");
            EndContext();
            BeginContext(806, 9, false);
#line 29 "F:\univer\asp\lab2_1\lab1_1\Views\Home\Index.cshtml"
           Write(item.kilk);

#line default
#line hidden
            EndContext();
            BeginContext(815, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(839, 9, false);
#line 30 "F:\univer\asp\lab2_1\lab1_1\Views\Home\Index.cshtml"
           Write(item.prub);

#line default
#line hidden
            EndContext();
            BeginContext(848, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(872, 10, false);
#line 31 "F:\univer\asp\lab2_1\lab1_1\Views\Home\Index.cshtml"
           Write(item.misce);

#line default
#line hidden
            EndContext();
            BeginContext(882, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(907, 13, false);
#line 32 "F:\univer\asp\lab2_1\lab1_1\Views\Home\Index.cshtml"
            Write(item.kilk * k);

#line default
#line hidden
            EndContext();
            BeginContext(921, 26, true);
            WriteLiteral("</td>\r\n\r\n\r\n        </tr>\r\n");
            EndContext();
#line 36 "F:\univer\asp\lab2_1\lab1_1\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(954, 55, true);
            WriteLiteral("    <tr><td colspan=\"7\">Всього товарів на суму</td><td>");
            EndContext();
            BeginContext(1010, 3, false);
#line 37 "F:\univer\asp\lab2_1\lab1_1\Views\Home\Index.cshtml"
                                                  Write(sum);

#line default
#line hidden
            EndContext();
            BeginContext(1013, 20, true);
            WriteLiteral("</td></tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<lab1_1.Models.Sklad>> Html { get; private set; }
    }
}
#pragma warning restore 1591
