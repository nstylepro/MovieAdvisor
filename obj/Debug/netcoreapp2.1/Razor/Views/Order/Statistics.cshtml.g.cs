#pragma checksum "C:\Projects\MovieAdvisor\Views\Order\Statistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53dd30e48f3243a8e036233a02a97802923fd379"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Statistics), @"mvc.1.0.view", @"/Views/Order/Statistics.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Statistics.cshtml", typeof(AspNetCore.Views_Order_Statistics))]
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
#line 1 "C:\Projects\MovieAdvisor\Views\_ViewImports.cshtml"
using MovieLand;

#line default
#line hidden
#line 2 "C:\Projects\MovieAdvisor\Views\_ViewImports.cshtml"
using MovieLand.Models;

#line default
#line hidden
#line 3 "C:\Projects\MovieAdvisor\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53dd30e48f3243a8e036233a02a97802923fd379", @"/Views/Order/Statistics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e98df24b14885a3b24f9f83daa27a259013803f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Statistics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Statistics", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Projects\MovieAdvisor\Views\Order\Statistics.cshtml"
  
    ViewData["Title"] = "Statistics";

#line default
#line hidden
            BeginContext(48, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3f2e65ae9ff4b50a5b189aebe2571b7", async() => {
                BeginContext(54, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(60, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "421e31ad230e4eda83e0cc0da8655bb6", async() => {
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
                BeginContext(135, 5, true);
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
            BeginContext(147, 356, true);
            WriteLiteral(@"
<h2>Orders</h2>

<br />

<input type=""radio"" name=""colorRadio"" value=""group""> group
<input type=""radio"" name=""colorRadio"" value=""join""> join

<div id=""group"" hidden>
    

    <div class=""form-actions no-color"">
        <p>
            <br /><br />
            <!--group by ~option~: populating the drop down list dynamicaly-->
            ");
            EndContext();
            BeginContext(504, 85, false);
#line 22 "C:\Projects\MovieAdvisor\Views\Order\Statistics.cshtml"
       Write(Html.DropDownList("group", new SelectList(ViewBag.group, "Grouped"), "Select Option"));

#line default
#line hidden
            EndContext();
            BeginContext(589, 29, true);
            WriteLiteral("\r\n            |\r\n            ");
            EndContext();
            BeginContext(618, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "442185b1110c4083b5d32657ea8a1cb4", async() => {
                BeginContext(645, 5, true);
                WriteLiteral("Clear");
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
            BeginContext(654, 457, true);
            WriteLiteral(@"
        </p>
    </div>


    <div id=""groupOutput"">
        <table class=""table"">
            <thead>              
            </thead>
            <tbody>                
            </tbody>
        </table>
    </div>   
</div>


<div id=""join"" hidden>

    
    <div class=""form-actions no-color"">
        <p>
            <br /><br />
            <!--join with ~option~: populating the drop down list dynamicaly-->
            ");
            EndContext();
            BeginContext(1112, 82, false);
#line 47 "C:\Projects\MovieAdvisor\Views\Order\Statistics.cshtml"
       Write(Html.DropDownList("join", new SelectList(ViewBag.join, "Joined"), "Select Option"));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 29, true);
            WriteLiteral("\r\n            |\r\n            ");
            EndContext();
            BeginContext(1223, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aea28b6eb864459b878121d97089a53d", async() => {
                BeginContext(1250, 5, true);
                WriteLiteral("Clear");
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
            BeginContext(1259, 191, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n    \r\n\r\n\r\n    <table class=\"table\">\r\n        <thead>                    \r\n        </thead>\r\n        <tbody>            \r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1469, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(1477, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "488ad8e6b62a467aaceb88b735ce8285", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1532, 7320, true);
                WriteLiteral(@"
    <script>
               
        // this handles which option to show based on radio button
        var groupDiv = $(""#group"");
        var joinDiv = $(""#join"");
        $(document).ready(function () {

            // show only group div if group is chosen
            $('input[type=""radio""]').click(function () {
                var radioVal = this.value;
                $('tbody').html(null);

                if (radioVal === ""group"") {
                    joinDiv.hide();
                    groupDiv.show();

                    // this sends a get with slected drop down value
                    $(""select[id^='group']"").change(function () {
                        
                        var sentData = $('option:selected', $(this)).text(); //this is the selcted drop dwon value
                        $.ajax({
                            url: ""groupResult"", // use the result function which return a list of objects from query result in controller
                            type: """);
                WriteLiteral(@"get"", //send it through get method
                            data: {                                
                                group: sentData                                
                            },
                            success: function (response) {
                                var result = '';
                                var head = '';
                                
                                // table head
                                    head +=
                                        '<tr>' +
                                        '<th>' + ""Username"" + '</th>' +
                                        '<th>' + ""count"" + '</th>' +                                                                            
                                        '</tr>';
                                $('thead').html(head);

                                // table body
                                $.each(response, function (key, value) {
                        ");
                WriteLiteral(@"            result +=
                                        '<tr>' +
                                        '<td>' + value.name + '</td>' +
                                        '<td>' + value.count + '</td>' +
                                        '</tr>';
                                    $('tbody').html(result);
                                });
                            },
                            error: function(xhr) {
                                alert(""get reuquest error"")
                            }
                        });                                                                       
                    });
                }
                else if (radioVal === ""join"") {
                    groupDiv.hide();
                    joinDiv.show();

                    // this sends a get with slected drop down value
                    $(""select[id^='join']"").change(function () {                       
                        var sentData = $('option:s");
                WriteLiteral(@"elected', $(this)).text(); //this is the selcted drop dwon value
                        $.ajax({
                            url: ""joinResult"", // use the result function which return a list of objects from query result in controller
                            type: ""get"", //send it through get method
                            data: {                                
                                join: sentData                                
                            },
                            success: function (response) {
                                var head = '';
                                var result = '';
                                //display join with customers
                                if (sentData === ""Customers"") {

                                    // table head
                                    head +=
                                        '<tr>' +
                                        '<th>' + ""order ID"" + '</th>' +
                           ");
                WriteLiteral(@"             '<th>' + ""customer Username"" + '</th>' +
                                        '<th>' + ""order Date""  + '</th>' +
                                        '<th>' + ""country"" + '</th>' +  
                                        '<th>' + ""city"" + '</th>' +
                                        '<th>' + ""street"" + '</th>' +  
                                        '</tr>';
                                    $('thead').html(head);

                                    // table body
                                    $.each(response, function (key, value) {
                                    result +=
                                        '<tr>' +
                                        '<td>' + value.orderID + '</td>' +
                                        '<td>' + value.customerUsername + '</td>' +
                                        '<td>' + value.orderDate + '</td>' +
                                        '<td>' + value.country + '</td>' +  
                      ");
                WriteLiteral(@"                  '<td>' + value.city + '</td>' + 
                                        '<td>' + value.street + '</td>' +  
                                        '</tr>';
                                    $('tbody').html(result);
                                    });
                                }
                                // display join with movies
                                else if (sentData === ""Movies"") {

                                    // table head
                                    head +=
                                        '<tr>' +
                                        '<th>' + ""Order ID"" + '</th>' +
                                        '<th>' + ""Movie ID"" + '</th>' +
                                        '<th>' + ""Order Date""  + '</th>' +
                                        '<th>' + ""Movie Name"" + '</th>' +                                      
                                        '</tr>';
                                    $('thead')");
                WriteLiteral(@".html(head);

                                    // tbale body
                                    $.each(response, function (key, value) {
                                    result +=
                                        '<tr>' +
                                        '<td>' + value.orderID + '</td>' +
                                        '<td>' + value.movieID + '</td>' +
                                        '<td>' + value.orderDate + '</td>' +
                                        '<td>' + value.movieName + '</td>' +                                     
                                        '</tr>';
                                    $('tbody').html(result);
                                    });
                                }
                                
                            },
                            error: function(xhr) {
                                alert(""get reuquest error"")
                            }
                        });            ");
                WriteLiteral("                                                           \r\n                    });\r\n                }\r\n            });\r\n        });\r\n    </script>\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(8855, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Css", async() => {
                BeginContext(8872, 8, true);
                WriteLiteral("\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
