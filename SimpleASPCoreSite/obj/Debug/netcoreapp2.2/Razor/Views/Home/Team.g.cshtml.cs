#pragma checksum "D:\999\ASP2\ASP2-1\ASP_2_1\SimpleASPCoreSite\SimpleASPCoreSite\SimpleASPCoreSite\Views\Home\Team.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfc1dd959b9c17dc110e65b24f59d586de0e714d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Team), @"mvc.1.0.view", @"/Views/Home/Team.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Team.cshtml", typeof(AspNetCore.Views_Home_Team))]
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
#line 1 "D:\999\ASP2\ASP2-1\ASP_2_1\SimpleASPCoreSite\SimpleASPCoreSite\SimpleASPCoreSite\Views\_ViewImports.cshtml"
using SimpleASPCoreSite;

#line default
#line hidden
#line 2 "D:\999\ASP2\ASP2-1\ASP_2_1\SimpleASPCoreSite\SimpleASPCoreSite\SimpleASPCoreSite\Views\_ViewImports.cshtml"
using SimpleASPCoreSite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfc1dd959b9c17dc110e65b24f59d586de0e714d", @"/Views/Home/Team.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dc25ceec6bb01b125e8ca3cd69e9f3ae75f7848", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Team : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\999\ASP2\ASP2-1\ASP_2_1\SimpleASPCoreSite\SimpleASPCoreSite\SimpleASPCoreSite\Views\Home\Team.cshtml"
  
    ViewData["Title"] = "Team";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(89, 457, true);
            WriteLiteral(@"
<div>
    <div class=""breadcrumb-area bg-image section-ptb"" style=""background-image: url(/images/bg/breadcrumb-bg.jpg)"">
        <div>
            <div class=""breadcrumb"">
                <div class=""row"">
                    <div class=""col"">
                        <h2>Team</h2>
                        <!-- breadcrumb-list start -->
                        <ul class=""breadcrumb-list"">
                            <li class=""breadcrumb-item"">");
            EndContext();
            BeginContext(546, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfc1dd959b9c17dc110e65b24f59d586de0e714d4952", async() => {
                BeginContext(602, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(610, 8890, true);
            WriteLiteral(@"</li>
                            <li class=""breadcrumb-item active"">Team</li>
                        </ul>
                        <!-- breadcrumb-list end -->
                    </div>
                </div>
            </div>
        </div>
    </div>


    <div class=""section-team section-pt section-pb-90 bg-gray"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""section-title text-center"">
                        <h2>Our Guards</h2>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore</p>
                    </div>
                </div>
            </div>
            <!-- Start Team Area -->
            <div class=""row"">
                <!-- Start Single Team -->
                <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-12 col-12"">
                    <div class=""team team-8 mb-30"">
                        <div clas");
            WriteLiteral(@"s=""thumb"">
                            <a href=""#"">
                                <img src=""/images/team/team-01.jpg"" alt=""team img"">
                            </a>
                        </div>
                        <div class=""team-info"">
                            <div class=""content"">
                                <h4><a href=""#"">Burns Laura</a></h4>
                                <span>Director</span>
                            </div>
                            <ul class=""social-network social-net-2"">
                                <li><a class=""facebook"" href=""#""><i class=""fa fa-facebook""></i></a></li>
                                <li><a class=""twitter"" href=""#""><i class=""fa fa-twitter""></i></a></li>
                                <li><a class=""google-plus"" href=""#""><i class=""fa fa-google-plus""></i></a></li>
                                <li><a class=""vimeo"" href=""#""><i class=""fa fa-vimeo""></i></a></li>
                            </ul>
                        </div>");
            WriteLiteral(@"
                    </div>
                </div>
                <!-- End Single Team -->
                <!-- Start Single Team -->
                <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-12 col-12"">
                    <div class=""team team-8 mb-30"">
                        <div class=""thumb"">
                            <a href=""#"">
                                <img src=""/images/team/team-02.jpg"" alt=""team img"">
                            </a>
                        </div>
                        <div class=""team-info"">
                            <div class=""content"">
                                <h4><a href=""#"">Hansen Russell</a></h4>
                                <span>Director</span>
                            </div>
                            <ul class=""social-network social-net-2"">
                                <li><a class=""facebook"" href=""#""><i class=""fa fa-facebook""></i></a></li>
                                <li><a class=""twitter"" href=""#""><i class=""fa fa");
            WriteLiteral(@"-twitter""></i></a></li>
                                <li><a class=""google-plus"" href=""#""><i class=""fa fa-google-plus""></i></a></li>
                                <li><a class=""vimeo"" href=""#""><i class=""fa fa-vimeo""></i></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <!-- End Single Team -->
                <!-- Start Single Team -->
                <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-12 col-12"">
                    <div class=""team team-8 mb-30"">
                        <div class=""thumb"">
                            <a href=""#"">
                                <img src=""/images/team/team-04.jpg"" alt=""team img"">
                            </a>
                        </div>
                        <div class=""team-info"">
                            <div class=""content"">
                                <h4><a href=""#"">Moore Virginia</a></h4>
                                <span>Direc");
            WriteLiteral(@"tor</span>
                            </div>
                            <ul class=""social-network social-net-2"">
                                <li><a class=""facebook"" href=""#""><i class=""fa fa-facebook""></i></a></li>
                                <li><a class=""twitter"" href=""#""><i class=""fa fa-twitter""></i></a></li>
                                <li><a class=""google-plus"" href=""#""><i class=""fa fa-google-plus""></i></a></li>
                                <li><a class=""vimeo"" href=""#""><i class=""fa fa-vimeo""></i></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <!-- End Single Team -->
                <!-- Start Single Team -->
                <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-12 col-12"">
                    <div class=""team team-8 mb-30"">
                        <div class=""thumb"">
                            <a href=""#"">
                                <img src=""/images/team/team-05.j");
            WriteLiteral(@"pg"" alt=""team img"">
                            </a>
                        </div>
                        <div class=""team-info"">
                            <div class=""content"">
                                <h4><a href=""#"">Cheryl Murray</a></h4>
                                <span>Director</span>
                            </div>
                            <ul class=""social-network social-net-2"">
                                <li><a class=""facebook"" href=""#""><i class=""fa fa-facebook""></i></a></li>
                                <li><a class=""twitter"" href=""#""><i class=""fa fa-twitter""></i></a></li>
                                <li><a class=""google-plus"" href=""#""><i class=""fa fa-google-plus""></i></a></li>
                                <li><a class=""vimeo"" href=""#""><i class=""fa fa-vimeo""></i></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <!-- End Single Team -->
                <!-- ");
            WriteLiteral(@"Start Single Team -->
                <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-12 col-12"">
                    <div class=""team team-8 mb-30"">
                        <div class=""thumb"">
                            <a href=""#"">
                                <img src=""/images/team/team-06.jpg"" alt=""team img"">
                            </a>
                        </div>
                        <div class=""team-info"">
                            <div class=""content"">
                                <h4><a href=""#"">Doris Welch</a></h4>
                                <span>Director</span>
                            </div>
                            <ul class=""social-network social-net-2"">
                                <li><a class=""facebook"" href=""#""><i class=""fa fa-facebook""></i></a></li>
                                <li><a class=""twitter"" href=""#""><i class=""fa fa-twitter""></i></a></li>
                                <li><a class=""google-plus"" href=""#""><i class=""fa fa-google-plu");
            WriteLiteral(@"s""></i></a></li>
                                <li><a class=""vimeo"" href=""#""><i class=""fa fa-vimeo""></i></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <!-- End Single Team -->
                <!-- Start Single Team -->
                <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-12 col-12"">
                    <div class=""team team-8 mb-30"">
                        <div class=""thumb"">
                            <a href=""#"">
                                <img src=""/images/team/team-03.jpg"" alt=""team img"">
                            </a>
                        </div>
                        <div class=""team-info"">
                            <div class=""content"">
                                <h4><a href=""#"">Virginia Moore</a></h4>
                                <span>Director</span>
                            </div>
                            <ul class=""social-network social-net-2"">
 ");
            WriteLiteral(@"                               <li><a class=""facebook"" href=""#""><i class=""fa fa-facebook""></i></a></li>
                                <li><a class=""twitter"" href=""#""><i class=""fa fa-twitter""></i></a></li>
                                <li><a class=""google-plus"" href=""#""><i class=""fa fa-google-plus""></i></a></li>
                                <li><a class=""vimeo"" href=""#""><i class=""fa fa-vimeo""></i></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <!-- End Single Team -->
            </div>
            <!-- End Team Area -->
        </div>
    </div>











</div>

");
            EndContext();
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
