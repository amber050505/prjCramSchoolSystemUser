#pragma checksum "D:\prjuser\prjCramSchoolSystemUser\Areas\Identity\Pages\Account\Lockout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccf057b37276660a4c3325be8a1af1c80b4e309c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Lockout), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Lockout.cshtml")]
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
#line 1 "D:\prjuser\prjCramSchoolSystemUser\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\prjuser\prjCramSchoolSystemUser\Areas\Identity\Pages\_ViewImports.cshtml"
using prjCramSchoolSystemUser.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\prjuser\prjCramSchoolSystemUser\Areas\Identity\Pages\_ViewImports.cshtml"
using prjCramSchoolSystemUser.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\prjuser\prjCramSchoolSystemUser\Areas\Identity\Pages\_ViewImports.cshtml"
using prjCramSchoolSystemUser.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\prjuser\prjCramSchoolSystemUser\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using prjCramSchoolSystemUser.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccf057b37276660a4c3325be8a1af1c80b4e309c", @"/Areas/Identity/Pages/Account/Lockout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b964cafe291201852c4a327002a2a83bb058261f", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7d42fad0a9cd5161069d640b11b5f5f85e2c4c5", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Lockout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\prjuser\prjCramSchoolSystemUser\Areas\Identity\Pages\Account\Lockout.cshtml"
  
    ViewData["Title"] = "帳號已被鎖定";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header>\r\n    <h1 class=\"text-danger\">");
#nullable restore
#line 8 "D:\prjuser\prjCramSchoolSystemUser\Areas\Identity\Pages\Account\Lockout.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p class=\"text-danger\">此帳號已被鎖定，請稍後再嘗試。</p>\r\n</header>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LockoutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LockoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LockoutModel>)PageContext?.ViewData;
        public LockoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591