#pragma checksum "C:\Users\Oleksii_Manila\source\repos\mentoring_program_module_2\AsyncAwait.Task2.CodeReviewChallenge\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "275ccfcfb77323b2464d6bc6ec25f4d55b7aef10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Oleksii_Manila\source\repos\mentoring_program_module_2\AsyncAwait.Task2.CodeReviewChallenge\Views\_ViewImports.cshtml"
using AsyncAwait.Task2.CodeReviewChallenge;

#line default
#line hidden
#line 2 "C:\Users\Oleksii_Manila\source\repos\mentoring_program_module_2\AsyncAwait.Task2.CodeReviewChallenge\Views\_ViewImports.cshtml"
using AsyncAwait.Task2.CodeReviewChallenge.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"275ccfcfb77323b2464d6bc6ec25f4d55b7aef10", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a9ea5e569bfa5b4df78a240c9833e2aa26c4d55", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Oleksii_Manila\source\repos\mentoring_program_module_2\AsyncAwait.Task2.CodeReviewChallenge\Views\Home\Index.cshtml"
     
    ViewData["Title"] = "Home Page"; 

#line default
#line hidden
            BeginContext(49, 341, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome!</h1>
    
    <p>
        This application has the following working functions:
        <ul>
            <li>Menu: Home</li>
            <li>Menu: Privacy</li>
            <li>Menu: Help</li>
            <li>A counter of visits</li>
        </ul>
    </p>    
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
