#pragma checksum "C:\Users\Tural\source\repos\Fizika\Fizika.Mvc\Areas\Admin\Views\Registers\_RegisterDetailPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bd0ec3bd3eb2cb76ecb5180c1f87f726af10b9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Registers__RegisterDetailPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Registers/_RegisterDetailPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bd0ec3bd3eb2cb76ecb5180c1f87f726af10b9e", @"/Areas/Admin/Views/Registers/_RegisterDetailPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d587d1119c7c9b37fa9ab078bbcf9a12e73b654", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Registers__RegisterDetailPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fizika.Entities.DTOs.RegisterDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title""><span class=""fas fa-newspaper-o""></span> <b>");
#nullable restore
#line 6 "C:\Users\Tural\source\repos\Fizika\Fizika.Mvc\Areas\Admin\Views\Registers\_RegisterDetailPartial.cshtml"
                                                                               Write(Model.Register.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" adli şəxsin şərhi</b> </h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Bağla"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
#nullable restore
#line 12 "C:\Users\Tural\source\repos\Fizika\Fizika.Mvc\Areas\Admin\Views\Registers\_RegisterDetailPartial.cshtml"
           Write(Model.Register.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger btn-block"" data-dismiss=""modal""><span class=""fas fa-times""></span> Bağla</button>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fizika.Entities.DTOs.RegisterDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
