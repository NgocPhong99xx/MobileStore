#pragma checksum "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\Shared\_News.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35d71a51015a5a21aac8a97aac1a3cf44b88d254"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__News), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_News.cshtml")]
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
#nullable restore
#line 1 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\Shared\_News.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\Shared\_News.cshtml"
using CuaHangDienThoai.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\Shared\_News.cshtml"
using CuaHangDienThoai.Models.View;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35d71a51015a5a21aac8a97aac1a3cf44b88d254", @"/Areas/Admin/Views/Shared/_News.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6d6bff9ae6a27aa327a2ebff889acbe2aed1362", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__News : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item d-flex align-items-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DonHangs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Duyet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\Shared\_News.cshtml"
  
    ViewData["Title"] = "_News";

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\Shared\_News.cshtml"
 if (HttpContextAccessor.HttpContext.Session.GetString(CommonAdmin.USER_SESSION) != null)
{
    KhachHangAndDonHang khachHangAndDonHangs = ViewBag.khachHangAndDonHangs;
    var count = khachHangAndDonHangs.MaDH.Count();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <li class=""nav-item dropdown no-arrow mx-1"">
        <a class=""nav-link dropdown-toggle"" href=""#"" id=""alertsDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            <i class=""fas fa-bell fa-fw""></i>
            <!-- Counter - Alerts -->
            <span class=""badge badge-danger badge-counter"">");
#nullable restore
#line 16 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\Shared\_News.cshtml"
                                                      Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n        </a>\n        <!-- Dropdown - Alerts -->\n        <div class=\"dropdown-list dropdown-menu dropdown-menu-right shadow animated--grow-in\" aria-labelledby=\"alertsDropdown\">\n");
#nullable restore
#line 20 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\Shared\_News.cshtml"
             if (Convert.ToInt32(count) > 0)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <h6 class=\"dropdown-header\">\n                    Đơn hàng chưa duyệt \n                </h6>\n");
#nullable restore
#line 26 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\Shared\_News.cshtml"
                for (int i = 0; i < Convert.ToInt32(count); i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35d71a51015a5a21aac8a97aac1a3cf44b88d2547546", async() => {
                WriteLiteral(@"
                        <div class=""mr-3"">
                            <div class=""icon-circle bg-primary"">
                                <i class=""fas fa-file-alt text-white""></i>
                            </div>
                        </div>
                        <div>
                            
                            <span class=""font-weight-bold"">Khách hàng ");
#nullable restore
#line 36 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\Shared\_News.cshtml"
                                                                 Write(khachHangAndDonHangs.TenKH[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" đã đặt hàng</span>\n                        </div>\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-MaDH", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\Shared\_News.cshtml"
                                                                                                                                         WriteLiteral(khachHangAndDonHangs.MaDH[i]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MaDH"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-MaDH", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MaDH"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 39 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\Shared\_News.cshtml"
                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </li>\n");
            WriteLiteral("    <!-- Nav Item - Messages -->\n    <li class=\"nav-item dropdown no-arrow mx-1\">\n        <div class=\"topbar-divider d-none d-sm-block\"></div>\n        <!-- Nav Item - User Information -->\n    </li>\n");
#nullable restore
#line 50 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\Shared\_News.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
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
