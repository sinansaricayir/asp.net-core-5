#pragma checksum "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "260aceb1df45b5ba7edf4ff6e0064ed0842165d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_AddPortfolio), @"mvc.1.0.view", @"/Views/Portfolio/AddPortfolio.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"260aceb1df45b5ba7edf4ff6e0064ed0842165d7", @"/Views/Portfolio/AddPortfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Portfolio_AddPortfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Portfolio>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
  
    ViewData["Title"] = "AddPortfolio";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card-header border-0\">\r\n    <h3 class=\"mb-0\">Portfolio Ekleme Sayfası</h3>\r\n</div>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
 using (Html.BeginForm("AddPortfolio", "Portfolio", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 15 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.Label("Proje Adı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.Name, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 21 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.Label("Resim 1"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.ImageUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.ImageUrl, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 26 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.Label("Resim 2"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.ImageUrl2, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.ImageUrl2, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 31 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.Label("Proje Url"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x => x.ProjectUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.ImageUrl2, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-info\">Ekle</button>\r\n");
#nullable restore
#line 37 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Portfolio> Html { get; private set; }
    }
}
#pragma warning restore 1591
