#pragma checksum "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\ContactInfo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c9a1bf0cda6aaa5717abc4875f99d31502c667d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContactInfo_Index), @"mvc.1.0.view", @"/Views/ContactInfo/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c9a1bf0cda6aaa5717abc4875f99d31502c667d", @"/Views/ContactInfo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_ContactInfo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Contact>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\ContactInfo\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLAyout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n");
#nullable restore
#line 10 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\ContactInfo\Index.cshtml"
             using (Html.BeginForm("Index", "ContactInfo", FormMethod.Post, new { enctype = "multipart/form-data" }))
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n");
#nullable restore
#line 15 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\ContactInfo\Index.cshtml"
           Write(Html.HiddenFor(x => x.ContactID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\ContactInfo\Index.cshtml"
           Write(Html.Label("Başlık"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\ContactInfo\Index.cshtml"
           Write(Html.TextBoxFor(x => x.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\ContactInfo\Index.cshtml"
           Write(Html.ValidationMessageFor(x => x.Title, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n");
#nullable restore
#line 22 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\ContactInfo\Index.cshtml"
           Write(Html.Label("Açıklama"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\ContactInfo\Index.cshtml"
           Write(Html.TextAreaFor(x => x.Description, 6, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\ContactInfo\Index.cshtml"
           Write(Html.ValidationMessageFor(x => x.Description, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n");
#nullable restore
#line 29 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\ContactInfo\Index.cshtml"
           Write(Html.Label("Mail Adresi"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\ContactInfo\Index.cshtml"
           Write(Html.TextBoxFor(x => x.Mail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\ContactInfo\Index.cshtml"
           Write(Html.ValidationMessageFor(x => x.Mail, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n");
#nullable restore
#line 35 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\ContactInfo\Index.cshtml"
           Write(Html.Label("Telefon Numarası"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\ContactInfo\Index.cshtml"
           Write(Html.TextBoxFor(x => x.Phone, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\ContactInfo\Index.cshtml"
           Write(Html.ValidationMessageFor(x => x.Phone, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"d-flex justify-content-end mt-4\">\r\n                    <button type=\"submit\" class=\"btn btn-outline-primary px-4 py-2\">Güncelle</button>\r\n                </div>\r\n");
#nullable restore
#line 43 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\ContactInfo\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Contact> Html { get; private set; }
    }
}
#pragma warning restore 1591
