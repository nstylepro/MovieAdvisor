#pragma checksum "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e032f22d271c885967817da7316eac865e4f0f95"
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
#line 1 "C:\MovieLand\MovieAdvisor\Views\_ViewImports.cshtml"
using MovieLand;

#line default
#line hidden
#line 2 "C:\MovieLand\MovieAdvisor\Views\_ViewImports.cshtml"
using MovieLand.Models;

#line default
#line hidden
#line 3 "C:\MovieLand\MovieAdvisor\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e032f22d271c885967817da7316eac865e4f0f95", @"/Views/Movie/Index.cshtml")]
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
#line 3 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(87, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14dfb42255774d5ca2a50a2ad8fdf889", async() => {
                BeginContext(93, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(99, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "67df26be59114648907930ae3c74c46b", async() => {
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
#line 14 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
     if (User.IsInRole("Administrator"))
    {

#line default
#line hidden
            BeginContext(265, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(273, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0509a196122f4943a04459dfc6183857", async() => {
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
#line 17 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(322, 152, true);
            WriteLiteral("</p>\r\n\r\n<div class=\"form-actions no-color\">\r\n    <p>\r\n        Price:\r\n        <!--search by price: populating the drop down list dynamicaly-->\r\n        ");
            EndContext();
            BeginContext(475, 116, false);
#line 24 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
   Write(Html.DropDownList("priceSearch", new SelectList(ViewBag.priceCategory, "Price"), "Any", new { @class = "dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(591, 102, true);
            WriteLiteral("\r\n\r\n        Genre:\r\n        <!--search by genre: populating the drop down list dynamicaly-->\r\n        ");
            EndContext();
            BeginContext(694, 109, false);
#line 28 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
   Write(Html.DropDownList("genreSearch", new SelectList(ViewBag.genres, "Genre"), "Any", new { @class = "dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(803, 108, true);
            WriteLiteral("\r\n\r\n        Director:\r\n        <!--search by director: populating the drop down list dynamicaly-->\r\n        ");
            EndContext();
            BeginContext(912, 118, false);
#line 32 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
   Write(Html.DropDownList("directorSearch", new SelectList(ViewBag.directors, "Director"), "Any", new { @class = "dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(1030, 100, true);
            WriteLiteral("\r\n\r\n        Year:\r\n        <!--search by year: populating the drop down list dynamicaly-->\r\n        ");
            EndContext();
            BeginContext(1131, 113, false);
#line 36 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
   Write(Html.DropDownList("yearSearch", new SelectList(ViewBag.yearCategory, "Year"), "Any", new { @class = "dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(1244, 34, true);
            WriteLiteral("\r\n\r\n        IMDB Rating:\r\n        ");
            EndContext();
            BeginContext(1279, 117, false);
#line 39 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
   Write(Html.DropDownList("ratingSearch", new SelectList(ViewBag.ratings, "IMDB Rating"), "Any", new { @class = "dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(1396, 96, true);
            WriteLiteral("\r\n\r\n        <!--search by year: populating the drop down list dynamicaly-->\r\n        |\r\n        ");
            EndContext();
            BeginContext(1492, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0cfde729302445abaa464626b8bdbab", async() => {
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
            BeginContext(1535, 106, true);
            WriteLiteral("\r\n    </p>\r\n</div>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1642, 43, false);
#line 51 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MovieID));

#line default
#line hidden
            EndContext();
            BeginContext(1685, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1741, 45, false);
#line 54 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MovieName));

#line default
#line hidden
            EndContext();
            BeginContext(1786, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1842, 41, false);
#line 57 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1883, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1939, 44, false);
#line 60 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Director));

#line default
#line hidden
            EndContext();
            BeginContext(1983, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2039, 41, false);
#line 63 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(2080, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2136, 40, false);
#line 66 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(2176, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2232, 42, false);
#line 69 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(2274, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 75 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(2409, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2458, 42, false);
#line 79 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MovieID));

#line default
#line hidden
            EndContext();
            BeginContext(2500, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2556, 44, false);
#line 82 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MovieName));

#line default
#line hidden
            EndContext();
            BeginContext(2600, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2656, 40, false);
#line 85 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2696, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2752, 43, false);
#line 88 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Director));

#line default
#line hidden
            EndContext();
            BeginContext(2795, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2851, 40, false);
#line 91 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(2891, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2947, 39, false);
#line 94 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Year));

#line default
#line hidden
            EndContext();
            BeginContext(2986, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3042, 41, false);
#line 97 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(3083, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3138, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bfe08e1934245f095aa4f6cb7fdef3f", async() => {
                BeginContext(3187, 3, true);
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
#line 100 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
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
            BeginContext(3194, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3214, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c44706da47494e938e8f40a0501f4c36", async() => {
                BeginContext(3267, 7, true);
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
#line 101 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
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
            BeginContext(3278, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 102 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
                 if (User.IsInRole("Administrator"))
                {

#line default
#line hidden
            BeginContext(3353, 52, true);
            WriteLiteral("                    <i> | </i>\r\n                    ");
            EndContext();
            BeginContext(3405, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc0d45d4557a4fccb4467ee7c367b757", async() => {
                BeginContext(3455, 4, true);
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
#line 105 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
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
            BeginContext(3463, 54, true);
            WriteLiteral("\r\n                    <i> | </i>\r\n                    ");
            EndContext();
            BeginContext(3517, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1553d3964655469a9296297540fcf251", async() => {
                BeginContext(3569, 6, true);
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
#line 107 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
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
            BeginContext(3579, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 108 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"

                }

#line default
#line hidden
            BeginContext(3602, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 112 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3647, 30, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3696, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3702, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45528f85441d46e5bb28977ed9cc4327", async() => {
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
                BeginContext(3757, 1347, true);
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
                BeginContext(5105, 30, false);
#line 143 "C:\MovieLand\MovieAdvisor\Views\Movie\Index.cshtml"
                              Write(User.IsInRole("Administrator"));

#line default
#line hidden
                EndContext();
                BeginContext(5135, 1789, true);
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
