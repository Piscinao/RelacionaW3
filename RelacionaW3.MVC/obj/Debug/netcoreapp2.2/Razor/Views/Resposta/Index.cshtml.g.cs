#pragma checksum "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\Resposta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16541fa151930918063f17d6bf280f03f813c855"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Resposta_Index), @"mvc.1.0.view", @"/Views/Resposta/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Resposta/Index.cshtml", typeof(AspNetCore.Views_Resposta_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16541fa151930918063f17d6bf280f03f813c855", @"/Views/Resposta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0facd34bc3cfd1b3365fe779b5d7a02b18dfebbe", @"/Views/_ViewImports.cshtml")]
    public class Views_Resposta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RelacionaW3.MVC.Models.RespostaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\Resposta\Index.cshtml"
  
    ViewData["Title"] = "Respostas";

#line default
#line hidden
            BeginContext(42, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(98, 838, true);
            WriteLiteral(@"<div class=""row"">
  <div class=""col-lg-12"">
    <div class=""card"">
      <div class=""card-header"">
        <i class=""fa fa-align-justify""></i> 
        <div class=""card-header-actions"">
          
        </div>
      </div>
      <div class=""card-body"">

<h2>Respostas</h2>
 <button type=""submit"" class=""btn btn btn-primary btn-3d"" 
                onclick=""Create()"">
          <i class=""fa fa-plus""></i> Registrar
        </button>
        <button type=""reset"" class=""btn btn btn-info btn-3d"" onclick=""Return()""><i class=""fa fa-arrow-left""></i> Voltar</button>

<hr />

<table id=""dataTable"" class=""table table-striped table-bordered"" style=""width:100%"">
    <thead>
        <tr style=""background-color:#f6f6f6"">
            <th>Código</th>
            <th>Data</th>
            <th>Pessoa</th>

        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 36 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\Resposta\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(983, 11, true);
            WriteLiteral("        <tr");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 994, "\"", 1020, 3);
            WriteAttributeValue("", 1004, "Editar(", 1004, 7, true);
#line 38 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\Resposta\Index.cshtml"
WriteAttributeValue("", 1011, item.Id, 1011, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1019, ")", 1019, 1, true);
            EndWriteAttribute();
            BeginContext(1021, 42, true);
            WriteLiteral(" style=\"cursor:pointer;\">\n            <td>");
            EndContext();
            BeginContext(1064, 7, false);
#line 39 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\Resposta\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1071, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(1094, 37, false);
#line 40 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\Resposta\Index.cshtml"
           Write(item.Data.ToString().Substring(0, 10));

#line default
#line hidden
            EndContext();
            BeginContext(1131, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(1154, 13, false);
#line 41 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\Resposta\Index.cshtml"
           Write(item.IdPessoa);

#line default
#line hidden
            EndContext();
            BeginContext(1167, 21, true);
            WriteLiteral("</td>\n\n        </tr>\n");
            EndContext();
#line 44 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\Resposta\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1198, 406, true);
            WriteLiteral(@"    </tbody>
</table>
<br />

 </div>
    </div>
  </div>
</div>

<!-- 
<div class=""card-footer"">
        <button type=""submit"" class=""btn btn btn-primary btn-3d"" 
                onclick=""Create()"">
          <i class=""fa fa-plus""></i> Registrar
        </button>
        <button type=""reset"" class=""btn btn btn-info btn-3d"" onclick=""Return()""><i class=""fa fa-arrow-left""></i> Voltar</button>
</div> -->

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1622, 3284, true);
                WriteLiteral(@"
    <script>
        $(document)
            .ready(function () {

                $('#dataTable')
                    .DataTable({
                        ""order"": [],
                        ""responsive"": true,
                        ""columnDefs"": [
                            {
                                ""targets"": 'no-sort',
                                ""orderable"": false
                            }
                        ],
                        ""oLanguage"": {
                            ""sProcessing"": ""Aguarde enquanto os dados são carregados ..."",
                            ""sLengthMenu"": ""Mostrar _MENU_ registros por página"",
                            ""sZeroRecords"": ""Nenhum registro correspondente ao critério encontrado"",
                            ""sInfoEmpty"": ""Exibindo 0 a 0 de 0 registros"",
                            ""sInfo"": ""Exibindo de _START_ a _END_ de _TOTAL_ registros"",
                            ""sInfoFiltered"": """",
                            ""sSearch"": ""Procurar"",
 ");
                WriteLiteral(@"                           ""oPaginate"": {
                                ""sFirst"": ""Primeiro"",
                                ""sPrevious"": ""Anterior"",
                                ""sNext"": ""Próximo"",
                                ""sLast"": ""Último""
                            }
                        },
                        ""stateSave"": true,
                        ""orderCellsTop"": true,
                        //initComplete: function () {
                        //    this.api().columns([0]).every(function () {
                        //        var column = this;
                        //        var select = $('<select class=""form-control""><option value=""""></option></select>')
                        //            .appendTo($(column.footer()).empty())
                        //            .on('change',
                        //                function () {
                        //                    var val = $.fn.dataTable.util.escapeRegex(
                        //                        $");
                WriteLiteral(@"(this).val()
                        //                    );

                        //                    column
                        //                        .search(val ? '^' + val + '$' : '', true, false)
                        //                        .draw();
                        //                });

                        //        column.data().unique().sort().each(function (d, j) {
                        //            if (d.length > 40) {
                        //                d = $(d).text();
                        //            }
                        //            select.append('<option value=""' + d + '"">' + d + '</option>');
                        //        });
                        //    });
                        //    $('#tableDataFiltro tfoot tr').insertAfter($('#tableDataFiltro thead tr'));
                        //}
                    });
            });

  </script>


    <script>
    function Editar(Id) {
        window.location = window.origin + ""\\Resposta\\Cr");
                WriteLiteral("eate\\\\\" + Id;\n    }\n\n    function Create() {\n        window.location = window.origin + \"\\\\Resposta\\\\Create\";\n    }\n\n     function Return() {\n        window.location = window.origin + \"\\\\Home\\\\\";\n    }\n</script>\n\n");
                EndContext();
            }
            );
            BeginContext(4908, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RelacionaW3.MVC.Models.RespostaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
