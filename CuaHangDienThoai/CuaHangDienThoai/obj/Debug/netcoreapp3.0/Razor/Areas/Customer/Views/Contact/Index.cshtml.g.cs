#pragma checksum "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Customer\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6c384b00be41214433ac4bf34c1abfd2a18c26c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Contact_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Customer\Views\_ViewImports.cshtml"
using CuaHangDienThoai;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Customer\Views\_ViewImports.cshtml"
using CuaHangDienThoai.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6c384b00be41214433ac4bf34c1abfd2a18c26c", @"/Areas/Customer/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6d6bff9ae6a27aa327a2ebff889acbe2aed1362", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\342 HUNG VUONG\OneDrive\Desktop\CD&BC\CODE\CuaHangDienThoai\CuaHangDienThoai\Areas\Customer\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Customer/Views/Shared/_CustomerLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""content"">
    <br />
    <h2>Bản đồ</h2>
    <div class=""map"" style=""width:100%;height:auto;"">
     <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d8894.559881651388!2d105.98286245284747!3d20.39518311729855!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3135d9cc41b899ed%3A0x1e8dab2d713f0e8!2zQW4gTmjDom4sIFnDqm4gVMOibiwgw50gWcOqbiwgTmFtIMSQ4buLbmgsIFZp4buHdCBOYW0!5e0!3m2!1svi!2s!4v1627574680058!5m2!1svi!2s"" width=""600"" height=""450"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 611, "\"", 629, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\"></iframe>\r\n    </div>\r\n    </div>\r\n\r\n\r\n");
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