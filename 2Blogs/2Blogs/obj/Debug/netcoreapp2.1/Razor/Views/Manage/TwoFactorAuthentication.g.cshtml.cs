#pragma checksum "D:\labs\Igi\2Blogs\2Blogs\2Blogs\Views\Manage\TwoFactorAuthentication.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f79132871a7f270c09a1bcbf6a4dc464ce6ec462"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_TwoFactorAuthentication), @"mvc.1.0.view", @"/Views/Manage/TwoFactorAuthentication.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/TwoFactorAuthentication.cshtml", typeof(AspNetCore.Views_Manage_TwoFactorAuthentication))]
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
#line 1 "D:\labs\Igi\2Blogs\2Blogs\2Blogs\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\labs\Igi\2Blogs\2Blogs\2Blogs\Views\_ViewImports.cshtml"
using _2Blogs;

#line default
#line hidden
#line 3 "D:\labs\Igi\2Blogs\2Blogs\2Blogs\Views\_ViewImports.cshtml"
using _2Blogs.Models;

#line default
#line hidden
#line 4 "D:\labs\Igi\2Blogs\2Blogs\2Blogs\Views\_ViewImports.cshtml"
using _2Blogs.Models.AccountViewModels;

#line default
#line hidden
#line 5 "D:\labs\Igi\2Blogs\2Blogs\2Blogs\Views\_ViewImports.cshtml"
using _2Blogs.Models.ManageViewModels;

#line default
#line hidden
#line 6 "D:\labs\Igi\2Blogs\2Blogs\2Blogs\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 7 "D:\labs\Igi\2Blogs\2Blogs\2Blogs\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#line 1 "D:\labs\Igi\2Blogs\2Blogs\2Blogs\Views\Manage\_ViewImports.cshtml"
using _2Blogs.Views.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f79132871a7f270c09a1bcbf6a4dc464ce6ec462", @"/Views/Manage/TwoFactorAuthentication.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9b278290a2f13e701e19e6288f3157cf2570c7c", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"720ca9016e56a6fbb5792388e5d2743911f05d63", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage_TwoFactorAuthentication : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TwoFactorAuthenticationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GenerateRecoveryCodes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Disable2faWarning", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GenerateRecoveryCodesWarning", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EnableAuthenticator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ResetAuthenticatorWarning", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\labs\Igi\2Blogs\2Blogs\2Blogs\Views\Manage\TwoFactorAuthentication.cshtml"
  
    ViewData["Title"] = "Two-factor authentication";
    ViewData.AddActivePage(ManageNavPages.TwoFactorAuthentication);

#line default
#line hidden
            BeginContext(171, 6, true);
            WriteLiteral("\r\n<h4>");
            EndContext();
            BeginContext(178, 17, false);
#line 7 "D:\labs\Igi\2Blogs\2Blogs\2Blogs\Views\Manage\TwoFactorAuthentication.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(195, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 8 "D:\labs\Igi\2Blogs\2Blogs\2Blogs\Views\Manage\TwoFactorAuthentication.cshtml"
 if (Model.Is2faEnabled)
{
    if (Model.RecoveryCodesLeft == 0)
    {

#line default
#line hidden
            BeginContext(277, 129, true);
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <strong>You have no recovery codes left.</strong>\r\n            <p>You must ");
            EndContext();
            BeginContext(406, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e868265908c40aab1d58942b1e1b841", async() => {
                BeginContext(444, 36, true);
                WriteLiteral("generate a new set of recovery codes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(484, 66, true);
            WriteLiteral(" before you can log in with a recovery code.</p>\r\n        </div>\r\n");
            EndContext();
#line 16 "D:\labs\Igi\2Blogs\2Blogs\2Blogs\Views\Manage\TwoFactorAuthentication.cshtml"
    }
    else if (Model.RecoveryCodesLeft == 1)
    {

#line default
#line hidden
            BeginContext(608, 126, true);
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <strong>You have 1 recovery code left.</strong>\r\n            <p>You can ");
            EndContext();
            BeginContext(734, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a60dcbd87b31421c884757e0cd5cdaf1", async() => {
                BeginContext(772, 36, true);
                WriteLiteral("generate a new set of recovery codes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(812, 23, true);
            WriteLiteral(".</p>\r\n        </div>\r\n");
            EndContext();
#line 23 "D:\labs\Igi\2Blogs\2Blogs\2Blogs\Views\Manage\TwoFactorAuthentication.cshtml"
    }
    else if (Model.RecoveryCodesLeft <= 3)
    {

#line default
#line hidden
            BeginContext(893, 72, true);
            WriteLiteral("        <div class=\"alert alert-warning\">\r\n            <strong>You have ");
            EndContext();
            BeginContext(966, 23, false);
#line 27 "D:\labs\Igi\2Blogs\2Blogs\2Blogs\Views\Manage\TwoFactorAuthentication.cshtml"
                        Write(Model.RecoveryCodesLeft);

#line default
#line hidden
            EndContext();
            BeginContext(989, 58, true);
            WriteLiteral(" recovery codes left.</strong>\r\n            <p>You should ");
            EndContext();
            BeginContext(1047, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0344f628fee477db7dfeb7a18c90998", async() => {
                BeginContext(1085, 36, true);
                WriteLiteral("generate a new set of recovery codes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1125, 23, true);
            WriteLiteral(".</p>\r\n        </div>\r\n");
            EndContext();
#line 30 "D:\labs\Igi\2Blogs\2Blogs\2Blogs\Views\Manage\TwoFactorAuthentication.cshtml"
    }


#line default
#line hidden
            BeginContext(1157, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1161, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb04dd2e04e942419f74f7ba1211a8e3", async() => {
                BeginContext(1219, 11, true);
                WriteLiteral("Disable 2FA");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1234, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1240, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acd13f3667524e1cb2f7e380c3719871", async() => {
                BeginContext(1309, 20, true);
                WriteLiteral("Reset recovery codes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1333, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 34 "D:\labs\Igi\2Blogs\2Blogs\2Blogs\Views\Manage\TwoFactorAuthentication.cshtml"
}

#line default
#line hidden
            BeginContext(1338, 30, true);
            WriteLiteral("\r\n<h5>Authenticator app</h5>\r\n");
            EndContext();
#line 37 "D:\labs\Igi\2Blogs\2Blogs\2Blogs\Views\Manage\TwoFactorAuthentication.cshtml"
 if (!Model.HasAuthenticator)
{

#line default
#line hidden
            BeginContext(1402, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1406, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14f22825094543d4badd9e366a2de110", async() => {
                BeginContext(1466, 21, true);
                WriteLiteral("Add authenticator app");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1491, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 40 "D:\labs\Igi\2Blogs\2Blogs\2Blogs\Views\Manage\TwoFactorAuthentication.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1505, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1509, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "985678803257412e913c2ad2eb06d49e", async() => {
                BeginContext(1569, 27, true);
                WriteLiteral("Configure authenticator app");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1600, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1606, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "733716a99f9a4014a868b6aea5c40472", async() => {
                BeginContext(1672, 23, true);
                WriteLiteral("Reset authenticator key");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1699, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 45 "D:\labs\Igi\2Blogs\2Blogs\2Blogs\Views\Manage\TwoFactorAuthentication.cshtml"
}

#line default
#line hidden
            BeginContext(1704, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1724, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1731, 52, false);
#line 48 "D:\labs\Igi\2Blogs\2Blogs\2Blogs\Views\Manage\TwoFactorAuthentication.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(1783, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TwoFactorAuthenticationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
