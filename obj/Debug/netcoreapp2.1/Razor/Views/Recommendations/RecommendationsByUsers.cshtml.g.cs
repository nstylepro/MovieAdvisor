#pragma checksum "C:\Projects\MoviesSiteRepo\Views\Recommendations\RecommendationsByUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a832aaec2203b594c82b133ab9bc50cc18e404e"
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
#line 1 "C:\Projects\MoviesSiteRepo\Views\_ViewImports.cshtml"
using MovieLand;

#line default
#line hidden
#line 2 "C:\Projects\MoviesSiteRepo\Views\_ViewImports.cshtml"
using MovieLand.Models;

#line default
#line hidden
#line 3 "C:\Projects\MoviesSiteRepo\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a832aaec2203b594c82b133ab9bc50cc18e404e", @"/Views/Recommendations/RecommendationsByUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e98df24b14885a3b24f9f83daa27a259013803f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Recommendations_RecommendationsByUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieLand.Models.Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Recommendations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Game", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Projects\MoviesSiteRepo\Views\Recommendations\RecommendationsByUsers.cshtml"
  
    ViewData["Title"] = "Recommendations By Users";

#line default
#line hidden
            BeginContext(104, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94c12870485e421893c1900634968983", async() => {
                BeginContext(110, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(116, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "34e90faa077949578d7a157c7e2346c0", async() => {
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
#line 15 "C:\Projects\MoviesSiteRepo\Views\Recommendations\RecommendationsByUsers.cshtml"
   Write(Html.DropDownList("priceSearch", new SelectList(ViewBag.priceCategory, "Price"), "Any", new { @class = "dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(533, 102, true);
            WriteLiteral("\r\n\r\n        Genre:\r\n        <!--search by genre: populating the drop down list dynamicaly-->\r\n        ");
            EndContext();
            BeginContext(636, 109, false);
#line 19 "C:\Projects\MoviesSiteRepo\Views\Recommendations\RecommendationsByUsers.cshtml"
   Write(Html.DropDownList("genreSearch", new SelectList(ViewBag.genres, "Genre"), "Any", new { @class = "dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(745, 106, true);
            WriteLiteral("\r\n\r\n        Company:\r\n        <!--search by company: populating the drop down list dynamicaly-->\r\n        ");
            EndContext();
            BeginContext(852, 117, false);
#line 23 "C:\Projects\MoviesSiteRepo\Views\Recommendations\RecommendationsByUsers.cshtml"
   Write(Html.DropDownList("companySearch", new SelectList(ViewBag.companies, "Director"), "Any", new { @class = "dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(969, 23, true);
            WriteLiteral("\r\n\r\n        |\r\n        ");
            EndContext();
            BeginContext(992, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "faa9d9d3eda94c1293c8feb37085239f", async() => {
                BeginContext(1024, 17, true);
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
            BeginContext(1045, 106, true);
            WriteLiteral("\r\n    </p>\r\n</div>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1152, 43, false);
#line 34 "C:\Projects\MoviesSiteRepo\Views\Recommendations\RecommendationsByUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.MovieID));

#line default
#line hidden
            EndContext();
            BeginContext(1195, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1251, 45, false);
#line 37 "C:\Projects\MoviesSiteRepo\Views\Recommendations\RecommendationsByUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.MovieName));

#line default
#line hidden
            EndContext();
            BeginContext(1296, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1352, 41, false);
#line 40 "C:\Projects\MoviesSiteRepo\Views\Recommendations\RecommendationsByUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1393, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1449, 44, false);
#line 43 "C:\Projects\MoviesSiteRepo\Views\Recommendations\RecommendationsByUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Director));

#line default
#line hidden
            EndContext();
            BeginContext(1493, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1549, 41, false);
#line 46 "C:\Projects\MoviesSiteRepo\Views\Recommendations\RecommendationsByUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(1590, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 52 "C:\Projects\MoviesSiteRepo\Views\Recommendations\RecommendationsByUsers.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1725, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1786, 42, false);
#line 56 "C:\Projects\MoviesSiteRepo\Views\Recommendations\RecommendationsByUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.MovieID));

#line default
#line hidden
            EndContext();
            BeginContext(1828, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1896, 44, false);
#line 59 "C:\Projects\MoviesSiteRepo\Views\Recommendations\RecommendationsByUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.MovieName));

#line default
#line hidden
            EndContext();
            BeginContext(1940, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2008, 40, false);
#line 62 "C:\Projects\MoviesSiteRepo\Views\Recommendations\RecommendationsByUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2048, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2116, 43, false);
#line 65 "C:\Projects\MoviesSiteRepo\Views\Recommendations\RecommendationsByUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.Director));

#line default
#line hidden
            EndContext();
            BeginContext(2159, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2227, 40, false);
#line 68 "C:\Projects\MoviesSiteRepo\Views\Recommendations\RecommendationsByUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(2267, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2334, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15e73e427dad470498aa99d1930cc6bc", async() => {
                BeginContext(2405, 3, true);
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
#line 71 "C:\Projects\MoviesSiteRepo\Views\Recommendations\RecommendationsByUsers.cshtml"
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
            BeginContext(2412, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2436, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0155a5b9e36349949b8ef7346cd12833", async() => {
                BeginContext(2511, 7, true);
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
#line 72 "C:\Projects\MoviesSiteRepo\Views\Recommendations\RecommendationsByUsers.cshtml"
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
            BeginContext(2522, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 75 "C:\Projects\MoviesSiteRepo\Views\Recommendations\RecommendationsByUsers.cshtml"
        }

#line default
#line hidden
            BeginContext(2577, 30, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2626, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2632, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36a84381b9f74290a71c3fbadd3f0893", async() => {
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
                BeginContext(2687, 795, true);
                WriteLiteral(@"
    <script>
        //var recmovies = { Movies: 'Model' };

        $(""select.dropdown"").change(function(){

            var priceOption = $('#priceSearch').find("":selected"").text(); //this is the selcted price drop dwon value
            var genreOption = $('#genreSearch').find("":selected"").text(); //this is the selected genre drop down value
            var companyOption = $('#companySearch').find("":selected"").text(); //this is the selected company dwon value

            // i created a string of the recommended movies ids to pass to the controller each time he searches a movie in the recommendations
            // i did this so the search will only be on recommended movies without calculating recommendations anew each time the user searches
            var recgames = ");
                EndContext();
                BeginContext(3483, 71, false);
#line 95 "C:\Projects\MoviesSiteRepo\Views\Recommendations\RecommendationsByUsers.cshtml"
                      Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(@Model) as String));

#line default
#line hidden
                EndContext();
                BeginContext(3554, 2065, true);
                WriteLiteral(@"; // create json of recommended movies passed to view
            var recgamesIds = """";
            $.each(recgames, function () {
                recgamesIds = recgamesIds + "","" + this.GameID.toString();
            });

            $.ajax({
                url: ""../Movie/search"", // use the result function which return a list of objects from query result in controller
                type: ""post"", //send it through post method
                data: {
                    priceSearch: priceOption,
                    genreSearch: genreOption,
                    companySearch: companyOption,
                    recGamesIds: recgamesIds
                },
                success: function (response) {
                    var result = '';
                    // if the reponse is empty display an empty table (in case no movies match the filter)
                    if (response == '') {
                        result = "" ""
                        $('tbody').html(result);
                    }");
                WriteLiteral(@"
                    // table body
                    $.each(response, function (key, value) {
                        result +=
                            '<tr>' +
                            '<td>' + value.gameID + '</td>' +
                            '<td>' + value.gameName + '</td>' +
                            '<td>' + value.price + '</td>' +
                            '<td>' + value.publisherCompany + '</td>' +
                            '<td>' + value.genre + '</td>' +
                            '<td>' +
                            '<a href=""/Movie/Buy/' + value.gameID + '"">Buy</a> | ' +
                            '<a href=""/Movie/Details/' + value.gameID + '"">Details</a>' +
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
");
                WriteLiteral("\r\n    </script>\r\n");
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