#pragma checksum "/Users/davidbankys/Documents/GitHub/Web1001-Assignment/WebAssignments/WEB-FirstAssign/WEB-FirstAssign/Pages/Intro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "389512ea33cd6d895dcf7d7c6f3b7dde19b7154e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WEB_FirstAssign.Pages.Pages_Intro), @"mvc.1.0.razor-page", @"/Pages/Intro.cshtml")]
namespace WEB_FirstAssign.Pages
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
#line 1 "/Users/davidbankys/Documents/GitHub/Web1001-Assignment/WebAssignments/WEB-FirstAssign/WEB-FirstAssign/Pages/_ViewImports.cshtml"
using WEB_FirstAssign;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"389512ea33cd6d895dcf7d7c6f3b7dde19b7154e", @"/Pages/Intro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"905d76eb416e1c4173efc398f4373838a98cfcba", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Intro : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/davidbankys/Documents/GitHub/Web1001-Assignment/WebAssignments/WEB-FirstAssign/WEB-FirstAssign/Pages/Intro.cshtml"
              ViewData["Title"] = "Layout page";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>My Name Is David Bankole Abel</h1>\n\n\n");
            DefineSection("Section", async() => {
                WriteLiteral("\n<div class=\"text-center\">\n    <p>This is the section i created in my layout</p>\n</div>\n\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Intro> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Intro> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Intro>)PageContext?.ViewData;
        public Pages_Intro Model => ViewData.Model;
    }
}
#pragma warning restore 1591
