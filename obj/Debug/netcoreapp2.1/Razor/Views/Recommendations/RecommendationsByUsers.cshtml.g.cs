#pragma checksum "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3571437d68cb54d79d7249765281361068c1ff11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recommendations_RecommendationsByUsers), @"mvc.1.0.view", @"/Views/Recommendations/RecommendationsByUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recommendations/RecommendationsByUsers.cshtml", typeof(AspNetCore.Views_Recommendations_RecommendationsByUsers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3571437d68cb54d79d7249765281361068c1ff11", @"/Views/Recommendations/RecommendationsByUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e98df24b14885a3b24f9f83daa27a259013803f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Recommendations_RecommendationsByUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieLand.Models.Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Recommendations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Buy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml"
  
    ViewData["Title"] = "Recommendations By Users";

#line default
#line hidden
            BeginContext(104, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40f4cfc5d2e647afb077fe1657229f16", async() => {
                BeginContext(110, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(116, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ba24bb78022043748a8757b4ec49c00e", async() => {
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
                BeginContext(191, 5, true);
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
            BeginContext(203, 213, true);
            WriteLiteral("\r\n<h2>Your Recommended Movies By Other Movies You Ordered:</h2>\r\n\r\n\r\n<div class=\"form-actions no-color\">\r\n    <p>\r\n        Price:\r\n        <!--search by price: populating the drop down list dynamicaly-->\r\n        ");
            EndContext();
            BeginContext(417, 116, false);
#line 15 "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml"
   Write(Html.DropDownList("priceSearch", new SelectList(ViewBag.priceCategory, "Price"), "Any", new { @class = "dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(533, 102, true);
            WriteLiteral("\r\n\r\n        Genre:\r\n        <!--search by genre: populating the drop down list dynamicaly-->\r\n        ");
            EndContext();
            BeginContext(636, 109, false);
#line 19 "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml"
   Write(Html.DropDownList("genreSearch", new SelectList(ViewBag.genres, "Genre"), "Any", new { @class = "dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(745, 107, true);
            WriteLiteral("\r\n\r\n        Director:\r\n        <!--search by company: populating the drop down list dynamicaly-->\r\n        ");
            EndContext();
            BeginContext(853, 118, false);
#line 23 "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml"
   Write(Html.DropDownList("directorSearch", new SelectList(ViewBag.directors, "Director"), "Any", new { @class = "dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(971, 100, true);
            WriteLiteral("\r\n\r\n        Year:\r\n        <!--search by year: populating the drop down list dynamicaly-->\r\n        ");
            EndContext();
            BeginContext(1072, 113, false);
#line 27 "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml"
   Write(Html.DropDownList("yearSearch", new SelectList(ViewBag.yearCategory, "Year"), "Any", new { @class = "dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(1185, 34, true);
            WriteLiteral("\r\n\r\n        IMDB Rating:\r\n        ");
            EndContext();
            BeginContext(1220, 117, false);
#line 30 "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml"
   Write(Html.DropDownList("ratingSearch", new SelectList(ViewBag.ratings, "IMDB Rating"), "Any", new { @class = "dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(1337, 21, true);
            WriteLiteral("\r\n        |\r\n        ");
            EndContext();
            BeginContext(1358, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02d073cabbd8494d8c93728bb8a3ee50", async() => {
                BeginContext(1390, 17, true);
                WriteLiteral("Back to Full List");
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
            BeginContext(1411, 106, true);
            WriteLiteral("\r\n    </p>\r\n</div>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1518, 43, false);
#line 40 "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.MovieID));

#line default
#line hidden
            EndContext();
            BeginContext(1561, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1617, 45, false);
#line 43 "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.MovieName));

#line default
#line hidden
            EndContext();
            BeginContext(1662, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1718, 41, false);
#line 46 "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1759, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1815, 44, false);
#line 49 "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Director));

#line default
#line hidden
            EndContext();
            BeginContext(1859, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1915, 41, false);
#line 52 "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(1956, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2012, 40, false);
#line 55 "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(2052, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2108, 42, false);
#line 58 "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(2150, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 64 "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(2285, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2334, 42, false);
#line 68 "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.MovieID));

#line default
#line hidden
            EndContext();
            BeginContext(2376, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2432, 44, false);
#line 71 "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.MovieName));

#line default
#line hidden
            EndContext();
            BeginContext(2476, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2532, 40, false);
#line 74 "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2572, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2628, 43, false);
#line 77 "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Director));

#line default
#line hidden
            EndContext();
            BeginContext(2671, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2727, 40, false);
#line 80 "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(2767, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2823, 40, false);
#line 83 "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(2863, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2919, 42, false);
#line 86 "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(2961, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3016, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "935494c5ec21414591b43ca480798d1c", async() => {
                BeginContext(3088, 3, true);
                WriteLiteral("Buy");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 89 "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml"
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
            BeginContext(3095, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3115, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c80fa16d0734238bd5cde0cf65ca63b", async() => {
                BeginContext(3191, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 90 "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml"
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
            BeginContext(3202, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 93 "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml"
        }

#line default
#line hidden
            BeginContext(3249, 30, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3298, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3304, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54ab266c2b904b2c967e0c46a245deaa", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3359, 1032, true);
                WriteLiteral(@"
    <script>
        //var recmovies = { Movies: 'Model' };

        $(""select.dropdown"").change(function(){

            var priceOption = $('#priceSearch').find("":selected"").text(); //this is the selcted price drop dwon value
            var genreOption = $('#genreSearch').find("":selected"").text(); //this is the selected genre drop down value
            var directorOption = $('#directorSearch').find("":selected"").text(); //this is the selected company dwon value
            var yearOption = $('#yearSearch').find("":selected"").text(); //this is the selected company dwon value
            var ratingOption = $('#ratingSearch').find("":selected"").text(); //this is the selected company dwon value

            // i created a string of the recommended movies ids to pass to the controller each time he searches a movie in the recommendations
            // i did this so the search will only be on recommended movies without calculating recommendations anew each time the user searches
            var recM");
                WriteLiteral("ovies = ");
                EndContext();
                BeginContext(4392, 71, false);
#line 115 "C:\MovieLand\MovieAdvisor\Views\Recommendations\RecommendationsByUsers.cshtml"
                       Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(@Model) as String));

#line default
#line hidden
                EndContext();
                BeginContext(4463, 2288, true);
                WriteLiteral(@"; // create json of recommended movies passed to view
            var recMoviesIds = """";
            $.each(recMovies, function () {
                recMoviesIds = recMoviesIds + "","" + this.MovieID.toString();
            });

            $.ajax({
                url: ""../Movie/search"", // use the result function which return a list of objects from query result in controller
                type: ""post"", //send it through post method
                data: {
                    priceSearch: priceOption,
                    genreSearch: genreOption,
                    directorSearch: directorOption,
                    yearSearch: yearOption,
                    ratingSearch: ratingOption,
                    recMoviesIds: recMoviesIds
                },
                success: function (response) {
                    var result = '';
                    // if the reponse is empty display an empty table (in case no movies match the filter)
                    if (response == '') {
      ");
                WriteLiteral(@"                  result = "" ""
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
                            '<a href=""/Movie/Details/' + value.movieID + '"">Details</a>' +
                            '</td>' +
                            '</tr>'

           ");
                WriteLiteral("             $(\'tbody\').html(result);\r\n                    });\r\n                },\r\n                error: function (xhr) {\r\n                    alert(\"get reuquest error\")\r\n                }\r\n            });\r\n        });\r\n\r\n    </script>\r\n");
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
