#pragma checksum "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\CoreUI\_CoreUILayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0de00b74c90141ab57299a0995d07d599d10f87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CoreUI__CoreUILayout), @"mvc.1.0.view", @"/Views/CoreUI/_CoreUILayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CoreUI/_CoreUILayout.cshtml", typeof(AspNetCore.Views_CoreUI__CoreUILayout))]
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
#line 1 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\_ViewImports.cshtml"
using RelacionaW3.MVC;

#line default
#line hidden
#line 2 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\_ViewImports.cshtml"
using RelacionaW3.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0de00b74c90141ab57299a0995d07d599d10f87", @"/Views/CoreUI/_CoreUILayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0facd34bc3cfd1b3365fe779b5d7a02b18dfebbe", @"/Views/_ViewImports.cshtml")]
    public class Views_CoreUI__CoreUILayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_breadcrumb-items", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_breadcrumb-menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\CoreUI\_CoreUILayout.cshtml"
   Layout = "_Layout"; 

#line default
#line hidden
            BeginContext(25, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(61, 3, true);
                WriteLiteral("\n  ");
                EndContext();
                BeginContext(65, 40, false);
#line 5 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\CoreUI\_CoreUILayout.cshtml"
Write(RenderSection("Styles", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(105, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(108, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Breadcrumbs", async() => {
                BeginContext(152, 62, true);
                WriteLiteral("\n  <ol class=\"breadcrumb\">\n\n    <!-- BREADCRUMB-ITEMS -->\n    ");
                EndContext();
                BeginContext(214, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d0de00b74c90141ab57299a0995d07d599d10f874907", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(250, 66, true);
                WriteLiteral("\n    <!-- /BREADCRUMB-ITEMS -->\n\n    <!-- BREADCRUMB-MENU -->\n    ");
                EndContext();
                BeginContext(316, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d0de00b74c90141ab57299a0995d07d599d10f876304", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(351, 40, true);
                WriteLiteral("\n    <!-- /BREADCRUMB-MENU -->\n\n  </ol>\n");
                EndContext();
            }
            );
            BeginContext(393, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(395, 12, false);
#line 23 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\CoreUI\_CoreUILayout.cshtml"
Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(407, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            DefineSection("Modals", async() => {
                BeginContext(444, 3, true);
                WriteLiteral("\n  ");
                EndContext();
                BeginContext(448, 40, false);
#line 27 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\CoreUI\_CoreUILayout.cshtml"
Write(RenderSection("Modals", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(488, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(491, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(529, 3, true);
                WriteLiteral("\n  ");
                EndContext();
                BeginContext(533, 41, false);
#line 32 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\CoreUI\_CoreUILayout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(574, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
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
