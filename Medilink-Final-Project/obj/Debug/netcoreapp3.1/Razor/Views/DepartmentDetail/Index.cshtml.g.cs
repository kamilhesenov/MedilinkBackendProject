#pragma checksum "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\DepartmentDetail\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c71e4425645c2bc24ee26333493a42e7a668dcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DepartmentDetail_Index), @"mvc.1.0.view", @"/Views/DepartmentDetail/Index.cshtml")]
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
#line 1 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\_ViewImports.cshtml"
using Medilink_Final_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\_ViewImports.cshtml"
using Medilink_Final_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\_ViewImports.cshtml"
using Medilink_Final_Project.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c71e4425645c2bc24ee26333493a42e7a668dcd", @"/Views/DepartmentDetail/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3633da3bd55105d4a80d2094ce2e9712a69adbfb", @"/Views/_ViewImports.cshtml")]
    public class Views_DepartmentDetail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DepartmentDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DepartmentDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DoctorDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("appointment-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\DepartmentDetail\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main>\r\n    <!-- Banner section start -->\r\n    <section id=\"banner\">\r\n        <div class=\"page-banner\">\r\n            <div class=\"container-fluid\">\r\n                <div class=\"banner-connet\">\r\n                    <h1>");
#nullable restore
#line 12 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\DepartmentDetail\Index.cshtml"
                   Write(Model.Department.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                    <div class=""breadcrumb-area"">
                        <div class=""banner-breadcrumb"">
                            <span class=""icon"">
                                <a href=""#"">
                                    <span>Medilink</span>
                                    &nbsp;
                                </a>
                                >
                                <a href=""#"">
                                    &nbsp;
                                    <span>Departments</span>
                                    &nbsp;
                                </a>
                                >
                                <a href=""#"">
                                    &nbsp;
                                    <span>Dedicated</span>
                                    &nbsp;
                                </a>
                                >
                            </span>
                            <span class=""post-page"">");
#nullable restore
#line 34 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\DepartmentDetail\Index.cshtml"
                                               Write(Model.Department.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Banner section end -->

    <!-- Department Detail section start -->
    <section id=""department-detail"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-12 col-md-12 col-sm-12"">
                    <div class=""row"">
                        <div class=""col-lg-3 col-md-12 col-sm-12"">
                            <div class=""widget-department-info wow fadeInLeft"" data-wow-duration=""3s"">
                                <h2>All Departments</h2>
                                <ul class=""tab-nav-list"">
");
#nullable restore
#line 53 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\DepartmentDetail\Index.cshtml"
                                     foreach (var item in Model.Departments)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"nav-item\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c71e4425645c2bc24ee26333493a42e7a668dcd8792", async() => {
#nullable restore
#line 56 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\DepartmentDetail\Index.cshtml"
                                                                                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <i class=\"fas fa-angle-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\DepartmentDetail\Index.cshtml"
                                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </li>\r\n");
#nullable restore
#line 58 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\DepartmentDetail\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </ul>
                            </div>
                            <div class=""call-to-action wow fadeInLeft"" data-wow-delay=""0.5s"" data-wow-duration=""3s"">
                                <div class=""media"">
                                    <img src=""assets/img/figure6.png"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 2846, "\"", 2852, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div class=""media-body"">
                                        <h4>Emergency Cases</h4>
                                        <span>+001236540256</span>
                                    </div>
                                </div>
                            </div>
                            <div class=""widget-schedule wow fadeInLeft"" data-wow-delay=""1s"" data-wow-duration=""3s"">
                                <h3>Opening Hours</h3>
                                <ul>
                                    <li>Saturday - Monday: <span>09:00 am - 10.00 pm</span></li>
                                    <li>Tuesday - Thursday: <span>09:00 am - 10.00 pm</span></li>
                                </ul>
                            </div>
                        </div>
                        <div class=""col-lg-9 col-md-12 col-sm-12"">
                            <div class=""single-department-box wow fadeInRight"" data-wow-duration=""3s"">
                  ");
            WriteLiteral("              <div class=\"single-department-data\">\r\n                                    <div class=\"single-department-img\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1c71e4425645c2bc24ee26333493a42e7a668dcd13622", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4052, "~/uploads/", 4052, 10, true);
#nullable restore
#line 82 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\DepartmentDetail\Index.cshtml"
AddHtmlAttributeValue("", 4062, Model.Department.Photo, 4062, 23, false);

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
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"department-content\">\r\n                                        <div class=\"item-content\">\r\n                                            <h3>");
#nullable restore
#line 86 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\DepartmentDetail\Index.cshtml"
                                           Write(Model.Department.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                            <p>");
#nullable restore
#line 87 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\DepartmentDetail\Index.cshtml"
                                          Write(Model.Department.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <p>");
#nullable restore
#line 88 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\DepartmentDetail\Index.cshtml"
                                          Write(Model.Department.Advantage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <h3>Advantage:</h3>\r\n                                            <p>");
#nullable restore
#line 90 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\DepartmentDetail\Index.cshtml"
                                          Write(Model.Department.Advantage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <ul class=\"department-info\">\r\n");
#nullable restore
#line 92 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\DepartmentDetail\Index.cshtml"
                                                 foreach (var item in Model.Department.Text.Split(","))
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <li><i class=\"fas fa-angle-right\"></i> ");
#nullable restore
#line 94 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\DepartmentDetail\Index.cshtml"
                                                                                      Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 95 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\DepartmentDetail\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </ul>\r\n                                            <p>");
#nullable restore
#line 98 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\DepartmentDetail\Index.cshtml"
                                          Write(Model.Department.Advantage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-lg-12 col-md-12 col-sm-12"">
                                                <div class=""item-cost"">
                                                    <h3>Our Pricing Plan</h3>
                                                    <ul>
                                                        <li>Dental Implant<span>$45.00</span></li>
                                                        <li>Another Feature<span>$50.00</span></li>
                                                        <li>Another Major Feature<span>$55.00</span></li>
                                                        <li>Emergency Care<span>$25.00</span></li>
                                                        <li>Prescription Drugs<span>$30.00</span></li>
                                                        <li>Specialist Visits<span>$20.00</span></li");
            WriteLiteral(@">
                                                        <li>Rheumatology<span>$25.00</span></li>
                                                    </ul>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""item-specialist-department"">
                                            <h3>Meet Our Doctors</h3>
                                        </div>
                                        <div class=""row"">
");
#nullable restore
#line 120 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\DepartmentDetail\Index.cshtml"
                                             foreach (var item in Model.Department.Doctors)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <div class=""col-lg-6 col-md-6 col-sm-6"">
                                                    <div class=""item-specialist"">
                                                        <div class=""media"">
                                                            <div class=""item-img"">
                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1c71e4425645c2bc24ee26333493a42e7a668dcd20908", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7335, "~/uploads/", 7335, 10, true);
#nullable restore
#line 126 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\DepartmentDetail\Index.cshtml"
AddHtmlAttributeValue("", 7345, item.Photo, 7345, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                            </div>\r\n                                                            <div class=\"item-content\">\r\n                                                                <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c71e4425645c2bc24ee26333493a42e7a668dcd22730", async() => {
#nullable restore
#line 129 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\DepartmentDetail\Index.cshtml"
                                                                                                                                           Write(item.FullName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 129 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\DepartmentDetail\Index.cshtml"
                                                                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\r\n                                                                <span>BDS, FCPS (Hons), PhD (Japan)</span>\r\n                                                                <p>");
#nullable restore
#line 131 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\DepartmentDetail\Index.cshtml"
                                                              Write(item.Department.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c71e4425645c2bc24ee26333493a42e7a668dcd26067", async() => {
                WriteLiteral("Make an Appointment");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 132 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\DepartmentDetail\Index.cshtml"
                                                                                                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                            </div>\r\n                                                        </div>\r\n                                                    </div>\r\n                                                </div>\r\n");
#nullable restore
#line 137 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\DepartmentDetail\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Department Detail section end -->
</main>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DepartmentDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591