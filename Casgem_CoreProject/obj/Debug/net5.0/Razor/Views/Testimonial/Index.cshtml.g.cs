#pragma checksum "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Testimonial\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41db5eede9c001b91a18ceb7be325fe2cc6f153e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Testimonial_Index), @"mvc.1.0.view", @"/Views/Testimonial/Index.cshtml")]
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
#line 1 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\_ViewImports.cshtml"
using Casgem_CoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\_ViewImports.cshtml"
using Casgem_CoreProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\_ViewImports.cshtml"
using PizzaPan.PresentationLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\_ViewImports.cshtml"
using PizzaPan.EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41db5eede9c001b91a18ceb7be325fe2cc6f153e", @"/Views/Testimonial/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d49195478c77841c89864368974492922a190c99", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Testimonial_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PizzaPan.EntityLayer.Concrete.Testimonial>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Testimonial\Index.cshtml"
  
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Yorum Listesi</h3>\r\n<hr />\r\n\r\n\r\n\r\n\r\n<table class=\"table table-striped\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Fotoğraf</th>\r\n        <th>Title</th>\r\n        <th>Adı</th>\r\n        <th>Yorum</th>\r\n        <th></th>\r\n\r\n\r\n    </tr>\r\n\r\n");
#nullable restore
#line 25 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Testimonial\Index.cshtml"
       int a = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Testimonial\Index.cshtml"
     foreach (var i in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 29 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Testimonial\Index.cshtml"
           Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 494, "\"", 511, 1);
#nullable restore
#line 31 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Testimonial\Index.cshtml"
WriteAttributeValue("", 500, i.ImageUrl, 500, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" />\r\n            </td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Testimonial\Index.cshtml"
           Write(i.CustomerTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Testimonial\Index.cshtml"
           Write(i.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Testimonial\Index.cshtml"
           Write(i.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 695, "\"", 749, 2);
            WriteAttributeValue("", 702, "/Testimonial/DeleteTestimonial/", 702, 31, true);
#nullable restore
#line 37 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Testimonial\Index.cshtml"
WriteAttributeValue("", 733, i.TestimonialId, 733, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a>\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 41 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Testimonial\Index.cshtml"

        a++;

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PizzaPan.EntityLayer.Concrete.Testimonial>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
