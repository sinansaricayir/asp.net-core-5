#pragma checksum "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "701c2b8a5af634fd38311cf0feed64870cca8fc5"
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
#line 1 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"701c2b8a5af634fd38311cf0feed64870cca8fc5", @"/Views/Portfolio/AddPortfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Portfolio_AddPortfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Portfolio>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
  
    ViewData["Title"] = "AddPortfolio";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"col-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n");
#nullable restore
#line 11 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
             using (Html.BeginForm("AddPortfolio", "Portfolio", FormMethod.Post, new { enctype = "multipart/form-data" }))
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n");
#nullable restore
#line 16 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
           Write(Html.Label("Proje Adı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
           Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
           Write(Html.ValidationMessageFor(x => x.Name, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n");
#nullable restore
#line 23 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
           Write(Html.Label("Tarih"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
           Write(Html.TextBoxFor(x => x.Date, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
           Write(Html.ValidationMessageFor(x => x.Date, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n");
#nullable restore
#line 30 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
           Write(Html.Label("Tamamlanma Oranı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
           Write(Html.TextBoxFor(x => x.StatusValue, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
           Write(Html.ValidationMessageFor(x => x.StatusValue, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n");
#nullable restore
#line 36 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
           Write(Html.Label("Resim 1"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"file\" name=\"Picture1\" accept=\"image/*\" class=\"form-control\" />\r\n                <br />\r\n");
#nullable restore
#line 40 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
           Write(Html.Label("Resim 2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"file\" name=\"Picture2\" accept=\"image/*\" class=\"form-control\" />\r\n                <br />\r\n");
#nullable restore
#line 44 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
           Write(Html.Label("Proje Url"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"
           Write(Html.TextBoxFor(x => x.ProjectUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n");
            WriteLiteral("                <div class=\"d-flex justify-content-end\">\r\n                    <button type=\"submit\" class=\"btn btn-success px-4 py-2\">Ekle</button>\r\n                </div>\r\n");
#nullable restore
#line 51 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Portfolio\AddPortfolio.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
