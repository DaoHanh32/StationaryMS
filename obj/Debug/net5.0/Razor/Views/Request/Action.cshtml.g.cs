#pragma checksum "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5767a276851712a0092fde13c37380c333cad17b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Request_Action), @"mvc.1.0.view", @"/Views/Request/Action.cshtml")]
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
#line 1 "C:\Users\sgn-ginnyn\StationaryMS\Views\_ViewImports.cshtml"
using eProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sgn-ginnyn\StationaryMS\Views\_ViewImports.cshtml"
using eProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5767a276851712a0092fde13c37380c333cad17b", @"/Views/Request/Action.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f10561b1c200766559e800ea7446594538b9cebb", @"/Views/_ViewImports.cshtml")]
    public class Views_Request_Action : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/step-wizard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
  
    string json = HttpContextAccessor.HttpContext.Session.GetString("cart");
    string json_user_detail = HttpContextAccessor.HttpContext.Session.GetString("user_session");
    Users user = null;
    List<CartItem> listCart = new List<CartItem>();
    if (json != null)
    {
        JArray jsonResponse = JArray.Parse(json);

        foreach (var item in jsonResponse)
        {
            JObject cartResult = (JObject)item;
            listCart.Add(JsonConvert.DeserializeObject<CartItem>(cartResult.ToString()));
        }
    }
    if (json_user_detail != null)
    {
        JObject jsonResponse = JObject.Parse(json_user_detail);
        user = JsonConvert.DeserializeObject<Users>(json_user_detail.ToString());
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
  
    ViewData["Title"] = "Action";
    var pageList = (IPagedList)ViewBag.itemList;
    Layout = "~/Views/Shared/_Layout_User.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("css", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5767a276851712a0092fde13c37380c333cad17b6401", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"<div class=""wrapper"">
    <div class=""gambo-Breadcrumb"">
        <div class=""container-fluit"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <nav aria-label=""breadcrumb"">
                        <ol class=""breadcrumb"">
                            <li class=""breadcrumb-item""><a");
            BeginWriteAttribute("href", " href=\"", 1491, "\"", 1532, 1);
#nullable restore
#line 43 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
WriteAttributeValue("", 1498, Url.Action("TaskList", "Request"), 1498, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Task List</a></li>
                            <li class=""breadcrumb-item active"" aria-current=""page""><a href=""#"">Request Detail</a> </li>
                        </ol>
                    </nav>
                </div>
            </div>
        </div>
    </div>
    <div style=""margin-left: 10px; margin-right: 10px"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5767a276851712a0092fde13c37380c333cad17b8691", async() => {
                WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n");
#nullable restore
#line 55 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
                     if (@ViewBag.AlertAction != null && @ViewBag.AlertAction.ToString().Length > 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div");
                BeginWriteAttribute("class", " class=\"", 2160, "\"", 2200, 3);
                WriteAttributeValue("", 2168, "alert", 2168, 5, true);
                WriteAttributeValue(" ", 2173, "alert-", 2174, 7, true);
#nullable restore
#line 57 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
WriteAttributeValue("", 2180, ViewBag.AlertAction, 2180, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">×</button>\r\n                            <ul>\r\n");
#nullable restore
#line 60 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
                                 foreach (var a in @ViewBag.MessageAction)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <li>");
#nullable restore
#line 62 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
                                   Write(Html.Raw(a));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 63 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </ul>\r\n                        </div>\r\n");
#nullable restore
#line 66 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            </div>\r\n");
#nullable restore
#line 69 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
             if (ViewBag.itemList != null && ViewBag.itemList.Count > 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <table class=""table table-bordered"" border=""1"">
                    <thead>
                        <tr>
                            <th>Request ID</th>
                            <th>Requester</th>
                            <th>Item Code</th>
                            <th>Quantity</th>
                            <th>Price (USD)</th>
                            <th>Total (USD)</th>
                        </tr>
                    </thead>

");
#nullable restore
#line 83 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
                     foreach (var item in ViewBag.itemList)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tbody>\r\n                            <tr>\r\n                                <td>");
#nullable restore
#line 87 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
                               Write(item.Request_Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 88 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
                               Write(ViewBag.requesterName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 89 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
                               Write(item.ItemCode);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 90 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
                               Write(item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 91 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
                               Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 92 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
                               Write(item.Total);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                        </tbody>\r\n");
#nullable restore
#line 95 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tfoot>\r\n                        <tr>\r\n                            <td colspan=\"5\">Total amount of Request (USD):</td>\r\n                            <td style=\"font-weight:bolder;color:coral\">");
#nullable restore
#line 99 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
                                                                  Write(ViewBag.requestTotal);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                    </tfoot>\r\n                </table>\r\n");
                WriteLiteral(@"                <div class=""col-md-12"">
                    <div class=""blog-more-btn"">
                        <div class=""pagination-area text-center"">
                            <nav aria-label=""navigation"">
                                <div>
                                    <h3 style=""color:darkblue; font-size:14px"">
");
#nullable restore
#line 110 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
                                         if (pageList != null)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
                                       Write(Html.PagedListPager(pageList, page => Url.Action("Details", new { page })));

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
                                                                                                                       
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </h3>
                                </div>
                            </nav>
                        </div>
                    </div>
                </div>
                <div style=""padding-top:10px; text-align:center""  class=""form-group"">
                    <input style=""width:100px"" type=""submit"" name=""submit"" value=""Approve"" class=""btn btn-success"" />
                    <input style=""width:100px"" type=""submit"" name=""submit"" value=""Forward"" class=""btn btn-info"" />
                    <input style=""width:100px"" type=""submit"" name=""submit"" value=""Reject"" class=""btn btn-warning"" />
                </div>
");
#nullable restore
#line 125 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 52 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
AddHtmlAttributeValue("", 1899, Url.Action("Action", "Request"), 1899, 32, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        \r\n        <input class=\"btn btn-primary\" type=\"button\" value=\"Go Back\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5564, "\"", 5624, 3);
            WriteAttributeValue("", 5574, "location.href=\'", 5574, 15, true);
#nullable restore
#line 129 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Action.cshtml"
WriteAttributeValue("", 5589, Url.Action("TaskList", "Request"), 5589, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5623, "\'", 5623, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
            WriteLiteral("    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
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