#pragma checksum "C:\MKS-Practice\JewelleryStoreApp\Views\Estimation\Estimation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58876c4cf64197b1d63dd8e260c7501e701def74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estimation_Estimation), @"mvc.1.0.view", @"/Views/Estimation/Estimation.cshtml")]
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
#line 1 "C:\MKS-Practice\JewelleryStoreApp\Views\_ViewImports.cshtml"
using JewelleryStoreApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MKS-Practice\JewelleryStoreApp\Views\_ViewImports.cshtml"
using JewelleryStoreApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MKS-Practice\JewelleryStoreApp\Views\Estimation\Estimation.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58876c4cf64197b1d63dd8e260c7501e701def74", @"/Views/Estimation/Estimation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17c5d46048864ecf48043608dfd32b86d368df99", @"/Views/_ViewImports.cshtml")]
    public class Views_Estimation_Estimation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JewelleryStoreApp.Models.PriceDetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Calculate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PrintFile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PrintPaper", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Estimation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n<script type=\"text/javascript\">\r\n\r\n  function Calculate() {\r\n    alert(\'You clicked \');\r\n  }\r\n\r\n</script>\r\n\r\n");
            }
            );
            WriteLiteral(@"<style>
  .price-estimation {
    background-color: lightgrey;
    padding-left: 25%;
  }

  .user-type {
    text-align: right;
    padding-right: 10px;
  }

  .price-estimation input[type=""text""] {
    padding: 12px 20px;
    margin: 25px;
    margin-right: 0px;
    margin-left: 40px;
    display: inline-block;
    border: 1px solid #ccc;
    box-sizing: border-box;
  }

  .total-price {
    margin-top: 20px;
  }
</style>

<div class=""price-estimation"">
  <p class=""user-type"">Welcome :
");
#nullable restore
#line 41 "C:\MKS-Practice\JewelleryStoreApp\Views\Estimation\Estimation.cshtml"
      
      if (Model.UserType == "P")
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>Privileged user</span>\r\n");
#nullable restore
#line 45 "C:\MKS-Practice\JewelleryStoreApp\Views\Estimation\Estimation.cshtml"
      }
      else
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span> Normal user</span>\r\n");
#nullable restore
#line 49 "C:\MKS-Practice\JewelleryStoreApp\Views\Estimation\Estimation.cshtml"
      }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("  </p>\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58876c4cf64197b1d63dd8e260c7501e701def747887", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 977, "\"", 1000, 1);
#nullable restore
#line 53 "C:\MKS-Practice\JewelleryStoreApp\Views\Estimation\Estimation.cshtml"
WriteAttributeValue("", 985, Model.UserType, 985, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"usertype\">\r\n    <div class=\"price\">\r\n      <label><b>Gold Price (per gram)</b></label>\r\n      <input id=\"price\" type=\"text\" name=\"pricepergram\"");
                BeginWriteAttribute("value", " value=\"", 1151, "\"", 1178, 1);
#nullable restore
#line 56 "C:\MKS-Practice\JewelleryStoreApp\Views\Estimation\Estimation.cshtml"
WriteAttributeValue("", 1159, Model.PricePerGram, 1159, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required>\r\n    </div>\r\n    <div class=\"weight\">\r\n      <label><b>Weight (grams)</b></label>\r\n      <input id=\"weight\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1309, "\"", 1330, 1);
#nullable restore
#line 60 "C:\MKS-Practice\JewelleryStoreApp\Views\Estimation\Estimation.cshtml"
WriteAttributeValue("", 1317, Model.Weight, 1317, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"weight\" required>\r\n    </div>\r\n    <div class=\"total-price\">\r\n      <label><b>Total Price</b></label>\r\n      <input id=\"totalPrice\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1481, "\"", 1506, 1);
#nullable restore
#line 64 "C:\MKS-Practice\JewelleryStoreApp\Views\Estimation\Estimation.cshtml"
WriteAttributeValue("", 1489, Model.TotalPrice, 1489, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"totalprice\">\r\n      <div>\r\n\r\n");
#nullable restore
#line 67 "C:\MKS-Practice\JewelleryStoreApp\Views\Estimation\Estimation.cshtml"
          
          if (Model.UserType == "P")
          {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <label><b>Discount %</b></label>\r\n            <input id=\"discount\" class=\"discount\"");
                BeginWriteAttribute("value", " value=\"", 1701, "\"", 1724, 1);
#nullable restore
#line 71 "C:\MKS-Practice\JewelleryStoreApp\Views\Estimation\Estimation.cshtml"
WriteAttributeValue("", 1709, Model.Discount, 1709, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" name=\"discount\">\r\n");
#nullable restore
#line 72 "C:\MKS-Practice\JewelleryStoreApp\Views\Estimation\Estimation.cshtml"
          }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("      </div>\r\n    </div>\r\n    <div class=\"btn-section\">\r\n      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58876c4cf64197b1d63dd8e260c7501e701def7411202", async() => {
                    WriteLiteral("Calculate");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n      <button type=\"button\"");
                BeginWriteAttribute("onclick", "\r\n        onclick=\"", 1996, "\"", 2194, 23);
                WriteAttributeValue("", 2015, "alert", 2015, 5, true);
                WriteAttributeValue("\r\n      ", 2020, "(`Price", 2028, 15, true);
                WriteAttributeValue(" ", 2035, "Estimation\\nGold", 2036, 17, true);
                WriteAttributeValue(" ", 2052, "Price", 2053, 6, true);
                WriteAttributeValue(" ", 2058, "(per", 2059, 5, true);
                WriteAttributeValue(" ", 2063, "gm):", 2064, 5, true);
                WriteAttributeValue(" ", 2068, "${", 2069, 3, true);
#nullable restore
#line 81 "C:\MKS-Practice\JewelleryStoreApp\Views\Estimation\Estimation.cshtml"
WriteAttributeValue("", 2071, Model.PricePerGram, 2071, 19, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2090, "}\\n", 2090, 3, true);
                WriteAttributeValue(" ", 2093, "weight", 2094, 7, true);
                WriteAttributeValue(" ", 2100, "(gms):", 2101, 7, true);
                WriteAttributeValue(" ", 2107, "${", 2108, 3, true);
#nullable restore
#line 81 "C:\MKS-Practice\JewelleryStoreApp\Views\Estimation\Estimation.cshtml"
WriteAttributeValue("", 2110, Model.Weight, 2110, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2123, "}\\n", 2123, 3, true);
                WriteAttributeValue(" ", 2126, "Discount:", 2127, 10, true);
                WriteAttributeValue(" ", 2136, "${", 2137, 3, true);
#nullable restore
#line 81 "C:\MKS-Practice\JewelleryStoreApp\Views\Estimation\Estimation.cshtml"
WriteAttributeValue("", 2139, Model.Discount, 2139, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2154, "}%\\n", 2154, 4, true);
                WriteAttributeValue(" ", 2158, "Total", 2159, 6, true);
                WriteAttributeValue(" ", 2164, "Price:", 2165, 7, true);
                WriteAttributeValue(" ", 2171, "${", 2172, 3, true);
#nullable restore
#line 81 "C:\MKS-Practice\JewelleryStoreApp\Views\Estimation\Estimation.cshtml"
WriteAttributeValue("", 2174, Model.TotalPrice, 2174, 17, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2191, "}`)", 2191, 3, true);
                EndWriteAttribute();
                WriteLiteral("\r\n        class=\"btn btn-secondary\">Print to Screen</button>\r\n      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58876c4cf64197b1d63dd8e260c7501e701def7415241", async() => {
                    WriteLiteral("Print to File");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58876c4cf64197b1d63dd8e260c7501e701def7416669", async() => {
                    WriteLiteral("Print to Paper");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58876c4cf64197b1d63dd8e260c7501e701def7418098", async() => {
                    WriteLiteral("Close");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JewelleryStoreApp.Models.PriceDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
