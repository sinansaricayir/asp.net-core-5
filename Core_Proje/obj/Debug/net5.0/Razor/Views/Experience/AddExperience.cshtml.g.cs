#pragma checksum "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Experience\AddExperience.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3075f4f3678065f23f25b73bb1458a36f193ef29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Experience_AddExperience), @"mvc.1.0.view", @"/Views/Experience/AddExperience.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3075f4f3678065f23f25b73bb1458a36f193ef29", @"/Views/Experience/AddExperience.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Experience_AddExperience : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Experience>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Experience\AddExperience.cshtml"
  
    ViewData["Title"] = "AddExperience";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n");
#nullable restore
#line 10 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Experience\AddExperience.cshtml"
             using (Html.BeginForm("AddExperience", "Experience", FormMethod.Post, new { enctype = "multipart/form-data" }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n");
#nullable restore
#line 14 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Experience\AddExperience.cshtml"
           Write(Html.Label("Deneyim Adı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Experience\AddExperience.cshtml"
           Write(Html.TextBoxFor(x => x.ExperienceName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Experience\AddExperience.cshtml"
           Write(Html.ValidationMessageFor(x => x.ExperienceName, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n");
#nullable restore
#line 19 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Experience\AddExperience.cshtml"
           Write(Html.Label("Tarih"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Experience\AddExperience.cshtml"
           Write(Html.TextBoxFor(x => x.Date, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Experience\AddExperience.cshtml"
           Write(Html.ValidationMessageFor(x => x.Date, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n");
#nullable restore
#line 24 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Experience\AddExperience.cshtml"
           Write(Html.Label("Resim"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"file\" name=\"Picture\" accept=\"image/*\" class=\"form-control\" />\r\n                <br />\r\n");
#nullable restore
#line 28 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Experience\AddExperience.cshtml"
           Write(Html.Label("Açıklama"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Experience\AddExperience.cshtml"
           Write(Html.TextAreaFor(x => x.Description, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Experience\AddExperience.cshtml"
           Write(Html.ValidationMessageFor(x => x.Description, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n");
#nullable restore
#line 33 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Experience\AddExperience.cshtml"
           Write(Html.Label("Şirket Adı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Experience\AddExperience.cshtml"
           Write(Html.TextBoxFor(x => x.CompanyName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Experience\AddExperience.cshtml"
           Write(Html.ValidationMessageFor(x => x.CompanyName, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n");
            WriteLiteral("                <div class=\"d-flex justify-content-end\">\r\n                    <button type=\"submit\" class=\"btn btn-success px-4 py-2\">Ekle</button>\r\n                </div>\r\n");
#nullable restore
#line 41 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Experience\AddExperience.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Experience> Html { get; private set; }
    }
}
#pragma warning restore 1591
