#pragma checksum "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56df58931ef5b184ade619d32d9d6e6b47ca83a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_IMEI_DienThoai_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/IMEI_DienThoai/Edit.cshtml")]
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
#line 1 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\_ViewImports.cshtml"
using CuaHangDienThoai;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\_ViewImports.cshtml"
using CuaHangDienThoai.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56df58931ef5b184ade619d32d9d6e6b47ca83a1", @"/Areas/Admin/Views/IMEI_DienThoai/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6d6bff9ae6a27aa327a2ebff889acbe2aed1362", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_IMEI_DienThoai_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CuaHangDienThoai.Models.View.CTHoaDonViewIMEI>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return validate()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("L??u"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Edit.cshtml"
  
    ViewData["Title"] = "Ch???nh s???a";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Edit.cshtml"
  
    var message = TempData["message"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 class=\"text-success\" style=\"text-align:center\">Chi ti???t</h1>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56df58931ef5b184ade619d32d9d6e6b47ca83a17037", async() => {
                WriteLiteral("\n    <table class=\"table\">\n        <tr class=\"table-info\">\n            <th>\n                ");
#nullable restore
#line 14 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Edit.cshtml"
           Write(Html.DisplayNameFor(model => model.chiTietHoaDon.MaHD));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 17 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Edit.cshtml"
           Write(Html.DisplayNameFor(model => model.chiTietHoaDon.MaDT));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </th>\n            <th>\n                IMEI\n            </th>\n            <th></th>\n        </tr>\n        <tr>\n            <td>\n                <lable>");
#nullable restore
#line 26 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Edit.cshtml"
                  Write(Model.chiTietHoaDon.MaHD);

#line default
#line hidden
#nullable disable
                WriteLiteral("</lable>\n            </td>\n            <td>\n                <lable>");
#nullable restore
#line 29 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Edit.cshtml"
                  Write(Model.chiTietHoaDon.MaDT);

#line default
#line hidden
#nullable disable
                WriteLiteral("</lable>\n            </td>\n            <td>\r\n");
#nullable restore
#line 32 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Edit.cshtml"
                 for (int i = 0; i < Model.chiTietHoaDon.SoLuong; i++)
                {
                    var name = Model.chiTietHoaDon.MaDT.ToString() + i.ToString();
                    if (message != null)
                    {
                        var value = TempData[name];
                        if (value.Equals("Tr??ng IMEI vui l??ng th??? l???i"))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <label class=\"form-group text-danger\">");
#nullable restore
#line 40 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Edit.cshtml"
                                                             Write(value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                            <br />\r\n                            <input type=\"number\"");
                BeginWriteAttribute("name", " name=", 1366, "", 1377, 1);
#nullable restore
#line 42 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Edit.cshtml"
WriteAttributeValue("", 1372, name, 1372, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=15  class=\"form-group form-control\" required style=\"width:250px;\" />\r\n                            <br />\r\n");
#nullable restore
#line 44 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Edit.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <input type=\"number\"");
                BeginWriteAttribute("name", " name=", 1620, "", 1631, 1);
#nullable restore
#line 47 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Edit.cshtml"
WriteAttributeValue("", 1626, name, 1626, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"15\" maxlength=\"50\" class=\"form-group form-control\"");
                BeginWriteAttribute("value", " value=", 1687, "", 1700, 1);
#nullable restore
#line 47 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Edit.cshtml"
WriteAttributeValue("", 1694, value, 1694, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required style=\"width:250px;\" />\r\n");
                WriteLiteral("                            <br />\r\n");
#nullable restore
#line 50 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Edit.cshtml"
                        }
                    }
                    else
                    {
                        var value = TempData[name];
                        if (value != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <input type=\"number\"");
                BeginWriteAttribute("name", " name=", 2105, "", 2116, 1);
#nullable restore
#line 57 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Edit.cshtml"
WriteAttributeValue("", 2111, name, 2111, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  min=\"15\" maxlength=\"50\" class=\"form-group form-control\"");
                BeginWriteAttribute("value", " value=", 2173, "", 2186, 1);
#nullable restore
#line 57 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Edit.cshtml"
WriteAttributeValue("", 2180, value, 2180, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required style=\"width:250px;\"/>\r\n");
                WriteLiteral("                            <br />\r\n");
#nullable restore
#line 60 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Edit.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <input type=\"number\"");
                BeginWriteAttribute("name", " name=", 2451, "", 2462, 1);
#nullable restore
#line 63 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Edit.cshtml"
WriteAttributeValue("", 2457, name, 2457, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"15\" maxlength=\"50\" class=\"form-group form-control\" required style=\"width:250px;\"/>\r\n");
                WriteLiteral("                            <br />\r\n");
#nullable restore
#line 66 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Edit.cshtml"
                        }

                    }
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </td>\n\n\n        </tr>\n    </table>\n");
#nullable restore
#line 75 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Edit.cshtml"
      var id = Model.chiTietHoaDon.MaHD.ToString() + Model.chiTietHoaDon.MaDT.ToString();
        TempData.Clear();

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"col-12 row\" style=\"position:absolute;left:50%\">\r\n");
                WriteLiteral("    <div class=\"col-1\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "56df58931ef5b184ade619d32d9d6e6b47ca83a115393", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\IMEI_DienThoai\Edit.cshtml"
                                                                                                              WriteLiteral(id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n    \r\n    <div class=\"col-2\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56df58931ef5b184ade619d32d9d6e6b47ca83a118148", async() => {
                    WriteLiteral("<i class=\"fas fa-arrow-circle-left\"></i>Tr??? l???i");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n    \r\n\r\n</div>\n    \n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    // L???y gi?? tr??? c???a m???t input
    function getValue(id) {
        return document.getElementById(id).value.trim();
    }
    //Hi???n th??? l???i
    function showError(key, mess) {
        document.getElementById(key + '_error').innerHTML = mess;
    }
    function validate() {
        var flag = true;
        var imei = getValue('imei')
        if (imei == '' || imei.length < 15) {
            flag = false;
            showError('imei','Vui l??ng nh???p Imei c?? ??t nh???t 15 k?? t??? s???')
        }
        return flag;
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CuaHangDienThoai.Models.View.CTHoaDonViewIMEI> Html { get; private set; }
    }
}
#pragma warning restore 1591
