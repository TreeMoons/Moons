#pragma checksum "E:\Html\MyWork\MyPersonalWeb\Views\Profile\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f80f6dba401373b82ebd384eb9c3e5703ca6739"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f80f6dba401373b82ebd384eb9c3e5703ca6739", @"/Views/Profile/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddeaa2972ab197f2412167ef66f2b4ed1c414263", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Html\MyWork\MyPersonalWeb\Views\Profile\Profile.cshtml"
  
    try {
        ViewData["Title"] = ViewBag.UserName??throw new Exception();
    } catch {
        throw;
    }
    (ModelsLibrary.Language language,object Models)=(ValueTuple<ModelsLibrary.Language,object>)Model;
    try{ 
        var languageIndex=(ModelsLibrary.Language.Index)language[nameof(ModelsLibrary.Language.Profile)];
    }catch(Exception ex){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        console.log(\'");
#nullable restore
#line 12 "E:\Html\MyWork\MyPersonalWeb\Views\Profile\Profile.cshtml"
                Write(ex.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\')\r\n    </script>\r\n");
#nullable restore
#line 14 "E:\Html\MyWork\MyPersonalWeb\Views\Profile\Profile.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    \r\n</div>");
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
