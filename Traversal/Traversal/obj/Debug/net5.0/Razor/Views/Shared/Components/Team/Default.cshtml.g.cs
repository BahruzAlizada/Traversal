#pragma checksum "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Views\Shared\Components\Team\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99d19e7f094024982c7757e990a6b61a7211f7b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Team_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Team/Default.cshtml")]
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
#line 1 "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Views\_ViewImports.cshtml"
using Traversal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Views\_ViewImports.cshtml"
using Traversal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Views\_ViewImports.cshtml"
using Traversal.ViewsModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99d19e7f094024982c7757e990a6b61a7211f7b7", @"/Views/Shared/Components/Team/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e20fb38c3f65a54875188bcf06054c04eba34df1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Team_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Team>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Views\Shared\Components\Team\Default.cshtml"
 foreach(Team team in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-lg-3 col-6 mt-lg-5 mt-4\">\r\n        <div class=\"box16\">\r\n            <a href=\"#url\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "99d19e7f094024982c7757e990a6b61a7211f7b74730", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 165, "~/assets/images/", 165, 16, true);
#nullable restore
#line 6 "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Views\Shared\Components\Team\Default.cshtml"
AddHtmlAttributeValue("", 181, team.Image, 181, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n            <div class=\"box-content\">\r\n                <h3 class=\"title text-white\">");
#nullable restore
#line 8 "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Views\Shared\Components\Team\Default.cshtml"
                                        Write(team.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <span class=\"post\">");
#nullable restore
#line 9 "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Views\Shared\Components\Team\Default.cshtml"
                              Write(team.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <ul class=\"social\">\r\n                    <li>\r\n  \r\n                    </li>\r\n                    <li>\r\n                        \r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 21 "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Views\Shared\Components\Team\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Team>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
