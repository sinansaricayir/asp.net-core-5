#pragma checksum "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17176654481ee045ad84cc8d504fcfd6ae554593"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TestimonialList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TestimonialList/Default.cshtml")]
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
#nullable restore
#line 1 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17176654481ee045ad84cc8d504fcfd6ae554593", @"/Views/Shared/Components/TestimonialList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TestimonialList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Testimonial>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"section px-3 px-lg-4 pt-5\" id=\"testimonials\">\r\n    <div class=\"container-narrow\">\r\n        <div class=\"text-center mb-5\">\r\n            <h2 class=\"marker marker-center\">Client Testimonials</h2>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-12 mb-5\" data-aos=\"fade-right\" data-aos-delay=\"100\">\r\n                    <div class=\"d-flex ms-md-3\"><span><i class=\"fas fa-2x fa-quote-left\"></i></span><span class=\"m-2\">");
#nullable restore
#line 13 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml"
                                                                                                                 Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                    <div class=\"d-flex justify-content-end align-items-end\">\r\n                        <div class=\"text-end me-2\">\r\n                            <div class=\"fw-bolder\">");
#nullable restore
#line 16 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml"
                                              Write(item.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div class=\"text-small\">");
#nullable restore
#line 17 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml"
                                               Write(item.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 17 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml"
                                                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div><img class=\"me-md-3 rounded\"");
            BeginWriteAttribute("src", " src=\"", 949, "\"", 987, 2);
            WriteAttributeValue("", 955, "/testimonialImage/", 955, 18, true);
#nullable restore
#line 18 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml"
WriteAttributeValue("", 973, item.ImageUrl, 973, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"96\" height=\"96\" alt=\"client 1\" />\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 21 "C:\Users\SSA\source\repos\AspNetCore5\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Testimonial>> Html { get; private set; }
    }
}
#pragma warning restore 1591
