#pragma checksum "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\CoreUI\base-progress.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b99c704b3f9bde468b962711b1ddd358c2d9a511"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CoreUI_base_progress), @"mvc.1.0.view", @"/Views/CoreUI/base-progress.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CoreUI/base-progress.cshtml", typeof(AspNetCore.Views_CoreUI_base_progress))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b99c704b3f9bde468b962711b1ddd358c2d9a511", @"/Views/CoreUI/base-progress.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ff5f67da75fc0b1fd5374a73795734c2ee7e112", @"/Views/_ViewImports.cshtml")]
    public class Views_CoreUI_base_progress : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 5283, true);
            WriteLiteral(@"<div class=""card"">
  <div class=""card-header"">
    Progress
    <div class=""card-header-actions"">
      <a href=""http://coreui.io/docs/components/bootstrap-popover/popovers.html"" class=""card-header-action"" target=""_blank"">
        <small class=""text-muted"">docs</small>
      </a>
    </div>
  </div>
  <div class=""card-body"">
    <div class=""progress mb-3"">
      <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""0"" aria-valuemin=""0"" aria-valuemax=""100""></div>
    </div>
    <div class=""progress mb-3"">
      <div class=""progress-bar"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
    </div>
    <div class=""progress mb-3"">
      <div class=""progress-bar"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100""></div>
    </div>
    <div class=""progress mb-3"">
      <div class=""progress-bar"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
    </div>
    <div ");
            WriteLiteral(@"class=""progress mb-3"">
      <div class=""progress-bar"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100""></div>
    </div>
  </div>
</div>
<div class=""card"">
  <div class=""card-header"">
    Progress
    <small>labels</small>
  </div>
  <div class=""card-body"">
    <div class=""progress mb-3"">
      <div class=""progress-bar"" role=""progressbar"" style=""width: 25%;"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100"">
        25%
      </div>
    </div>
    <div class=""progress"">
      <div class=""progress-bar"" role=""progressbar"" style=""width: 75%;"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100"">
        75%
      </div>
    </div>
  </div>
</div>
<div class=""card"">
  <div class=""card-header"">
    Progress
    <small>height</small>
  </div>
  <div class=""card-body"">
    <div class=""progress mb-3"" style=""height: 3px;"">
      <div class=""progress-bar"" role=""progressbar"" style=""width: 25%;"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
   ");
            WriteLiteral(@" </div>
    <div class=""progress"" style=""height: 30px;"">
      <div class=""progress-bar"" role=""progressbar"" style=""width: 25%;"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
    </div>
  </div>
</div>
<div class=""card"">
  <div class=""card-header"">
    Progress
    <small>backgrounds</small>
  </div>
  <div class=""card-body"">
    <div class=""progress mb-3"">
      <div class=""progress-bar bg-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
    </div>
    <div class=""progress mb-3"">
      <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100""></div>
    </div>
    <div class=""progress mb-3"">
      <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
    </div>
    <div class=""progress"">
      <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 100%"" aria-value");
            WriteLiteral(@"now=""100"" aria-valuemin=""0"" aria-valuemax=""100""></div>
    </div>
  </div>
</div>
<div class=""card"">
  <div class=""card-header"">
    Progress
    <small>multiple bars</small>
  </div>
  <div class=""card-body"">
    <div class=""progress"">
      <div class=""progress-bar"" role=""progressbar"" style=""width: 15%"" aria-valuenow=""15"" aria-valuemin=""0"" aria-valuemax=""100""></div>
      <div class=""progress-bar bg-success"" role=""progressbar"" style=""width: 30%"" aria-valuenow=""30"" aria-valuemin=""0"" aria-valuemax=""100""></div>
      <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 20%"" aria-valuenow=""20"" aria-valuemin=""0"" aria-valuemax=""100""></div>
    </div>
  </div>
</div>
<div class=""card"">
  <div class=""card-header"">
    Progress
    <small>striped</small>
  </div>
  <div class=""card-body"">
    <div class=""progress mb-3"">
      <div class=""progress-bar progress-bar-striped"" role=""progressbar"" style=""width: 10%"" aria-valuenow=""10"" aria-valuemin=""0"" aria-valuemax=""100""></div>
    </div>
    <div class=""p");
            WriteLiteral(@"rogress mb-3"">
      <div class=""progress-bar progress-bar-striped bg-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
    </div>
    <div class=""progress mb-3"">
      <div class=""progress-bar progress-bar-striped bg-info"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100""></div>
    </div>
    <div class=""progress mb-3"">
      <div class=""progress-bar progress-bar-striped bg-warning"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
    </div>
    <div class=""progress mb-3"">
      <div class=""progress-bar progress-bar-striped bg-danger"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100""></div>
    </div>
  </div>
</div>
<div class=""card"">
  <div class=""card-header"">
    Progress
    <small>animated</small>
  </div>
  <div class=""card-body"">
    <div class=""progress"">
      <div class=""progress-bar progress-b");
            WriteLiteral("ar-striped progress-bar-animated\" role=\"progressbar\" aria-valuenow=\"75\" aria-valuemin=\"0\" aria-valuemax=\"100\" style=\"width: 75%\"></div>\n    </div>\n  </div>\n</div>\n");
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