#pragma checksum "D:\SEDC\ASP.NET_MVC\AppHomework\AppHomework-3\homework-3\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb50dcea1e884eca299a19e37d3e572734ae46dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\SEDC\ASP.NET_MVC\AppHomework\AppHomework-3\homework-3\Views\_ViewImports.cshtml"
using homework_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SEDC\ASP.NET_MVC\AppHomework\AppHomework-3\homework-3\Views\_ViewImports.cshtml"
using homework_2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb50dcea1e884eca299a19e37d3e572734ae46dd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7539bed6cb851309a36cc547fc5bb03164f1ba21", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\SEDC\ASP.NET_MVC\AppHomework\AppHomework-3\homework-3\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n<!--View Model-->\r\n");
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 13 "D:\SEDC\ASP.NET_MVC\AppHomework\AppHomework-3\homework-3\Views\Home\Index.cshtml"
Write(Model.FullEmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<ul>\r\n    <li>Employee ID: ");
#nullable restore
#line 15 "D:\SEDC\ASP.NET_MVC\AppHomework\AppHomework-3\homework-3\Views\Home\Index.cshtml"
                Write(Model.EmployeeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>First Name: ");
#nullable restore
#line 16 "D:\SEDC\ASP.NET_MVC\AppHomework\AppHomework-3\homework-3\Views\Home\Index.cshtml"
               Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Last Name: ");
#nullable restore
#line 17 "D:\SEDC\ASP.NET_MVC\AppHomework\AppHomework-3\homework-3\Views\Home\Index.cshtml"
              Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Full Name: ");
#nullable restore
#line 18 "D:\SEDC\ASP.NET_MVC\AppHomework\AppHomework-3\homework-3\Views\Home\Index.cshtml"
              Write(Model.FullEmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Position: ");
#nullable restore
#line 19 "D:\SEDC\ASP.NET_MVC\AppHomework\AppHomework-3\homework-3\Views\Home\Index.cshtml"
             Write(Model.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>To Be: ");
#nullable restore
#line 20 "D:\SEDC\ASP.NET_MVC\AppHomework\AppHomework-3\homework-3\Views\Home\Index.cshtml"
          Write(Model.ToBePositioned);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Date of Hire: ");
#nullable restore
#line 21 "D:\SEDC\ASP.NET_MVC\AppHomework\AppHomework-3\homework-3\Views\Home\Index.cshtml"
                 Write(Model.DateOfHire);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Salary: ");
#nullable restore
#line 22 "D:\SEDC\ASP.NET_MVC\AppHomework\AppHomework-3\homework-3\Views\Home\Index.cshtml"
           Write(Model.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Division ID: ");
#nullable restore
#line 23 "D:\SEDC\ASP.NET_MVC\AppHomework\AppHomework-3\homework-3\Views\Home\Index.cshtml"
                Write(Model.DivisionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Division Name: ");
#nullable restore
#line 24 "D:\SEDC\ASP.NET_MVC\AppHomework\AppHomework-3\homework-3\Views\Home\Index.cshtml"
                  Write(Model.DivisionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
