#pragma checksum "C:\Users\frez70\Desktop\.NET CORE\IntroShop\IntroShop\Views\Phone\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0b6ef9ed2ca96b95150308c58cee3fb53b075a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Phone_List), @"mvc.1.0.view", @"/Views/Phone/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Phone/List.cshtml", typeof(AspNetCore.Views_Phone_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0b6ef9ed2ca96b95150308c58cee3fb53b075a2", @"/Views/Phone/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec0e6577b8a472a6f3f97109b9b7db67d94f347c", @"/Views/_ViewImports.cshtml")]
    public class Views_Phone_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\frez70\Desktop\.NET CORE\IntroShop\IntroShop\Views\Phone\List.cshtml"
  
    foreach (var item in Model.allPhones)
    {

#line default
#line hidden
            BeginContext(54, 59, true);
            WriteLiteral("            <div>\r\n                <img class=\"phone-image\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 113, "\"", 128, 1);
#line 5 "C:\Users\frez70\Desktop\.NET CORE\IntroShop\IntroShop\Views\Phone\List.cshtml"
WriteAttributeValue("", 119, item.img, 119, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 129, "\"", 145, 1);
#line 5 "C:\Users\frez70\Desktop\.NET CORE\IntroShop\IntroShop\Views\Phone\List.cshtml"
WriteAttributeValue("", 135, item.name, 135, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(146, 34, true);
            WriteLiteral(" />\r\n\r\n                <a>Vendor: ");
            EndContext();
            BeginContext(181, 9, false);
#line 7 "C:\Users\frez70\Desktop\.NET CORE\IntroShop\IntroShop\Views\Phone\List.cshtml"
                      Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(190, 38, true);
            WriteLiteral("</a>\r\n                <a>Description: ");
            EndContext();
            BeginContext(229, 16, false);
#line 8 "C:\Users\frez70\Desktop\.NET CORE\IntroShop\IntroShop\Views\Phone\List.cshtml"
                           Write(item.description);

#line default
#line hidden
            EndContext();
            BeginContext(245, 32, true);
            WriteLiteral("</a>\r\n                <a>Price: ");
            EndContext();
            BeginContext(278, 10, false);
#line 9 "C:\Users\frez70\Desktop\.NET CORE\IntroShop\IntroShop\Views\Phone\List.cshtml"
                     Write(item.price);

#line default
#line hidden
            EndContext();
            BeginContext(288, 26, true);
            WriteLiteral("</a>\r\n            </div>\r\n");
            EndContext();
#line 11 "C:\Users\frez70\Desktop\.NET CORE\IntroShop\IntroShop\Views\Phone\List.cshtml"


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
