#pragma checksum "C:\Users\Sadhik\source\repos\Asp.netOrganisations\Views\Home\Organisations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b58803ac429fbc9d2ed8c5e875b80954f108955d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Organisations), @"mvc.1.0.view", @"/Views/Home/Organisations.cshtml")]
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
#line 1 "C:\Users\Sadhik\source\repos\Asp.netOrganisations\Views\_ViewImports.cshtml"
using Asp.netOrganisations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sadhik\source\repos\Asp.netOrganisations\Views\_ViewImports.cshtml"
using Asp.netOrganisations.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b58803ac429fbc9d2ed8c5e875b80954f108955d", @"/Views/Home/Organisations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d43bad817c2709f56b1368c6415fa526050c3820", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Organisations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Sadhik\source\repos\Asp.netOrganisations\Views\Home\Organisations.cshtml"
  
    ViewData["Title"] = "Organisations";
    Layout = "~/Views/Shared/_Layout.cshtml";
    List<string> organizations = new List<string> { "Amazon", " TCS", "Google", "CTS www.cognizant.com", "Microsoft www. microsoft.com" };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ITOrganisations in Hyderabad</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Sadhik\source\repos\Asp.netOrganisations\Views\Home\Organisations.cshtml"
 foreach (var company in organizations)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <span>\r\n");
#nullable restore
#line 14 "C:\Users\Sadhik\source\repos\Asp.netOrganisations\Views\Home\Organisations.cshtml"
             if (company == "Amazon")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <b>");
#nullable restore
#line 16 "C:\Users\Sadhik\source\repos\Asp.netOrganisations\Views\Home\Organisations.cshtml"
              Write(company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n");
#nullable restore
#line 17 "C:\Users\Sadhik\source\repos\Asp.netOrganisations\Views\Home\Organisations.cshtml"
            }
            else
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Sadhik\source\repos\Asp.netOrganisations\Views\Home\Organisations.cshtml"
           Write(company);

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Sadhik\source\repos\Asp.netOrganisations\Views\Home\Organisations.cshtml"
                        
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </span>\r\n    </div>\r\n");
#nullable restore
#line 25 "C:\Users\Sadhik\source\repos\Asp.netOrganisations\Views\Home\Organisations.cshtml"
}

#line default
#line hidden
#nullable disable
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
