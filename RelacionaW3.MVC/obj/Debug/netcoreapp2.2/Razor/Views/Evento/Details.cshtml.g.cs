#pragma checksum "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Evento\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcf94e3a4ca96823aaceb79e435877df019e5ae7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Evento_Details), @"mvc.1.0.view", @"/Views/Evento/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Evento/Details.cshtml", typeof(AspNetCore.Views_Evento_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcf94e3a4ca96823aaceb79e435877df019e5ae7", @"/Views/Evento/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ff5f67da75fc0b1fd5374a73795734c2ee7e112", @"/Views/_ViewImports.cshtml")]
    public class Views_Evento_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RelacionaW3.MVC.Models.EventoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Evento\Details.cshtml"
  
    ViewData["Title"] = "Detalhes do Evento ";

#line default
#line hidden
            BeginContext(104, 218, true);
            WriteLiteral("\r\n<div class=\"collection\">\r\n    <div class=\"collection-item\">\r\n\r\n\r\n    </div>\r\n    <div>\r\n    <h5>Dados do Evento</h5>\r\n    <hr />\r\n    \r\n    <div class=\"x_panel\">\r\n    <div class=\"x_title\">\r\n        <!-- <h2>Detalhes ");
            EndContext();
            BeginContext(323, 19, false);
#line 18 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Evento\Details.cshtml"
                     Write(Model.Id.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(342, 525, true);
            WriteLiteral(@": </h2> -->
        <h2>Detalhes: </h2>
        <div class=""clearfix""></div>
    </div>

        <button type=""reset"" class=""btn btn btn-info btn-3d"" onclick=""Return()""><i class=""fa fa-arrow-left""></i> Voltar</button>

<hr />
    <div class=""x_content"">
       
        <table class=""table-bordered table-striped table-condensed"" style=""width: 100%"">
            <tr>
                <th style=""width: 15%; background-color: lightgrey"">Descrição:</th>
                <th style=""font-weight: normal; width: 35%"">");
            EndContext();
            BeginContext(868, 42, false);
#line 31 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Evento\Details.cshtml"
                                                       Write(Html.DisplayFor(model => @Model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(910, 148, true);
            WriteLiteral("</th>\r\n               <th style=\"width: 15%; background-color: lightgrey\">Pessoa:</th>\r\n                <th style=\"font-weight: normal; width: 35%\">");
            EndContext();
            BeginContext(1059, 43, false);
#line 33 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Evento\Details.cshtml"
                                                       Write(Html.DisplayFor(model => @Model.NomePessoa));

#line default
#line hidden
            EndContext();
            BeginContext(1102, 330, true);
            WriteLiteral(@"</th>
                
            </tr>
        </table>

        <table class=""table-bordered table-striped table-condensed"" style=""width: 100%"">
            <tr>
                
                <th style=""width: 15%; background-color: lightgrey"">Meio:</th>
                <th style=""font-weight: normal; width: 35%"">");
            EndContext();
            BeginContext(1433, 37, false);
#line 42 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Evento\Details.cshtml"
                                                       Write(Html.DisplayFor(model => @Model.Meio));

#line default
#line hidden
            EndContext();
            BeginContext(1470, 166, true);
            WriteLiteral("</th>\r\n                \r\n                <th style=\"width: 15%; background-color: lightgrey\">Fonte:</th>\r\n                <th style=\"font-weight: normal; width: 35%\">");
            EndContext();
            BeginContext(1637, 38, false);
#line 45 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Evento\Details.cshtml"
                                                       Write(Html.DisplayFor(model => @Model.Fonte));

#line default
#line hidden
            EndContext();
            BeginContext(1675, 297, true);
            WriteLiteral(@"</th>
            </tr>
        </table>

        <table class=""table-bordered table-striped table-condensed"" style=""width: 100%"">
            <tr>
                <th style=""width: 15%; background-color: lightgrey"">Produto:</th>
                <th style=""font-weight: normal; width: 35%"">");
            EndContext();
            BeginContext(1973, 40, false);
#line 52 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Evento\Details.cshtml"
                                                       Write(Html.DisplayFor(model => @Model.Produto));

#line default
#line hidden
            EndContext();
            BeginContext(2013, 153, true);
            WriteLiteral("</th>\r\n                <th style=\"width: 15%; background-color: lightgrey\">NotaFiscal:</th>\r\n                <th style=\"font-weight: normal; width: 35%\">");
            EndContext();
            BeginContext(2167, 43, false);
#line 54 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Evento\Details.cshtml"
                                                       Write(Html.DisplayFor(model => @Model.NotaFiscal));

#line default
#line hidden
            EndContext();
            BeginContext(2210, 308, true);
            WriteLiteral(@"</th>
            </tr>
        </table>

        <table class=""table-bordered table-striped table-condensed"" style=""width: 100%"">
            <tr>
                <th style=""width: 15%; background-color: lightgrey"">Descrição Material:</th>
                <th style=""font-weight: normal; width: 35%"">");
            EndContext();
            BeginContext(2519, 50, false);
#line 61 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Evento\Details.cshtml"
                                                       Write(Html.DisplayFor(model => @Model.DescricaoMaterial));

#line default
#line hidden
            EndContext();
            BeginContext(2569, 153, true);
            WriteLiteral("</th>\r\n                <th style=\"width: 15%; background-color: lightgrey\">Evidencias:</th>\r\n                <th style=\"font-weight: normal; width: 35%\">");
            EndContext();
            BeginContext(2723, 43, false);
#line 63 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Evento\Details.cshtml"
                                                       Write(Html.DisplayFor(model => @Model.Evidencias));

#line default
#line hidden
            EndContext();
            BeginContext(2766, 303, true);
            WriteLiteral(@"</th>
            </tr>
        </table>
         <table class=""table-bordered table-striped table-condensed"" style=""width: 100%"">
            <tr>
                <th style=""width: 15%; background-color: lightgrey"">Característica:</th>
                <th style=""font-weight: normal; width: 35%"">");
            EndContext();
            BeginContext(3070, 47, false);
#line 69 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Evento\Details.cshtml"
                                                       Write(Html.DisplayFor(model => @Model.Caracteristica));

#line default
#line hidden
            EndContext();
            BeginContext(3117, 157, true);
            WriteLiteral("</th>\r\n                <th style=\"width: 15%; background-color: lightgrey\">Data do Evento:</th>\r\n                <th style=\"font-weight: normal; width: 35%\">");
            EndContext();
            BeginContext(3275, 43, false);
#line 71 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Evento\Details.cshtml"
                                                       Write(Html.DisplayFor(model => @Model.DataEvento));

#line default
#line hidden
            EndContext();
            BeginContext(3318, 295, true);
            WriteLiteral(@"</th>
            </tr>
        </table> 

        <table class=""table-bordered table-striped table-condensed"" style=""width: 100%"">
            <tr>
                <th style=""width: 15%; background-color: lightgrey"">Área:</th>
                <th style=""font-weight: normal; width: 35%"">");
            EndContext();
            BeginContext(3614, 46, false);
#line 78 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Evento\Details.cshtml"
                                                       Write(Html.DisplayFor(model => @Model.DescricaoArea));

#line default
#line hidden
            EndContext();
            BeginContext(3660, 204, true);
            WriteLiteral("</th>\r\n                \r\n            </tr>\r\n        </table> \r\n   \r\n    </div>\r\n</div>\r\n\r\n<script>\r\n    function Return() {\r\n        window.location = window.origin + \"\\\\Evento\\\\\";\r\n    }\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RelacionaW3.MVC.Models.EventoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
