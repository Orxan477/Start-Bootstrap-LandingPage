#pragma checksum "C:\Users\Orxan477\source\repos\Start Bootstrap(Landing-page)\Start Bootstrap(Landing-page)\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba21c8fdc5db57c2b23c80f8f464979fb02e1d9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Orxan477\source\repos\Start Bootstrap(Landing-page)\Start Bootstrap(Landing-page)\Views\_ViewImports.cshtml"
using Start_Bootstrap_Landing_page_.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba21c8fdc5db57c2b23c80f8f464979fb02e1d9f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65a9386b96e997b4ac6b75ec7c60bdab9d02cb91", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 500px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("p-0 m-0 w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<main>
    <section id=""homeIntro"">
        <div class=""container"">
            <div class=""row justify-content-center "">
                <div class=""col-lg-5 col-md-6 col-sm-12"">
                    <div class=""homeHead"">
                        <h1>Generate more leads with a professional landing page!</h1>
                    </div>
                </div>
            </div>
            <div class=""row justify-content-center"">
                <div class=""col-lg-7 col-md-6 col-sm-12 emailSent mt-5"">
                    <input type=""email"" name=""Email"" placeholder=""Email Adress"" id=""email"">
                    <label class=""btn btn-primary mb-3 ml-2 mt-1"" id=""emailButton"">Submit</label>
                </div>
            </div>
        </div>
    </section>

    <section id=""BootstrapProp"" style=""background-color:rgb(235, 234, 233); min-height: 550px;  "" class=""w-100 h-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12 col-md-12 col");
            WriteLiteral(@"-sm-12 PropRow"">
                    <div class=""row"">
                        <div class=""col-lg-4 col-md-6 col-sm-12 Propcard"">
                            <div class=""cardImg"">
                                <i class=""far fa-window-maximize logo ""></i>
                            </div>
                            <div class=""cardHead mt-3"">
                                <h3>Fully Responsive</h3>
                            </div>
                            <div class=""cardContent mt-3"">
                                This theme will look great on any device, no matter the size!
                            </div>
                        </div>
                        <div class=""col-lg-4 col-md-6 col-sm-12 Propcard"">
                            <div class=""cardImg"">
                                <i class=""fas fa-layer-group logo""></i>
                            </div>
                            <div class=""cardHead mt-3"">
                                <h3>Bootstrap 5 Ready</h3>");
            WriteLiteral(@"
                            </div>
                            <div class=""cardContent mt-3"">
                                Featuring the latest build of the new Bootstrap 5 framework!
                            </div>
                        </div>
                        <div class=""col-lg-4 col-md-6 col-sm-12 Propcard"">
                            <div class=""cardImg"">
                                <i class=""fas fa-terminal logo""></i>
                            </div>
                            <div class=""cardHead mt-3"">
                                <h3>Easy to Use</h3>
                            </div>
                            <div class=""cardContent mt-3"">
                                Ready to use with your own content, or customize the source files!
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section id=""information"">
        <div class");
            WriteLiteral("=\"container-fluid p-0 w-100\">\r\n");
#nullable restore
#line 68 "C:\Users\Orxan477\source\repos\Start Bootstrap(Landing-page)\Start Bootstrap(Landing-page)\Views\Home\Index.cshtml"
             foreach (var info in Model.Informations)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-lg-6 col-md-12 col-sm-12 info w-100 m-0 p-0\">\r\n                        <div class=\"infoHead d-flex justify-content-center\">\r\n                            <h2>");
#nullable restore
#line 73 "C:\Users\Orxan477\source\repos\Start Bootstrap(Landing-page)\Start Bootstrap(Landing-page)\Views\Home\Index.cshtml"
                           Write(info.Head);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        </div>\r\n                        <div class=\"infoContent\">\r\n                            <p>\r\n                                ");
#nullable restore
#line 77 "C:\Users\Orxan477\source\repos\Start Bootstrap(Landing-page)\Start Bootstrap(Landing-page)\Views\Home\Index.cshtml"
                           Write(info.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-lg-6 col-md-12 col-sm-12 w-100 m-0 p-0\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ba21c8fdc5db57c2b23c80f8f464979fb02e1d9f8781", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3802, "~/assets/img/", 3802, 13, true);
#nullable restore
#line 82 "C:\Users\Orxan477\source\repos\Start Bootstrap(Landing-page)\Start Bootstrap(Landing-page)\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3815, info.Image, 3815, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 86 "C:\Users\Orxan477\source\repos\Start Bootstrap(Landing-page)\Start Bootstrap(Landing-page)\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </section>

    <section id=""peopleSay"" style=""background-color:rgb(235, 234, 233);"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12 col-md-12 col-sm-12 PropRow"">
                    <div class=""sayHead d-flex justify-content-center"">
                        <h3>What people are saying...</h3>
                    </div>
                </div>

            </div>
            <div class=""row mt-4"">
                <div class=""col-lg-4 col-md-6 col-sm-12 Propcard"">
                    <div class=""sayImg"">
                        <img src=""https://startbootstrap.github.io/startbootstrap-landing-page/assets/img/testimonials-1.jpg""
                             style=""max-width: 180px;""");
            BeginWriteAttribute("alt", " alt=\"", 4757, "\"", 4763, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""sayHead mt-3"">
                        <h5>Margaret E.</h5>
                    </div>
                    <div class=""sayContent mt-3"">
                        ""This is fantastic! Thanks so much guys!""
                    </div>
                </div>
                <div class=""col-lg-4 col-md-6 col-sm-12 Propcard"">
                    <div class=""sayImg"">
                        <img src=""https://startbootstrap.github.io/startbootstrap-landing-page/assets/img/testimonials-2.jpg""
                             style=""max-width: 180px;""");
            BeginWriteAttribute("alt", " alt=\"", 5378, "\"", 5384, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""sayHead mt-3"">
                        <h5>Fred S.</h5>
                    </div>
                    <div class=""sayContent mt-3"">
                        ""Bootstrap is amazing. I've been using it to create lots of super nice landing pages.""
                    </div>
                </div>
                <div class=""col-lg-4 col-md-6 col-sm-12 Propcard mb-5"">
                    <div class=""sayImg"">
                        <img src=""https://startbootstrap.github.io/startbootstrap-landing-page/assets/img/testimonials-3.jpg""
                             style=""max-width: 180px;""");
            BeginWriteAttribute("alt", " alt=\"", 6045, "\"", 6051, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""sayHead mt-3"">
                        <h5>Sarah W.</h5>
                    </div>
                    <div class=""sayContent mt-3 mb-5"">
                        ""Thanks so much for making these free resources available to us!""
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section id=""Email"">
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-lg-6 col-md-6 col-sm-12"">
                    <div class=""homeHead"">
                        <h2>Ready to get started? Sign up now!</h2>
                    </div>
                </div>
            </div>
            <div class=""row justify-content-center"">
                <div class=""col-lg-7 col-md-6 col-sm-12 emailSent mt-3"">
                    <input type=""email"" name=""Email"" placeholder=""Email Adress"" id=""email"">
                    <label class=""btn btn-p");
            WriteLiteral("rimary mb-3 ml-2 mt-1\" id=\"emailButton\">Submit</label>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591