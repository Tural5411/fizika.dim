#pragma checksum "C:\Users\Tural\source\repos\Fizika\Fizika.Mvc\Views\Home\_ArticlePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c19db119f01d7c81b29871cd003b7565d150a1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__ArticlePartial), @"mvc.1.0.view", @"/Views/Home/_ArticlePartial.cshtml")]
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
#line 1 "C:\Users\Tural\source\repos\Fizika\Fizika.Mvc\Views\_ViewImports.cshtml"
using Fizika.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tural\source\repos\Fizika\Fizika.Mvc\Views\_ViewImports.cshtml"
using Fizika.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c19db119f01d7c81b29871cd003b7565d150a1a", @"/Views/Home/_ArticlePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4bd1ee673c34c6c0a1ac214022f1cfeccd6a586", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__ArticlePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fizika.Mvc.Models.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Article", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""blog_area pt-120 pb-130"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-8"">
                <div class=""section_title text-center pb-20"">
                    <h3 class=""main_title"">Bloqlar</h3>
                    <p>Nihad müəllim Şahbazovun yazdığı bloqlar ilə siz tədrisinizdə istifadə edəbiləcəyiniz faydalı məlumatlar öyrənəcəksiniz</p>
                </div>
            </div>
        </div>
        <div class=""row justify-content-center"">
");
#nullable restore
#line 13 "C:\Users\Tural\source\repos\Fizika\Fizika.Mvc\Views\Home\_ArticlePartial.cshtml"
             foreach (var blog in Model.ArticleListDto.Articles)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-7\">\r\n                    <div class=\"single_blog mt-30\">\r\n                        <div class=\"blog_image\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7c19db119f01d7c81b29871cd003b7565d150a1a4888", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 848, "~/img/", 848, 6, true);
#nullable restore
#line 18 "C:\Users\Tural\source\repos\Fizika\Fizika.Mvc\Views\Home\_ArticlePartial.cshtml"
AddHtmlAttributeValue("", 854, blog.ThumbNail, 854, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 18 "C:\Users\Tural\source\repos\Fizika\Fizika.Mvc\Views\Home\_ArticlePartial.cshtml"
AddHtmlAttributeValue("", 876, blog.Title, 876, 11, false);

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
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"blog_content\">\r\n                            <span class=\"date\"><span>");
#nullable restore
#line 21 "C:\Users\Tural\source\repos\Fizika\Fizika.Mvc\Views\Home\_ArticlePartial.cshtml"
                                                Write(blog.CreatedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></span>\r\n\r\n                            <div class=\"blog_content_wrapper\">\r\n                                <ul class=\"blog_meta\">\r\n                                    <li><a href=\"#\">");
#nullable restore
#line 25 "C:\Users\Tural\source\repos\Fizika\Fizika.Mvc\Views\Home\_ArticlePartial.cshtml"
                                               Write(blog.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                    <li><a href=\"#\">");
#nullable restore
#line 26 "C:\Users\Tural\source\repos\Fizika\Fizika.Mvc\Views\Home\_ArticlePartial.cshtml"
                                               Write(blog.CreatedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                </ul>\r\n                                <h4 class=\"blog_title\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c19db119f01d7c81b29871cd003b7565d150a1a8186", async() => {
#nullable restore
#line 28 "C:\Users\Tural\source\repos\Fizika\Fizika.Mvc\Views\Home\_ArticlePartial.cshtml"
                                                                                                                                 Write(blog.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-articleId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\Tural\source\repos\Fizika\Fizika.Mvc\Views\Home\_ArticlePartial.cshtml"
                                                                                                                WriteLiteral(blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["articleId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-articleId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["articleId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 33 "C:\Users\Tural\source\repos\Fizika\Fizika.Mvc\Views\Home\_ArticlePartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fizika.Mvc.Models.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591