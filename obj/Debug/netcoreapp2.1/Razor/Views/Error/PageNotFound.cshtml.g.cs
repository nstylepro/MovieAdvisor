#pragma checksum "C:\Users\roeyb\Desktop\College\Apps\MovieAdvisor\Views\Error\PageNotFound.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c7960da5ec76bbe7932aeda219da02250fc445e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Error_PageNotFound), @"mvc.1.0.view", @"/Views/Error/PageNotFound.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Error/PageNotFound.cshtml", typeof(AspNetCore.Views_Error_PageNotFound))]
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
#line 1 "C:\Users\roeyb\Desktop\College\Apps\MovieAdvisor\Views\_ViewImports.cshtml"
using MovieLand;

#line default
#line hidden
#line 2 "C:\Users\roeyb\Desktop\College\Apps\MovieAdvisor\Views\_ViewImports.cshtml"
using MovieLand.Models;

#line default
#line hidden
#line 3 "C:\Users\roeyb\Desktop\College\Apps\MovieAdvisor\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c7960da5ec76bbe7932aeda219da02250fc445e", @"/Views/Error/PageNotFound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e98df24b14885a3b24f9f83daa27a259013803f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Error_PageNotFound : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\roeyb\Desktop\College\Apps\MovieAdvisor\Views\Error\PageNotFound.cshtml"
  
    ViewBag.Title = "404";

#line default
#line hidden
            BeginContext(35, 12, true);
            WriteLiteral("\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(47, 230, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b0cadd5a3e047aea4e47a71bd1f62e7", async() => {
                BeginContext(53, 217, true);
                WriteLiteral("\r\n    <section>\r\n        <h1>404 - Page not found</h1>\r\n        <aside>\r\n            <div class=\"pol\">\r\n\r\n            </div>\r\n        </aside>\r\n    </section>\r\n    <div class=\"box\">Oops, better check that URL.</div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(277, 518, true);
            WriteLiteral(@"

</html>

<style>
    .box {
        text-align: center;
        border-style: solid;
        border-width: 1px;
        display: block;
        width: 200px;
        margin: 0 auto;
        height: 100px;
        background-color: #03f61f;
        transition: width 3s, height 3s, background-color 3s, transform 3s;
    }

        .box:hover {
            background-color: #c7b5f5;
            width: 200px;
            height: 200px;
            transform: rotate(360deg);
        }
</style>");
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
