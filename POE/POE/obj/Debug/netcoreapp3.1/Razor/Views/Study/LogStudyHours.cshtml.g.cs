#pragma checksum "C:\Users\Thabang\Downloads\School\2nd year\PROG2\POE\POE\Views\Study\LogStudyHours.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7fa6e0ad09e686c825d4c9b9556c8fb16b1ee5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Study_LogStudyHours), @"mvc.1.0.view", @"/Views/Study/LogStudyHours.cshtml")]
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
#line 1 "C:\Users\Thabang\Downloads\School\2nd year\PROG2\POE\POE\Views\_ViewImports.cshtml"
using POE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Thabang\Downloads\School\2nd year\PROG2\POE\POE\Views\_ViewImports.cshtml"
using POE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7fa6e0ad09e686c825d4c9b9556c8fb16b1ee5b", @"/Views/Study/LogStudyHours.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c89340c34361a7c102e01f2c0a92e92f5bf34e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Study_LogStudyHours : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Thabang\Downloads\School\2nd year\PROG2\POE\POE\Views\Study\LogStudyHours.cshtml"
  
    ViewData["Title"] = "Log Hours Page";
    Layout = "StudyLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container mt-5"">
    <div class=""row justify-content-center align-items-center"">
        <div class=""col-sm-12 col-md-12 col-lg-4"">
            <h1 class="" mb-3"">Log Study Hours </h1>
            <p> Enter the hours spent working &#xA;on a specific module on a&#xA;certain day:</p>
            <div class=""form-group mt-2"">
                <label for=""inputModuleClassHours"">Number of hours</label>
                <input type=""text"" class=""form-control"" id=""inputHours"" placeholder=""0"">
            </div>
            <div class=""form-group mt-2"">
                <label for=""inputModuleName"">Module Name</label>
                <input type=""text"" class=""form-control"" id=""inputModName"" placeholder=""Module Name"">
            </div>
            <div class=""form-group mt-2"">
                <label for=""inputModuleClassHours""> Date</label>
                <input type=""text"" class=""form-control"" id=""inputDate"" placeholder=""dd/mm/yy"">
            </div>
            <div class=""mb-3"">
    ");
            WriteLiteral("            <button type=\"submit\" class=\"btn btn-primary\">SUBMIT</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
