#pragma checksum "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a98edf602c1c277b2ad306cd097851f6d05f14d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
using PizzaPan.EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a98edf602c1c277b2ad306cd097851f6d05f14d", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0d532226de3f34c36d5be83c261d57e94b1fba7", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PizzaPan.EntityLayer.Concrete.Contact>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Contact\Index.cshtml"
  
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Mesaj Listesi</h3>
<hr />

<a href=""/Contact/GetMessageBtThanks/"" class=""btn btn-secondary"">Teşekkür Eden Kişiler</a>
<br />
<br />
<br />




<table class=""table table-striped"">
    <tr>
        <th>#</th>
        <th>Gönderen Adı</th>
        <th>Mail</th>
        <th>Konu</th>
        <th>Mesaj</th>
        <th>Gönderim Tarihi</th>
        <th></th>
        <th></th>


    </tr>

");
#nullable restore
#line 32 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Contact\Index.cshtml"
       int a = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Contact\Index.cshtml"
     foreach (var i in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 36 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Contact\Index.cshtml"
           Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Contact\Index.cshtml"
           Write(i.ContactName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Contact\Index.cshtml"
           Write(i.ContactMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Contact\Index.cshtml"
           Write(i.ContactSubject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 40 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Contact\Index.cshtml"
           Write(i.ContactMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 41 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Contact\Index.cshtml"
           Write(i.ContactSendDateMessage.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 885, "\"", 927, 2);
            WriteAttributeValue("", 892, "/Contact/DeleteContact/", 892, 23, true);
#nullable restore
#line 43 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Contact\Index.cshtml"
WriteAttributeValue("", 915, i.ContactId, 915, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary\">Mesajı Gör</a>\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1026, "\"", 1068, 2);
            WriteAttributeValue("", 1033, "/Contact/DeleteContact/", 1033, 23, true);
#nullable restore
#line 46 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Contact\Index.cshtml"
WriteAttributeValue("", 1056, i.ContactId, 1056, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a>\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 50 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Contact\Index.cshtml"

        a++;

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PizzaPan.EntityLayer.Concrete.Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
