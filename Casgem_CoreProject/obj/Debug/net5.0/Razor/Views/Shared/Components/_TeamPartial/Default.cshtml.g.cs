#pragma checksum "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Shared\Components\_TeamPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a23137c6a3959b1ccf1325e12e43d0457b6ba42a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__TeamPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_TeamPartial/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a23137c6a3959b1ccf1325e12e43d0457b6ba42a", @"/Views/Shared/Components/_TeamPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d49195478c77841c89864368974492922a190c99", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__TeamPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PizzaPan.EntityLayer.Concrete.OurTeam>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Templates/Vitrin/assets/images/team1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid radius-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Shared\Components\_TeamPartial\Default.cshtml"
     foreach (var i in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-lg-3 col-sm-6 mt-lg-5 mt-4\">\r\n        <div class=\"box16\">\r\n            <a href=\"#url\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a23137c6a3959b1ccf1325e12e43d0457b6ba42a5377", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
            <div class=""box-content"">
                <h3 class=""title""><a href=""#url"">Alexander</a></h3>
                <span class=""post"">Master chef</span>
                <ul class=""social"">
                    <li>
                        <a href=""#"" class=""facebook"">
                            <span class=""fa fa-facebook-f""></span>
                        </a>
                    </li>
                    <li>
                        <a href=""#"" class=""twitter"">
                            <span class=""fa fa-twitter""></span>
                        </a>
                    </li>
                </ul>
            </div>
        </div>
    </div>
");
#nullable restore
#line 27 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\casgem\Casgem_CoreProject\Casgem_CoreProject\Views\Shared\Components\_TeamPartial\Default.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PizzaPan.EntityLayer.Concrete.OurTeam>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591