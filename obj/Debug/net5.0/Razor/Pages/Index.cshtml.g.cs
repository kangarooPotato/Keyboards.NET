#pragma checksum "/Users/hyunjunlee/Desktop/2021 SCC/2021 Fall/Introduction to ASP.NET/base/Keyboards/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65f45e158470c640848a7f2b49519c63f88e37b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Keyboards.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Keyboards.Pages
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
#line 1 "/Users/hyunjunlee/Desktop/2021 SCC/2021 Fall/Introduction to ASP.NET/base/Keyboards/Pages/_ViewImports.cshtml"
using Keyboards;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65f45e158470c640848a7f2b49519c63f88e37b3", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b31045a2063dc3501ad0af61b3a2b8cb635193a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/hyunjunlee/Desktop/2021 SCC/2021 Fall/Introduction to ASP.NET/base/Keyboards/Pages/Index.cshtml"
  
    ViewData["Title"] = "Keyboard World Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "/Users/hyunjunlee/Desktop/2021 SCC/2021 Fall/Introduction to ASP.NET/base/Keyboards/Pages/Index.cshtml"
  
    var quote = "The";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>");
#nullable restore
#line 11 "/Users/hyunjunlee/Desktop/2021 SCC/2021 Fall/Introduction to ASP.NET/base/Keyboards/Pages/Index.cshtml"
Write(quote);

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n\r\n<div class=\"text-center\">\r\n    <h4>Welcome to Keyboard World!</h4>\r\n    <p>The current time on the server is ");
#nullable restore
#line 15 "/Users/hyunjunlee/Desktop/2021 SCC/2021 Fall/Introduction to ASP.NET/base/Keyboards/Pages/Index.cshtml"
                                    Write(Model.todaysDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n");
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
