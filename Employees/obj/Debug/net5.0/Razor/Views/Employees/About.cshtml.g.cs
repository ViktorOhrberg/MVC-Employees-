#pragma checksum "C:\Users\Viktor\source\repos\ASP.NET Core\MVC Employees\Employees\Views\Employees\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f08fe6e902e58c2f0b7198f220db856d8564499e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_About), @"mvc.1.0.view", @"/Views/Employees/About.cshtml")]
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
#line 2 "C:\Users\Viktor\source\repos\ASP.NET Core\MVC Employees\Employees\Views\_ViewImports.cshtml"
using Employees.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Viktor\source\repos\ASP.NET Core\MVC Employees\Employees\Views\_ViewImports.cshtml"
using Employees.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Viktor\source\repos\ASP.NET Core\MVC Employees\Employees\Views\_ViewImports.cshtml"
using Employees.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f08fe6e902e58c2f0b7198f220db856d8564499e", @"/Views/Employees/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4adc119c7cc23adfe2466199be92d536dcab559d", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutVM>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Viktor\source\repos\ASP.NET Core\MVC Employees\Employees\Views\Employees\About.cshtml"
   ViewBag.Title = "About";
    ViewBag.Header = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f08fe6e902e58c2f0b7198f220db856d8564499e3776", async() => {
                WriteLiteral("\r\n    <title></title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f08fe6e902e58c2f0b7198f220db856d8564499e4765", async() => {
                WriteLiteral("\r\n    <h1>");
#nullable restore
#line 11 "C:\Users\Viktor\source\repos\ASP.NET Core\MVC Employees\Employees\Views\Employees\About.cshtml"
   Write(Model.Header);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n    <p>");
#nullable restore
#line 12 "C:\Users\Viktor\source\repos\ASP.NET Core\MVC Employees\Employees\Views\Employees\About.cshtml"
  Write(Model.Body);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <ul>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\Viktor\source\repos\ASP.NET Core\MVC Employees\Employees\Views\Employees\About.cshtml"
         foreach (var item in Model.ListEmp)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li>\r\n                ");
#nullable restore
#line 18 "C:\Users\Viktor\source\repos\ASP.NET Core\MVC Employees\Employees\Views\Employees\About.cshtml"
           Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 20 "C:\Users\Viktor\source\repos\ASP.NET Core\MVC Employees\Employees\Views\Employees\About.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
