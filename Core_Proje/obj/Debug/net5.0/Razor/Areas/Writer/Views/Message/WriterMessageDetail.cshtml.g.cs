#pragma checksum "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Areas\Writer\Views\Message\WriterMessageDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70aeba0324b26867651d1ec125e8be23b5aa056e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Message_WriterMessageDetail), @"mvc.1.0.view", @"/Areas/Writer/Views/Message/WriterMessageDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70aeba0324b26867651d1ec125e8be23b5aa056e", @"/Areas/Writer/Views/Message/WriterMessageDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    public class Areas_Writer_Views_Message_WriterMessageDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.WriterMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Areas\Writer\Views\Message\WriterMessageDetail.cshtml"
  
    ViewData["Title"] = "WriterMessageDetail";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3 class=\"mb-4\">Mesaj Detayı</h3>\r\n\r\n<div class=\"form-group\">\r\n    ");
#nullable restore
#line 11 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Areas\Writer\Views\Message\WriterMessageDetail.cshtml"
Write(Html.HiddenFor(x => x.WriterMessageID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 12 "C:\Users\SSA\source\repos\asp.net-core-5\Core_Proje\Areas\Writer\Views\Message\WriterMessageDetail.cshtml"
Write(Html.TextAreaFor(x => x.MessageContent, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.WriterMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
