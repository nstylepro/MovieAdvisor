#pragma checksum "D:\MovieAdvisor\Views\Error\AppError.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77761eb97ec1e217a98d0c1a3deb29c08a81cbd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Error_AppError), @"mvc.1.0.view", @"/Views/Error/AppError.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Error/AppError.cshtml", typeof(AspNetCore.Views_Error_AppError))]
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
#line 1 "D:\MovieAdvisor\Views\_ViewImports.cshtml"
using MovieLand;

#line default
#line hidden
#line 2 "D:\MovieAdvisor\Views\_ViewImports.cshtml"
using MovieLand.Models;

#line default
#line hidden
#line 3 "D:\MovieAdvisor\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77761eb97ec1e217a98d0c1a3deb29c08a81cbd5", @"/Views/Error/AppError.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e98df24b14885a3b24f9f83daa27a259013803f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Error_AppError : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\MovieAdvisor\Views\Error\AppError.cshtml"
  
    ViewBag.Title = "Error occurred";

#line default
#line hidden
            BeginContext(46, 93, true);
            WriteLiteral("\r\n<h1>We have a problem</h1>\r\n\r\n<p>Sorry, an error occurred while executing your request.</p>");
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
