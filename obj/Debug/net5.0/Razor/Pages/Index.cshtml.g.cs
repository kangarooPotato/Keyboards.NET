#pragma checksum "/Users/hyunjunlee/Desktop/2021 SCC/2021 Fall/Introduction to ASP.NET/base/Keyboards/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c11786e27f22b0600b7683177cef07d91ed8db87"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c11786e27f22b0600b7683177cef07d91ed8db87", @"/Pages/Index.cshtml")]
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
#nullable restore
#line 6 "/Users/hyunjunlee/Desktop/2021 SCC/2021 Fall/Introduction to ASP.NET/base/Keyboards/Pages/Index.cshtml"
  
    var quote = "The letters in 'try' on a keyboard are much closer than the letters in 'quit'.";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "/Users/hyunjunlee/Desktop/2021 SCC/2021 Fall/Introduction to ASP.NET/base/Keyboards/Pages/Index.cshtml"
  
    var keyboardSwitchs = new [] {
        new {
            name = "click",
            type = "blue",
            pressure = 50
            },
        new {
            name = "linear",
            type = "red",
            pressure = 40
            },
        new {
            name = "tactile",
            type = "blown",
            pressure = 45
            }
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 30 "/Users/hyunjunlee/Desktop/2021 SCC/2021 Fall/Introduction to ASP.NET/base/Keyboards/Pages/Index.cshtml"
 for (var i = 0; i < keyboardSwitchs.Length; i++)
{
    var switchs = keyboardSwitchs[i];
    

#line default
#line hidden
#nullable disable
            WriteLiteral("Key Switch name : ");
#nullable restore
#line 33 "/Users/hyunjunlee/Desktop/2021 SCC/2021 Fall/Introduction to ASP.NET/base/Keyboards/Pages/Index.cshtml"
                       Write(switchs.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>");
            WriteLiteral("\r\n");
            WriteLiteral("Key Switch type : ");
#nullable restore
#line 34 "/Users/hyunjunlee/Desktop/2021 SCC/2021 Fall/Introduction to ASP.NET/base/Keyboards/Pages/Index.cshtml"
                       Write(switchs.type);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>");
            WriteLiteral("\r\n");
            WriteLiteral("Key pressure : ");
#nullable restore
#line 35 "/Users/hyunjunlee/Desktop/2021 SCC/2021 Fall/Introduction to ASP.NET/base/Keyboards/Pages/Index.cshtml"
                    Write(switchs.pressure);

#line default
#line hidden
#nullable disable
            WriteLiteral(" g<br><br>");
#nullable restore
#line 35 "/Users/hyunjunlee/Desktop/2021 SCC/2021 Fall/Introduction to ASP.NET/base/Keyboards/Pages/Index.cshtml"
                                                           
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <div style=\"color: orange;\">");
#nullable restore
#line 39 "/Users/hyunjunlee/Desktop/2021 SCC/2021 Fall/Introduction to ASP.NET/base/Keyboards/Pages/Index.cshtml"
                           Write(quote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div></br >\r\n\r\n    <h4>Welcome to Keyboard World!</h4>\r\n    <p>The current time on the server is ");
#nullable restore
#line 42 "/Users/hyunjunlee/Desktop/2021 SCC/2021 Fall/Introduction to ASP.NET/base/Keyboards/Pages/Index.cshtml"
                                    Write(Model.todaysDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
            WriteLiteral("@Username</p>\r\n    <p>e-mail me at w0770897");
            WriteLiteral("@myscc.ca</p>\r\n    &nbsp;\r\n    &lt;\r\n    <p>");
#nullable restore
#line 47 "/Users/hyunjunlee/Desktop/2021 SCC/2021 Fall/Introduction to ASP.NET/base/Keyboards/Pages/Index.cshtml"
  Write(DateTime.IsLeapYear(2016));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Last week this time: ");
#nullable restore
#line 48 "/Users/hyunjunlee/Desktop/2021 SCC/2021 Fall/Introduction to ASP.NET/base/Keyboards/Pages/Index.cshtml"
                            Write(DateTime.Now - TimeSpan.FromDays(7));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            ");
#nullable restore
#line 49 "/Users/hyunjunlee/Desktop/2021 SCC/2021 Fall/Introduction to ASP.NET/base/Keyboards/Pages/Index.cshtml"
        Write("<span>Hello span</span>");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 53 "/Users/hyunjunlee/Desktop/2021 SCC/2021 Fall/Introduction to ASP.NET/base/Keyboards/Pages/Index.cshtml"
      
        var value = 1000;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 57 "/Users/hyunjunlee/Desktop/2021 SCC/2021 Fall/Introduction to ASP.NET/base/Keyboards/Pages/Index.cshtml"
     if (value % 2 == 0)    // 7 / 2 = 3
                            // 7 % 2 = 1
                            // 13 % 7 = 6
                            // 6 % 2 = 0
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>The value variable is even</p>\r\n");
#nullable restore
#line 63 "/Users/hyunjunlee/Desktop/2021 SCC/2021 Fall/Introduction to ASP.NET/base/Keyboards/Pages/Index.cshtml"
    }
    else if (value >= 9000)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>The value variable is OVER 9000!</p>\r\n");
#nullable restore
#line 67 "/Users/hyunjunlee/Desktop/2021 SCC/2021 Fall/Introduction to ASP.NET/base/Keyboards/Pages/Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>The value variable is neither even not over 9000</p>\r\n");
#nullable restore
#line 71 "/Users/hyunjunlee/Desktop/2021 SCC/2021 Fall/Introduction to ASP.NET/base/Keyboards/Pages/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div>\r\n        Email: <input type=\"email\" id=\"Email\"");
            BeginWriteAttribute("value", " value=\"", 1810, "\"", 1818, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <button>Reggister</button>\r\n    </div>\r\n\r\n</div>");
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