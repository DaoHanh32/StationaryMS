#pragma checksum "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Submit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "385c214f9781eed03937474a6ea29954b3fbb3ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Request_Submit), @"mvc.1.0.view", @"/Views/Request/Submit.cshtml")]
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
#line 1 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Submit.cshtml"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Submit.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Submit.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"385c214f9781eed03937474a6ea29954b3fbb3ab", @"/Views/Request/Submit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f10561b1c200766559e800ea7446594538b9cebb", @"/Views/_ViewImports.cshtml")]
    public class Views_Request_Submit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/step-wizard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("87"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("87"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Submit.cshtml"
  
    string json = HttpContextAccessor.HttpContext.Session.GetString("cart");
    List<CartItem> listCart = new List<CartItem>();
    decimal total_money = 0;
    if (json != null)
    {
        JArray jsonResponse = JArray.Parse(json);

        foreach (var item in jsonResponse)
        {
            JObject cartResult = (JObject)item;
            listCart.Add(JsonConvert.DeserializeObject<CartItem>(cartResult.ToString()));
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Submit.cshtml"
  
    ViewData["Title"] = "Submit";
    Layout = "~/Views/Shared/_Layout_User.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("css", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "385c214f9781eed03937474a6ea29954b3fbb3ab7053", async() => {
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
            WriteLiteral(@"<!-- Body Start -->
<div class=""wrapper"">
    <div class=""gambo-Breadcrumb"">
        <div class=""container-fluit"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <nav aria-label=""breadcrumb"">
                        <ol class=""breadcrumb"">
                            <li class=""breadcrumb-item""><a");
            BeginWriteAttribute("href", " href=\"", 1122, "\"", 1161, 1);
#nullable restore
#line 35 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Submit.cshtml"
WriteAttributeValue("", 1129, Url.Action("Create", "Request"), 1129, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Create New</a></li>
                            <li class=""breadcrumb-item active"" aria-current=""page""><a href=""#"">Submit Request</a></li>
                        </ol>
                    </nav>
                </div>
            </div>
        </div>
    </div>

    <div class=""all-product-grid"">
        <div class=""container"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "385c214f9781eed03937474a6ea29954b3fbb3ab9382", async() => {
                WriteLiteral("\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 49 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Submit.cshtml"
                         if (@ViewBag.Alert != null && @ViewBag.Alert.ToString().Length > 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div");
                BeginWriteAttribute("class", " class=\"", 1815, "\"", 1849, 3);
                WriteAttributeValue("", 1823, "alert", 1823, 5, true);
                WriteAttributeValue(" ", 1828, "alert-", 1829, 7, true);
#nullable restore
#line 51 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Submit.cshtml"
WriteAttributeValue("", 1835, ViewBag.Alert, 1835, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">×</button>\r\n                                <ul>\r\n");
#nullable restore
#line 54 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Submit.cshtml"
                                     foreach (var message in @ViewBag.Message)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <li>");
#nullable restore
#line 56 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Submit.cshtml"
                                       Write(Html.Raw(@message));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 57 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Submit.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </ul>\r\n                            </div>\r\n");
#nullable restore
#line 60 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Submit.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                </div>\r\n");
#nullable restore
#line 63 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Submit.cshtml"
                 if (listCart.Count > 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"row\">\r\n");
                WriteLiteral(@"                        <div class=""col-lg-5 col-md-4"">
                            <div id=""checkout_wizard"" class=""checkout accordion left-chck145"">
                                <div class=""checkout-step"">
                                    <div class=""form-group"">
                                        <div class=""row"">
                                            <div class=""col-lg-12"">
                                                <div class=""pymnt_title mb-12"">
                                                    <h4>Reason of your request</h4>
                                                </div>
                                            </div>
                                            <div class=""col-lg-12"" style=""display:block"">
                                                <div class=""form-group mt-1"">
                                                    <div class=""ui search focus"">
                                                        <div class=""ui left icon input swdh11");
                WriteLiteral(@" swdh19"">
                                                            <textarea class=""form-control"" name=""Reason"" rows=""3""></textarea>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <button type=""submit"" value=""finish"" class=""next-btn16 hover-btn"">Finish request</button>
                                </div>
                            </div>
                        </div>
");
                WriteLiteral(@"                        <div class=""col-lg-6 col-md-7"">
                            <div class=""pdpt-bg mt-0"">
                                <div class=""pdpt-title"">
                                    <h4>Selected Items</h4>
                                </div>
                                <div class=""right-cart-dt-body"">
");
#nullable restore
#line 99 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Submit.cshtml"
                                     foreach (CartItem cart in listCart)
                                    {
                                        total_money += cart.Item.Price * cart.Quantity;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"cart-item border_radius\">\r\n                                            <div class=\"cart-product-img\">\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "385c214f9781eed03937474a6ea29954b3fbb3ab14971", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 5036, "~/", 5036, 2, true);
#nullable restore
#line 104 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Submit.cshtml"
AddHtmlAttributeValue("", 5038, Url.Content(cart.Item.Images), 5038, 30, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            </div>\r\n                                            <div class=\"cart-text\">\r\n                                                <h4>");
#nullable restore
#line 107 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Submit.cshtml"
                                               Write(cart.Item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "385c214f9781eed03937474a6ea29954b3fbb3ab17176", async() => {
                    WriteLiteral("\r\n                                                    <input type=\"hidden\" name=\"id\"");
                    BeginWriteAttribute("value", " value=\"", 5507, "\"", 5534, 1);
#nullable restore
#line 109 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Submit.cshtml"
WriteAttributeValue("", 5515, cart.Item.ItemCode, 5515, 19, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                                                    <div name=\"quantity\" class=\"cart-item-price\">USD ");
#nullable restore
#line 110 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Submit.cshtml"
                                                                                                Write(cart.Item.Price);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" </div>\r\n                                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 108 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Submit.cshtml"
AddHtmlAttributeValue("", 5359, Url.Action("AddToCart", "Request"), 5359, 35, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 114 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Submit.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"main-total-cart\">\r\n                                    <h2>Total: <span>USD ");
#nullable restore
#line 118 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Submit.cshtml"
                                                    Write(total_money);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></h2>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 123 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Submit.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 46 "C:\Users\sgn-ginnyn\StationaryMS\Views\Request\Submit.cshtml"
AddHtmlAttributeValue("", 1546, Url.Action("Submit", "Request"), 1546, 32, false);

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
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Body End -->\r\n");
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
