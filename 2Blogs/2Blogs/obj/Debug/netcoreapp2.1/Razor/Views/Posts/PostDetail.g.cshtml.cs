#pragma checksum "D:\study\5sem\ИТиРОД\Lab2\ASP.NETCOREMVCPROJECT\2Blogs\2Blogs\Views\Posts\PostDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66df74538180431a60ff158f23c93354f55e32af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_PostDetail), @"mvc.1.0.view", @"/Views/Posts/PostDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Posts/PostDetail.cshtml", typeof(AspNetCore.Views_Posts_PostDetail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66df74538180431a60ff158f23c93354f55e32af", @"/Views/Posts/PostDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9b278290a2f13e701e19e6288f3157cf2570c7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_PostDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_2Blogs.Models.PostViewModels.PostDetailViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\study\5sem\ИТиРОД\Lab2\ASP.NETCOREMVCPROJECT\2Blogs\2Blogs\Views\Posts\PostDetail.cshtml"
  
    ViewData["Title"] = "PostDetails";

#line default
#line hidden
            BeginContext(105, 54, true);
            WriteLiteral("<div class=\"container\">\r\n    <h2 class=\"text-center\"> ");
            EndContext();
            BeginContext(160, 11, false);
#line 6 "D:\study\5sem\ИТиРОД\Lab2\ASP.NETCOREMVCPROJECT\2Blogs\2Blogs\Views\Posts\PostDetail.cshtml"
                        Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(171, 70, true);
            WriteLiteral("</h2>\r\n    <hr class=\"my-4\">\r\n    <div class=\"blog-post\">\r\n        <p>");
            EndContext();
            BeginContext(242, 17, false);
#line 9 "D:\study\5sem\ИТиРОД\Lab2\ASP.NETCOREMVCPROJECT\2Blogs\2Blogs\Views\Posts\PostDetail.cshtml"
      Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(259, 65, true);
            WriteLiteral("</p>\r\n        <h2 class=\"text-center\">Comments</h2>\r\n    </div>\r\n");
            EndContext();
            BeginContext(1361, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_2Blogs.Models.PostViewModels.PostDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
