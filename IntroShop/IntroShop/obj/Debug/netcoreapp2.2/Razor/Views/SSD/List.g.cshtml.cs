#pragma checksum "C:\Users\frez70\Desktop\.NET CORE\IntroShop\IntroShop\Views\SSD\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd90bed8e8f6537542db7268c2f798c1fe585ef3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SSD_List), @"mvc.1.0.view", @"/Views/SSD/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SSD/List.cshtml", typeof(AspNetCore.Views_SSD_List))]
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
#line 1 "C:\Users\frez70\Desktop\.NET CORE\IntroShop\IntroShop\Views\_ViewImports.cshtml"
using IntroShop.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd90bed8e8f6537542db7268c2f798c1fe585ef3", @"/Views/SSD/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec0e6577b8a472a6f3f97109b9b7db67d94f347c", @"/Views/_ViewImports.cshtml")]
    public class Views_SSD_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\frez70\Desktop\.NET CORE\IntroShop\IntroShop\Views\SSD\List.cshtml"
  
    foreach (var item in Model.allSSDs)
    {

#line default
#line hidden
            BeginContext(52, 73, true);
            WriteLiteral("        <div class=\"product-block\">\r\n            <img class=\"phone-image\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 125, "\"", 140, 1);
#line 5 "C:\Users\frez70\Desktop\.NET CORE\IntroShop\IntroShop\Views\SSD\List.cshtml"
WriteAttributeValue("", 131, item.img, 131, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 141, "\"", 157, 1);
#line 5 "C:\Users\frez70\Desktop\.NET CORE\IntroShop\IntroShop\Views\SSD\List.cshtml"
WriteAttributeValue("", 147, item.name, 147, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(158, 73, true);
            WriteLiteral(" />\r\n            <div class=\"product-info\">\r\n                <h2>Vendor: ");
            EndContext();
            BeginContext(232, 9, false);
#line 7 "C:\Users\frez70\Desktop\.NET CORE\IntroShop\IntroShop\Views\SSD\List.cshtml"
                       Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(241, 39, true);
            WriteLiteral("</h2>\r\n                <p>Description: ");
            EndContext();
            BeginContext(281, 16, false);
#line 8 "C:\Users\frez70\Desktop\.NET CORE\IntroShop\IntroShop\Views\SSD\List.cshtml"
                           Write(item.description);

#line default
#line hidden
            EndContext();
            BeginContext(297, 32, true);
            WriteLiteral("</p>\r\n                <p>Price: ");
            EndContext();
            BeginContext(330, 10, false);
#line 9 "C:\Users\frez70\Desktop\.NET CORE\IntroShop\IntroShop\Views\SSD\List.cshtml"
                     Write(item.price);

#line default
#line hidden
            EndContext();
            BeginContext(340, 42, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 12 "C:\Users\frez70\Desktop\.NET CORE\IntroShop\IntroShop\Views\SSD\List.cshtml"
    }

#line default
#line hidden
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
