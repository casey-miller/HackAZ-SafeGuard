#pragma checksum "/home/casey/Source/casey-github/HackAZ-SafeGuard/client/SafeGuard/SafeGuard/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6696c6357ae1561f30e836a400d5ad37c01be5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SafeGuard.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(SafeGuard.Pages.Pages_Index), null)]
namespace SafeGuard.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/casey/Source/casey-github/HackAZ-SafeGuard/client/SafeGuard/SafeGuard/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/home/casey/Source/casey-github/HackAZ-SafeGuard/client/SafeGuard/SafeGuard/Pages/_ViewImports.cshtml"
using SafeGuard;

#line default
#line hidden
#line 3 "/home/casey/Source/casey-github/HackAZ-SafeGuard/client/SafeGuard/SafeGuard/Pages/_ViewImports.cshtml"
using SafeGuard.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6696c6357ae1561f30e836a400d5ad37c01be5d", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc83b9f55823f888ef1524a7b418b3850fb7a1bd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/home/casey/Source/casey-github/HackAZ-SafeGuard/client/SafeGuard/SafeGuard/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(66, 327, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome to SafeGuard</h1>
<p>
    A project developed at Hack AZ 2020 <br/>
    Please see the git repo readme for more information <br/>
    <a href=""https://github.com/casey-miller/HackAZ-SafeGuard"" target=""_blank"">github.com/casey-miller/HackAZ-SafeGuard</a>
</p>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
