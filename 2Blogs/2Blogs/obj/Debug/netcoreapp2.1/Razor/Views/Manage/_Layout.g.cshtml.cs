#pragma checksum "D:\study\5sem\ИТиРОД\Lab2\ASP.NETCOREMVCPROJECT\2Blogs\2Blogs\Views\Manage\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6277bba2b0926ce4b08db21f7b89b457e5f229f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage__Layout), @"mvc.1.0.view", @"/Views/Manage/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/_Layout.cshtml", typeof(AspNetCore.Views_Manage__Layout))]
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
#line 1 "D:\study\5sem\ИТиРОД\Lab2\ASP.NETCOREMVCPROJECT\2Blogs\2Blogs\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\study\5sem\ИТиРОД\Lab2\ASP.NETCOREMVCPROJECT\2Blogs\2Blogs\Views\_ViewImports.cshtml"
using _2Blogs;

#line default
#line hidden
#line 3 "D:\study\5sem\ИТиРОД\Lab2\ASP.NETCOREMVCPROJECT\2Blogs\2Blogs\Views\_ViewImports.cshtml"
using _2Blogs.Models;

#line default
#line hidden
#line 4 "D:\study\5sem\ИТиРОД\Lab2\ASP.NETCOREMVCPROJECT\2Blogs\2Blogs\Views\_ViewImports.cshtml"
using _2Blogs.Models.AccountViewModels;

#line default
#line hidden
#line 5 "D:\study\5sem\ИТиРОД\Lab2\ASP.NETCOREMVCPROJECT\2Blogs\2Blogs\Views\_ViewImports.cshtml"
using _2Blogs.Models.ManageViewModels;

#line default
#line hidden
#line 6 "D:\study\5sem\ИТиРОД\Lab2\ASP.NETCOREMVCPROJECT\2Blogs\2Blogs\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 7 "D:\study\5sem\ИТиРОД\Lab2\ASP.NETCOREMVCPROJECT\2Blogs\2Blogs\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#line 1 "D:\study\5sem\ИТиРОД\Lab2\ASP.NETCOREMVCPROJECT\2Blogs\2Blogs\Views\Manage\_ViewImports.cshtml"
using _2Blogs.Views.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6277bba2b0926ce4b08db21f7b89b457e5f229f", @"/Views/Manage/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9b278290a2f13e701e19e6288f3157cf2570c7c", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"720ca9016e56a6fbb5792388e5d2743911f05d63", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\study\5sem\ИТиРОД\Lab2\ASP.NETCOREMVCPROJECT\2Blogs\2Blogs\Views\Manage\_Layout.cshtml"
   
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(54, 237, true);
            WriteLiteral("<div class=\"container\">\r\n    <hr class=\"my-4\">\r\n    <h2>Manage your account</h2>\r\n\r\n    <div>\r\n        <h4>Change your account settings</h4>\r\n        <hr />\r\n        <div class=\"row\">\r\n            <div class=\"col-md-9\">\r\n                ");
            EndContext();
            BeginContext(292, 12, false);
#line 13 "D:\study\5sem\ИТиРОД\Lab2\ASP.NETCOREMVCPROJECT\2Blogs\2Blogs\Views\Manage\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(304, 60, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(382, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(389, 41, false);
#line 20 "D:\study\5sem\ИТиРОД\Lab2\ASP.NETCOREMVCPROJECT\2Blogs\2Blogs\Views\Manage\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(430, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(435, 10, true);
            WriteLiteral("        \r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
