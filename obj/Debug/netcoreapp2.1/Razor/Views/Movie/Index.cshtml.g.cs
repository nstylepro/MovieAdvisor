#pragma checksum "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d2e07ccfc3d18ea8acdf8b0ad371dbd6a12314a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/Index.cshtml", typeof(AspNetCore.Views_Movie_Index))]
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
#line 1 "C:\MovieAdvisor\MovieAdvisor\Views\_ViewImports.cshtml"
using MovieLand;

#line default
#line hidden
#line 2 "C:\MovieAdvisor\MovieAdvisor\Views\_ViewImports.cshtml"
using MovieLand.Models;

#line default
#line hidden
#line 3 "C:\MovieAdvisor\MovieAdvisor\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d2e07ccfc3d18ea8acdf8b0ad371dbd6a12314a", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e98df24b14885a3b24f9f83daa27a259013803f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieLand.Models.Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Buy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(87, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff91b1f15bf844c581780be168456217", async() => {
                BeginContext(93, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(99, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "02334b5963674fc0928f465a4672762e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(174, 5, true);
                WriteLiteral("   \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(186, 30, true);
            WriteLiteral("\r\n<h2>Movies</h2>\r\n\r\n\r\n\r\n<p>\r\n");
            EndContext();
#line 14 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
     if (User.IsInRole("Administrator"))
    {

#line default
#line hidden
            BeginContext(265, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(273, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe99eb4874c344c1b5528b286f2a5ea5", async() => {
                BeginContext(296, 13, true);
                WriteLiteral("Add New Movie");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(313, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(322, 152, true);
            WriteLiteral("</p>\r\n\r\n<div class=\"form-actions no-color\">\r\n    <p>\r\n        Price:\r\n        <!--search by price: populating the drop down list dynamicaly-->\r\n        ");
            EndContext();
            BeginContext(475, 116, false);
#line 24 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
   Write(Html.DropDownList("priceSearch", new SelectList(ViewBag.priceCategory, "Price"), "Any", new { @class = "dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(591, 102, true);
            WriteLiteral("\r\n\r\n        Genre:\r\n        <!--search by genre: populating the drop down list dynamicaly-->\r\n        ");
            EndContext();
            BeginContext(694, 109, false);
#line 28 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
   Write(Html.DropDownList("genreSearch", new SelectList(ViewBag.genres, "Genre"), "Any", new { @class = "dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(803, 108, true);
            WriteLiteral("\r\n\r\n        Director:\r\n        <!--search by director: populating the drop down list dynamicaly-->\r\n        ");
            EndContext();
            BeginContext(912, 118, false);
#line 32 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
   Write(Html.DropDownList("directorSearch", new SelectList(ViewBag.directors, "Director"), "Any", new { @class = "dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(1030, 100, true);
            WriteLiteral("\r\n\r\n        Year:\r\n        <!--search by year: populating the drop down list dynamicaly-->\r\n        ");
            EndContext();
            BeginContext(1131, 113, false);
#line 36 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
   Write(Html.DropDownList("yearSearch", new SelectList(ViewBag.yearCategory, "Year"), "Any", new { @class = "dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(1244, 34, true);
            WriteLiteral("\r\n\r\n        IMDB Rating:\r\n        ");
            EndContext();
            BeginContext(1279, 117, false);
#line 39 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
   Write(Html.DropDownList("ratingSearch", new SelectList(ViewBag.ratings, "IMDB Rating"), "Any", new { @class = "dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(1396, 96, true);
            WriteLiteral("\r\n\r\n        <!--search by year: populating the drop down list dynamicaly-->\r\n        |\r\n        ");
            EndContext();
            BeginContext(1492, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba6644d5828b4bceae6a5e0869ce1a79", async() => {
                BeginContext(1514, 17, true);
                WriteLiteral("Back to Full List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1535, 108, true);
            WriteLiteral("\r\n\r\n    </p>\r\n</div>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1644, 43, false);
#line 52 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MovieID));

#line default
#line hidden
            EndContext();
            BeginContext(1687, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1743, 45, false);
#line 55 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MovieName));

#line default
#line hidden
            EndContext();
            BeginContext(1788, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1844, 41, false);
#line 58 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1885, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1941, 44, false);
#line 61 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Director));

#line default
#line hidden
            EndContext();
            BeginContext(1985, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2041, 41, false);
#line 64 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(2082, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2138, 40, false);
#line 67 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(2178, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2234, 42, false);
#line 70 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(2276, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 76 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(2411, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2460, 42, false);
#line 80 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MovieID));

#line default
#line hidden
            EndContext();
            BeginContext(2502, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2558, 44, false);
#line 83 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MovieName));

#line default
#line hidden
            EndContext();
            BeginContext(2602, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2658, 40, false);
#line 86 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2698, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2754, 43, false);
#line 89 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Director));

#line default
#line hidden
            EndContext();
            BeginContext(2797, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2853, 40, false);
#line 92 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(2893, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2949, 39, false);
#line 95 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Year));

#line default
#line hidden
            EndContext();
            BeginContext(2988, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3044, 41, false);
#line 98 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(3085, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3140, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3545bb32458e4307ab0ca46d2697c57e", async() => {
                BeginContext(3189, 3, true);
                WriteLiteral("Buy");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 101 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
                                      WriteLiteral(item.MovieID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3196, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3216, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5921253957514e6589b52974f5886cec", async() => {
                BeginContext(3269, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 102 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
                                          WriteLiteral(item.MovieID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3280, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 103 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
                 if (User.IsInRole("Administrator"))
                {

#line default
#line hidden
            BeginContext(3355, 52, true);
            WriteLiteral("                    <i> | </i>\r\n                    ");
            EndContext();
            BeginContext(3407, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d158c54db375425aa4840febb8359e19", async() => {
                BeginContext(3457, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 106 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
                                           WriteLiteral(item.MovieID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3465, 54, true);
            WriteLiteral("\r\n                    <i> | </i>\r\n                    ");
            EndContext();
            BeginContext(3519, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cc9c62e65a34c7bbc31106ca4516e74", async() => {
                BeginContext(3571, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 108 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
                                             WriteLiteral(item.MovieID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3581, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 109 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"

                }

#line default
#line hidden
            BeginContext(3604, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 113 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3649, 30, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3698, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3704, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36db8c1b6dfd4d51ba813901a464ace5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3759, 1347, true);
                WriteLiteral(@"
    <script>
        $(""select.dropdown"").change(function(){

            var priceOption = $('#priceSearch').find("":selected"").text(); //this is the selcted price drop dwon value
            var genreOption = $('#genreSearch').find("":selected"").text(); //this is the selected genre drop down value
            var directorOption = $('#directorSearch').find("":selected"").text(); //this is the selected company dwon value
            var yearOption = $('#yearSearch').find("":selected"").text(); //this is the selected company dwon value
            var ratingOption = $('#ratingSearch').find("":selected"").text(); //this is the selected company dwon value

            $.ajax({
                url: ""Movie/search"", // use the result function which return a list of objects from query result in controller
                type: ""get"", //send it through get method
                data: {
                    priceSearch: priceOption,
                    genreSearch: genreOption,
                    directorSea");
                WriteLiteral(@"rch: directorOption,
                    yearSearch: yearOption,
                    ratingSearch: ratingOption
                },
                success: function (response) {
                    var result = '';
                    // checks if user is admin for later displays
                    var isAdmin = '");
                EndContext();
                BeginContext(5107, 30, false);
#line 144 "C:\MovieAdvisor\MovieAdvisor\Views\Movie\Index.cshtml"
                              Write(User.IsInRole("Administrator"));

#line default
#line hidden
                EndContext();
                BeginContext(5137, 1789, true);
                WriteLiteral(@"';
                    // if the reponse is empty display an empty table (in case no movies match the filter)
                    if (response == '') {
                        result = "" ""
                        $('tbody').html(result);
                    }
                    // table body
                    $.each(response, function (key, value) {
                        result +=
                            '<tr>' +
                            '<td>' + value.movieID + '</td>' +
                            '<td>' + value.movieName + '</td>' +
                            '<td>' + value.price + '</td>' +
                            '<td>' + value.director + '</td>' +
                            '<td>' + value.genre + '</td>' +
                            '<td>' + value.year + '</td>' +
                            '<td>' + value.rating + '</td>' +

                            '<td>' +
                            '<a href=""/Movie/Buy/' + value.movieID + '"">Buy</a> | ' +
                  ");
                WriteLiteral(@"          '<a href=""/Movie/Details/' + value.movieID + '"">Details</a>'
                        if (isAdmin=='True')
                        {
                            result +=
                                ' | <a href=""/Movie/Edit/' + value.movieID + '"">Edit</a> | ' +
                                '<a href=""/Movie/Delete/' + value.movieID + '"">Delete</a>'

                        }
                        result +=
                            '</td>' +
                            '</tr>'

                        $('tbody').html(result);
                    });
                },
                error: function (xhr) {
                    alert(""get reuquest error"")
                }
            });
        });

    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MovieLand.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
