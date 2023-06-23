#pragma checksum "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1b127a0b894d80061ddf6dffaaa6633456debb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_Index), @"mvc.1.0.view", @"/Views/Portfolio/Index.cshtml")]
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
#line 1 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1b127a0b894d80061ddf6dffaaa6633456debb9", @"/Views/Portfolio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Portfolio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card-header border-0"">
    <h3 class=""mb-0"">Proje Listesi Tablosu</h3>
</div>
<!-- Light table -->
<div class=""table-responsive"">
    <table class=""table align-items-center table-flush"">
        <thead class=""thead-light"">
            <tr>
                <th scope=""col"" class=""sort"" data-sort=""name"">#</th>
                <th scope=""col"" class=""sort"" data-sort=""budget"">Proje Adı</th>
                <th scope=""col"" class=""sort"" data-sort=""completion"">Resimler</th>
                <th scope=""col"" class=""sort"" data-sort=""completion"">Proje Url</th>
                <th scope=""col"" class=""sort"" data-sort=""budget"">Sil</th>
                <th scope=""col"" class=""sort"" data-sort=""budget"">Düzenle</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody class=""list"">
");
#nullable restore
#line 26 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">\r\n                    ");
#nullable restore
#line 30 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\Index.cshtml"
               Write(item.PortfolioID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"budget\">\r\n                    ");
#nullable restore
#line 33 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    <div class=\"avatar-group\">\r\n                        <a href=\"#\" class=\"avatar avatar-md \" data-toggle=\"tooltip\" data-original-title=\"");
#nullable restore
#line 37 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\Index.cshtml"
                                                                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            <img");
            BeginWriteAttribute("alt", " alt=\"", 1467, "\"", 1483, 1);
#nullable restore
#line 38 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 1473, item.Name, 1473, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 1484, "\"", 1504, 1);
#nullable restore
#line 38 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 1490, item.ImageUrl, 1490, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </a>\r\n                        <a href=\"#\" class=\"avatar avatar-md \" data-toggle=\"tooltip\" data-original-title=\"");
#nullable restore
#line 40 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\Index.cshtml"
                                                                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            <img");
            BeginWriteAttribute("alt", " alt=\"", 1689, "\"", 1705, 1);
#nullable restore
#line 41 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 1695, item.Name, 1695, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 1706, "\"", 1727, 1);
#nullable restore
#line 41 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 1712, item.ImageUrl2, 1712, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </a>\r\n                    </div>\r\n                </td>\r\n                <td class=\"budget\">\r\n                    ");
#nullable restore
#line 46 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\Index.cshtml"
               Write(item.ProjectUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1954, "\"", 2005, 2);
            WriteAttributeValue("", 1961, "/Portfolio/DeletePortfolio/", 1961, 27, true);
#nullable restore
#line 49 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 1988, item.PortfolioID, 1988, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" onclick=\"return confirm(\'Silmek istediğinize emin misiniz?\')\">Sil</a>\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2168, "\"", 2217, 2);
            WriteAttributeValue("", 2175, "/Portfolio/EditPortfolio/", 2175, 25, true);
#nullable restore
#line 52 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 2200, item.PortfolioID, 2200, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Düzenle</a>\r\n                </td>\r\n                <td></td>\r\n            </tr>\r\n");
#nullable restore
#line 56 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n<br />\r\n<a href=\"/Portfolio/AddPortfolio\" class=\"btn btn-info\">Proje Ekle</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
