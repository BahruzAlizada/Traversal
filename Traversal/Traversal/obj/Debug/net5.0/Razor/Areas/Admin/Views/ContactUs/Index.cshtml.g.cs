#pragma checksum "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Areas\Admin\Views\ContactUs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72c656796ac0b25c8198223bff860c715f2e8d33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ContactUs_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ContactUs/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72c656796ac0b25c8198223bff860c715f2e8d33", @"/Areas/Admin/Views/ContactUs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e20fb38c3f65a54875188bcf06054c04eba34df1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ContactUs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ContactForm>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Areas\Admin\Views\ContactUs\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<hr class=""my-5"" />


<!-- Bordered Table -->
<div class=""card"">
    <div class=""card-header"" style=""display:flex;justify-content:space-between"">
        <h2>
            Contact Us
        </h2>
    </div>
    <div class=""card-body"">
        <div class=""table-responsive text-nowrap"">
            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Name</th>
                        <th>Email</th>
                        <th>Subject</th>
                        <th>Created Time</th>
                        <th style=""text-align:right"">Actions</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 33 "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Areas\Admin\Views\ContactUs\Index.cshtml"
                     foreach(ContactForm item in Model)
                    {
                        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                       <td>");
#nullable restore
#line 37 "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Areas\Admin\Views\ContactUs\Index.cshtml"
                      Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                       <td>");
#nullable restore
#line 38 "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Areas\Admin\Views\ContactUs\Index.cshtml"
                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                       <td>");
#nullable restore
#line 39 "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Areas\Admin\Views\ContactUs\Index.cshtml"
                      Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                       <td>");
#nullable restore
#line 40 "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Areas\Admin\Views\ContactUs\Index.cshtml"
                      Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                       <td>");
#nullable restore
#line 41 "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Areas\Admin\Views\ContactUs\Index.cshtml"
                      Write(item.CreatedTime.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                        <td>
                         <div style=""display:flex;justify-content:flex-end"">
                         <a class=""btn btn-warning rounded-pill text-white"" style=""margin-right:10px"">Detail</a>
                         <a class=""btn btn-info rounded-pill text-white""style=""margin-right:10px"">Reply</a>
                         <a class=""btn btn-danger rounded-pill text-white""style=""margin-right:10px"">Delete</a>
                         </div>
                        </td>
                    </tr>
");
#nullable restore
#line 50 "C:\Users\Esma\Desktop\GitHub Project\Traversal\Traversal\Traversal\Areas\Admin\Views\ContactUs\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!--/ Bordered Table -->\r\n\r\n<hr class=\"my-5\" />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ContactForm>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
