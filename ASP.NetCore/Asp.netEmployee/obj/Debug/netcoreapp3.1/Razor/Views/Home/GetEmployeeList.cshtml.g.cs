#pragma checksum "C:\Users\Sadhik\source\repos\Asp.netEmployee\Views\Home\GetEmployeeList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59835fa50ce9ee0d1f9161a099ae6880a7a8ba52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetEmployeeList), @"mvc.1.0.view", @"/Views/Home/GetEmployeeList.cshtml")]
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
#line 1 "C:\Users\Sadhik\source\repos\Asp.netEmployee\Views\_ViewImports.cshtml"
using Asp.netEmployee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sadhik\source\repos\Asp.netEmployee\Views\_ViewImports.cshtml"
using Asp.netEmployee.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59835fa50ce9ee0d1f9161a099ae6880a7a8ba52", @"/Views/Home/GetEmployeeList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9184ddab347471bf5facaac2b3cb9d6872fa10b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetEmployeeList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Asp.netEmployee.Models.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Sadhik\source\repos\Asp.netEmployee\Views\Home\GetEmployeeList.cshtml"
  
    ViewData["Title"] = "GetEmployeeList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Employees List</h1>\r\n\r\n<div class=\"Row\">\r\n\r\n\r\n    <span class=\"col-md-4\">\r\n        Name\r\n    </span>\r\n\r\n\r\n    <span class=\"col-md-4\">\r\n        Salary\r\n    </span>\r\n\r\n\r\n\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 27 "C:\Users\Sadhik\source\repos\Asp.netEmployee\Views\Home\GetEmployeeList.cshtml"
 foreach (var item in Model)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Sadhik\source\repos\Asp.netEmployee\Views\Home\GetEmployeeList.cshtml"
     if (@item.IsPermanent)
    {



#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"Row\">\r\n\r\n\r\n            <span class=\"col-md-4\">\r\n                <mark class=\"alert-danger\">\r\n                    ");
#nullable restore
#line 38 "C:\Users\Sadhik\source\repos\Asp.netEmployee\Views\Home\GetEmployeeList.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </mark>\r\n            </span>\r\n\r\n\r\n            <span class=\"col-md-4\">\r\n                <mark class=\"alert-danger\">\r\n\r\n                    ");
#nullable restore
#line 46 "C:\Users\Sadhik\source\repos\Asp.netEmployee\Views\Home\GetEmployeeList.cshtml"
               Write(item.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </mark>\r\n            </span>\r\n        </div>\r\n");
#nullable restore
#line 50 "C:\Users\Sadhik\source\repos\Asp.netEmployee\Views\Home\GetEmployeeList.cshtml"


    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"Row\">\r\n\r\n\r\n            <span class=\"col-md-4\">\r\n                ");
#nullable restore
#line 59 "C:\Users\Sadhik\source\repos\Asp.netEmployee\Views\Home\GetEmployeeList.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </span>\r\n\r\n\r\n            <span class=\"col-md-4\">\r\n                ");
#nullable restore
#line 64 "C:\Users\Sadhik\source\repos\Asp.netEmployee\Views\Home\GetEmployeeList.cshtml"
           Write(item.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </span>\r\n        </div>\r\n");
#nullable restore
#line 67 "C:\Users\Sadhik\source\repos\Asp.netEmployee\Views\Home\GetEmployeeList.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\Sadhik\source\repos\Asp.netEmployee\Views\Home\GetEmployeeList.cshtml"
     




}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Asp.netEmployee.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
