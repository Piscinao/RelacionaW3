#pragma checksum "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Relatorio\Grafico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45c90142d226eaa361ba6a19512e180905eba6eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Relatorio_Grafico), @"mvc.1.0.view", @"/Views/Relatorio/Grafico.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Relatorio/Grafico.cshtml", typeof(AspNetCore.Views_Relatorio_Grafico))]
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
#line 1 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\_ViewImports.cshtml"
using RelacionaW3.MVC;

#line default
#line hidden
#line 2 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\_ViewImports.cshtml"
using RelacionaW3.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45c90142d226eaa361ba6a19512e180905eba6eb", @"/Views/Relatorio/Grafico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ff5f67da75fc0b1fd5374a73795734c2ee7e112", @"/Views/_ViewImports.cshtml")]
    public class Views_Relatorio_Grafico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/chart.js/dist/Chart.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/charts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Relatorio\Grafico.cshtml"
  
    ViewData["Title"] = "Gráfico";

#line default
#line hidden
            BeginContext(40, 2500, true);
            WriteLiteral(@"
<h2>Relatórios - TESTE</h2>
<hr />

<div class=""card-columns cols-2"">
  <!-- <div class=""card"">
    <div class=""card-header"">
      Line Chart
      <div class=""card-header-actions"">
        <a href=""#"" class=""card-header-action"" target=""_blank"">
          <small class=""text-muted"">docs</small>
        </a>
      </div>
    </div>
    <div class=""card-body"">
      <div class=""chart-wrapper"">
        <canvas id=""canvas-1""></canvas>
      </div>
    </div>
  </div> -->
  
  <div class=""card"">
    <div class=""card-header"">
      Áreas com mais reclamações
      <div class=""card-header-actions"">
        <a href=""#"" class=""card-header-action"" target=""_blank"">
          <small class=""text-muted"">teste</small>
        </a>
      </div>
    </div>
    <div class=""card-body"">
      <div class=""chart-wrapper"">
        <canvas id=""canvas-3""></canvas>
      </div>
    </div>
  </div>
  <!-- <div class=""card"">
    <div class=""card-header"">
      Situação dos Eventos
      <div class=""card-header-actions"">
        <a href");
            WriteLiteral(@"=""#"" class=""card-header-action"" target=""_blank"">
          <small class=""text-muted"">teste</small>
        </a>
      </div>
    </div>
    <div class=""card-body"">
      <div class=""chart-wrapper"">
        <canvas id=""canvas-4""></canvas>
      </div>
    </div>
  </div> -->
  <div class=""card"">
    <div class=""card-header"">
      Eventos por área
      <div class=""card-header-actions"">
        <a href=""#"" class=""card-header-action"" target=""_blank"">
          <small class=""text-muted"">teste</small>
        </a>
      </div>
    </div>
    <div class=""card-body"">
      <div class=""chart-wrapper"">
        <canvas id=""canvas-5""></canvas>
      </div>
    </div>
  </div>
  <div class=""card"">
    <div class=""card-header"">
      Situação dos eventos
      <div class=""card-header-actions"">
        <a href=""#"" class=""card-header-action"" target=""_blank"">
          <small class=""text-muted"">teste</small>
        </a>
      </div>
    </div>
    <div class=""card-body"">
      <div class=""chart-wrapper"">
        <canvas id");
            WriteLiteral(@"=""canvas-6""></canvas>
      </div>
    </div>
  </div>

  <div class=""card"">
    <div class=""card-header"">
      Teste
      <div class=""card-header-actions"">
        <a href=""#"" class=""card-header-action"" target=""_blank"">
          <small class=""text-muted"">docs</small>
        </a>
      </div>
    </div>
    <div class=""card-body"">
      <div class=""chart-wrapper"">
        <canvas id=""canvas-2""></canvas>
      </div>
    </div>
  </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2558, 3, true);
                WriteLiteral("\n  ");
                EndContext();
                BeginContext(2561, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45c90142d226eaa361ba6a19512e180905eba6eb7193", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2617, 3, true);
                WriteLiteral("\n  ");
                EndContext();
                BeginContext(2620, 107, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45c90142d226eaa361ba6a19512e180905eba6eb8445", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginWriteTagHelperAttribute();
                WriteLiteral("~/lib/@");
                WriteLiteral("coreui/coreui-plugin-chartjs-custom-tooltips/dist/js/custom-tooltips.min.js");
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("src", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2727, 3, true);
                WriteLiteral("\n  ");
                EndContext();
                BeginContext(2730, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45c90142d226eaa361ba6a19512e180905eba6eb10082", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2768, 1, true);
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