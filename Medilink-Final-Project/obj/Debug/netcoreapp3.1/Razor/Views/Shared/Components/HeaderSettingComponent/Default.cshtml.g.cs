#pragma checksum "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\Shared\Components\HeaderSettingComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2652a5bc75ed78165f395ea690febac133c28966"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HeaderSettingComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HeaderSettingComponent/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2652a5bc75ed78165f395ea690febac133c28966", @"/Views/Shared/Components/HeaderSettingComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3633da3bd55105d4a80d2094ce2e9712a69adbfb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_HeaderSettingComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Setting>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success ml-5 text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\Shared\Components\HeaderSettingComponent\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-md-9 col-lg-10\">\r\n    <div class=\"rt-tophead-contact\">\r\n        <ul>\r\n            <li class=\"phone-has-address-off\">\r\n                <i class=\"fas fa-map-marker-alt\"></i>\r\n                <span>");
#nullable restore
#line 11 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\Shared\Components\HeaderSettingComponent\Default.cshtml"
                 Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </li>\r\n            <li class=\"phone-has-mobile-off\">\r\n                <i class=\"fas fa-phone\"></i>\r\n                any question:\r\n                <a href=\"#\">");
#nullable restore
#line 16 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\Shared\Components\HeaderSettingComponent\Default.cshtml"
                       Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n            <li class=\"phone-has-email-off ml-5\">\r\n                <i class=\"fa fa-envelope-o\"></i>\r\n                <a href=\"#\">");
#nullable restore
#line 20 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\Shared\Components\HeaderSettingComponent\Default.cshtml"
                       Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n            \r\n            <li>\r\n");
#nullable restore
#line 24 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\Shared\Components\HeaderSettingComponent\Default.cshtml"
                 if (User.Identity.IsAuthenticated)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\Shared\Components\HeaderSettingComponent\Default.cshtml"
               Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2652a5bc75ed78165f395ea690febac133c289666899", async() => {
                WriteLiteral("&nbsp;&nbsp;Logout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            WriteLiteral("\r\n");
#nullable restore
#line 28 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\Shared\Components\HeaderSettingComponent\Default.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"d-none\">&nbsp;&nbsp;Logout</a>\r\n");
#nullable restore
#line 32 "C:\Users\Kamil\Desktop\Medilink-Final-Project\Medilink-Final-Project\Views\Shared\Components\HeaderSettingComponent\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </li>\r\n          </ul>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Setting> Html { get; private set; }
    }
}
#pragma warning restore 1591
