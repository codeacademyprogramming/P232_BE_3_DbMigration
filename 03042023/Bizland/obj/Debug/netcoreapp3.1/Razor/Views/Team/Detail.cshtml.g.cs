#pragma checksum "C:\Users\Eagha\Desktop\CodeLessons\P232\Backend\4. 03-04-2023\03042023\Bizland\Views\Team\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8bb836dc86ecfb431a13d0426c5d3958dd0191f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Team_Detail), @"mvc.1.0.view", @"/Views/Team/Detail.cshtml")]
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
#line 1 "C:\Users\Eagha\Desktop\CodeLessons\P232\Backend\4. 03-04-2023\03042023\Bizland\Views\_ViewImports.cshtml"
using Bizland;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eagha\Desktop\CodeLessons\P232\Backend\4. 03-04-2023\03042023\Bizland\Views\_ViewImports.cshtml"
using Bizland.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8bb836dc86ecfb431a13d0426c5d3958dd0191f", @"/Views/Team/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef7f32a471736cdb06713347eb862623b1140472", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Team_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeamMember>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Eagha\Desktop\CodeLessons\P232\Backend\4. 03-04-2023\03042023\Bizland\Views\Team\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main id=""main"">
    <div class=""row d-flex justify-content-center"">
    <div class=""col-lg-8 col-md-8 d-flex  align-items-stretch"" data-aos=""fade-up"" data-aos-delay=""400"">
        <div class=""member"">
            <div class=""member-img"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c8bb836dc86ecfb431a13d0426c5d3958dd0191f4393", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 333, "~/assets/img/team/", 333, 18, true);
#nullable restore
#line 11 "C:\Users\Eagha\Desktop\CodeLessons\P232\Backend\4. 03-04-2023\03042023\Bizland\Views\Team\Detail.cshtml"
AddHtmlAttributeValue("", 351, Model.Image, 351, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <div class=\"social\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 452, "\"", 459, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-twitter\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 518, "\"", 525, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-facebook\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 585, "\"", 592, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-instagram\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 653, "\"", 660, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-linkedin\"></i></a>\r\n                </div>\r\n            </div>\r\n            <div class=\"member-info\">\r\n                <h4>");
#nullable restore
#line 20 "C:\Users\Eagha\Desktop\CodeLessons\P232\Backend\4. 03-04-2023\03042023\Bizland\Views\Team\Detail.cshtml"
               Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <span>");
#nullable restore
#line 21 "C:\Users\Eagha\Desktop\CodeLessons\P232\Backend\4. 03-04-2023\03042023\Bizland\Views\Team\Detail.cshtml"
                 Write(Model.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n     </div>\r\n    </div>\r\n</main>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeamMember> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
