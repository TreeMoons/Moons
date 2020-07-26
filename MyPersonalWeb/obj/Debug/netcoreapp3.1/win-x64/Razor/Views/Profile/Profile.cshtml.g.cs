#pragma checksum "E:\Html\MyWork\MyPersonalWeb\Views\Profile\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb5f74030e447584d0f901232ff96210adc3068a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Profile), @"mvc.1.0.view", @"/Views/Profile/Profile.cshtml")]
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
#line 1 "E:\Html\MyWork\MyPersonalWeb\Views\_ViewImports.cshtml"
using MyPersonalWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Html\MyWork\MyPersonalWeb\Views\_ViewImports.cshtml"
using MyPersonalWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Html\MyWork\MyPersonalWeb\Views\_ViewImports.cshtml"
using ModelsLibrary.Languages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Html\MyWork\MyPersonalWeb\Views\_ViewImports.cshtml"
using ModelsLibrary.Languages.MainViews;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb5f74030e447584d0f901232ff96210adc3068a", @"/Views/Profile/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d85b3321ebb7e5cfdadd7ff87d4d7b0dbc4cba5", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-pic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/src/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "E:\Html\MyWork\MyPersonalWeb\Views\Profile\Profile.cshtml"
  
    var languageProfile=(Language.Profile)Utils.Languages[ViewBag.lang][nameof(Language.Profile)];

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"profile-container\">\r\n    <aside class=\"left-aside\">\r\n        <div class=\"list\">\r\n            <div><a");
            BeginWriteAttribute("href", " href=\"", 219, "\"", 256, 3);
            WriteAttributeValue("", 226, "/", 226, 1, true);
#nullable restore
#line 7 "E:\Html\MyWork\MyPersonalWeb\Views\Profile\Profile.cshtml"
WriteAttributeValue("", 227, ViewBag.lang, 227, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 240, "/profile/profile", 240, 16, true);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bb5f74030e447584d0f901232ff96210adc3068a4934", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 313, "用户：", 313, 3, true);
#nullable restore
#line 7 "E:\Html\MyWork\MyPersonalWeb\Views\Profile\Profile.cshtml"
AddHtmlAttributeValue("", 316, ViewBag.UserName, 316, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n            </div>\r\n            <div>\r\n                用户：<a");
            BeginWriteAttribute("href", " href=\"", 401, "\"", 438, 3);
            WriteAttributeValue("", 408, "/", 408, 1, true);
#nullable restore
#line 10 "E:\Html\MyWork\MyPersonalWeb\Views\Profile\Profile.cshtml"
WriteAttributeValue("", 409, ViewBag.lang, 409, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 422, "/profile/profile", 422, 16, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 10 "E:\Html\MyWork\MyPersonalWeb\Views\Profile\Profile.cshtml"
                                                       Write(ViewBag.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </div>\r\n");
            WriteLiteral("            <div><a");
            BeginWriteAttribute("href", " href=\"", 526, "\"", 533, 0);
            EndWriteAttribute();
            WriteLiteral(">修改资料</a></div>\r\n");
            WriteLiteral("            <div><a");
            BeginWriteAttribute("href", " href=\"", 594, "\"", 601, 0);
            EndWriteAttribute();
            WriteLiteral(">我的设置</a></div>\r\n");
            WriteLiteral("            <div><a");
            BeginWriteAttribute("href", " href=\"", 662, "\"", 669, 0);
            EndWriteAttribute();
            WriteLiteral(">账号安全</a></div>\r\n");
            WriteLiteral("            <div><a");
            BeginWriteAttribute("href", " href=\"", 725, "\"", 732, 0);
            EndWriteAttribute();
            WriteLiteral("></a></div>\r\n            <div><a");
            BeginWriteAttribute("href", " href=\"", 765, "\"", 772, 0);
            EndWriteAttribute();
            WriteLiteral("></a></div>\r\n            <div><a");
            BeginWriteAttribute("href", " href=\"", 805, "\"", 812, 0);
            EndWriteAttribute();
            WriteLiteral("></a></div>\r\n        </div>\r\n    </aside>\r\n    <div class=\"center-context\">\r\n\r\n\r\n    </div>\r\n    <aside class=\"right-aside\">\r\n");
            WriteLiteral("    </aside>\r\n</div>");
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