#pragma checksum "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Areas\Admin\Views\ApiExchange\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "075a0dc116ab0af3135208f81cd508f5c897337e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ApiExchange_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ApiExchange/Index.cshtml")]
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
#line 1 "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Areas\Admin\Views\_ViewImports.cshtml"
using Traversal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Areas\Admin\Views\_ViewImports.cshtml"
using Traversal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Areas\Admin\Views\_ViewImports.cshtml"
using Traversal.ViewsModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"075a0dc116ab0af3135208f81cd508f5c897337e", @"/Areas/Admin/Views/ApiExchange/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e20fb38c3f65a54875188bcf06054c04eba34df1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ApiExchange_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookingExchange2VM.Exchange_Rates>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Api Booking Currency</h1>\r\n\r\n<table class=\"table table-striped\">\r\n\t<tr>\r\n\t\t<th>Ad</th>\r\n\t\t<th>Oran</th>\r\n\t</tr>\r\n");
#nullable restore
#line 10 "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Areas\Admin\Views\ApiExchange\Index.cshtml"
     foreach (var item in Model)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<tr>\n\t\t\t<td>");
#nullable restore
#line 13 "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Areas\Admin\Views\ApiExchange\Index.cshtml"
           Write(item.currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t<td>");
#nullable restore
#line 14 "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Areas\Admin\Views\ApiExchange\Index.cshtml"
           Write(item.exchange_rate_buy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t</tr>\n");
#nullable restore
#line 16 "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Areas\Admin\Views\ApiExchange\Index.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookingExchange2VM.Exchange_Rates>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591