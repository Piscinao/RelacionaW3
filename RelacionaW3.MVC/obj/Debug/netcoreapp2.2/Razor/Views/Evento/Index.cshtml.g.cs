#pragma checksum "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\Evento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c9d61af9a6ada4832f151dd6b4f7b3ae71f70d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Evento_Index), @"mvc.1.0.view", @"/Views/Evento/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Evento/Index.cshtml", typeof(AspNetCore.Views_Evento_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c9d61af9a6ada4832f151dd6b4f7b3ae71f70d4", @"/Views/Evento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0facd34bc3cfd1b3365fe779b5d7a02b18dfebbe", @"/Views/_ViewImports.cshtml")]
    public class Views_Evento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RelacionaW3.MVC.Models.EventoViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\Evento\Index.cshtml"
  
    ViewData["Title"] = "Eventos";

#line default
#line hidden
            BeginContext(40, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(94, 1055, true);
            WriteLiteral(@"
<div class=""row"">
  <div class=""col-lg-12"">
    <div class=""card"">
      <div class=""card-header"">
        <i class=""fa fa-align-justify""></i> 
        <div class=""card-header-actions"">
          
        </div>
      </div>
      <div class=""card-body"">
  
<h2>Eventos</h2>
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
            <th>Descrição</th>
            <th>Área</th>
            <th>Meio de Contato</th>
            <th>Classificação</th>
            <!-- <th>Característica</th> -->
            <th>Pessoa</th>
            <th>Status</th>
            <th>Opções</th>
            
        <");
            WriteLiteral("/tr>\n    </thead>\n    <tbody>\n\n");
            EndContext();
#line 44 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\Evento\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1196, 15, true);
            WriteLiteral("            <tr");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1211, "\"", 1237, 3);
            WriteAttributeValue("", 1221, "Editar(", 1221, 7, true);
#line 46 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\Evento\Index.cshtml"
WriteAttributeValue("", 1228, item.Id, 1228, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1236, ")", 1236, 1, true);
            EndWriteAttribute();
            BeginContext(1238, 46, true);
            WriteLiteral(" style=\"cursor:pointer;\">\n                <td>");
            EndContext();
            BeginContext(1285, 7, false);
#line 47 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\Evento\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1292, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(1319, 14, false);
#line 48 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\Evento\Index.cshtml"
               Write(item.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(1333, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(1360, 18, false);
#line 49 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\Evento\Index.cshtml"
               Write(item.DescricaoArea);

#line default
#line hidden
            EndContext();
            BeginContext(1378, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(1405, 9, false);
#line 50 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\Evento\Index.cshtml"
               Write(item.Meio);

#line default
#line hidden
            EndContext();
            BeginContext(1414, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(1441, 18, false);
#line 51 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\Evento\Index.cshtml"
               Write(item.Classificacao);

#line default
#line hidden
            EndContext();
            BeginContext(1459, 31, true);
            WriteLiteral("</td>\n                <!-- <td>");
            EndContext();
            BeginContext(1491, 19, false);
#line 52 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\Evento\Index.cshtml"
                    Write(item.Caracteristica);

#line default
#line hidden
            EndContext();
            BeginContext(1510, 30, true);
            WriteLiteral("</td> -->\n                <td>");
            EndContext();
            BeginContext(1541, 15, false);
#line 53 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\Evento\Index.cshtml"
               Write(item.NomePessoa);

#line default
#line hidden
            EndContext();
            BeginContext(1556, 95, true);
            WriteLiteral("</td>\n                 \n                <td style=\"vertical-align: middle;text-align: center\">\n");
            EndContext();
#line 56 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\Evento\Index.cshtml"
                         if (item.Status == "Pendente")
                        {

#line default
#line hidden
            BeginContext(1733, 90, true);
            WriteLiteral("                            <span class=\"badge badge-success float-right\">Pendente</span>\n");
            EndContext();
#line 59 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\Evento\Index.cshtml"
                        }
                        else if (item.Status == "Em análise")
                        {

#line default
#line hidden
            BeginContext(1937, 77, true);
            WriteLiteral("                            <span class=\"label label-info\">Em análise</span>\n");
            EndContext();
#line 63 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\Evento\Index.cshtml"
                        }
                        else if (item.Status == "Aguardando")
                        {

#line default
#line hidden
            BeginContext(2128, 80, true);
            WriteLiteral("                            <span class=\"label label-warning\">Aguardando</span>\n");
            EndContext();
#line 67 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\Evento\Index.cshtml"
                        }
                        else if (item.Status == "Concluído")
                        {

#line default
#line hidden
            BeginContext(2321, 79, true);
            WriteLiteral("                            <span class=\"label label-success\">Concluído</span>\n");
            EndContext();
#line 71 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\Evento\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2426, 754, true);
            WriteLiteral(@"                    </td>
               
            
                <td>
              <div class=""btn-group"">
                <button class=""btn btn-sm btn-success"" 
                data-toggle=""tooltip"" data-placement=""top"" title=""Editar"" >
                <i class=""fa fa-edit""></i>
              </button>    
              <button class=""btn btn-sm btn-danger""
              data-toggle=""tooltip"" data-placement=""top"" title=""Excluir"" >
              <i class=""fa fa-eraser""></i>   
            </button> 
          </div>
        
        
          <a [routerLink]= ""['/evento', evento.id, 'edit']"" tooltip=""Edição Detalhada"" class=""btn btn-sm btn-warning"">
            <i class=""fa fa-edit""></i>
          </a>

        </td>
            </tr>
");
            EndContext();
#line 94 "C:\Projetos\RelacionaW3-BETA-RAZOR\relacionaw3.mvc\Views\Evento\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3190, 70, true);
            WriteLiteral("    </tbody>\n</table>\n<br />\n      </div>\n    </div>\n  </div>\n</div>\n\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3278, 3386, true);
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
                            ""sSearch"": ""Procur");
                WriteLiteral(@"ar"",
                            ""oPaginate"": {
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
                        //                   ");
                WriteLiteral(@"     $(this).val()
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
        window.location = window.origin + ""\\Evento\\C");
                WriteLiteral(@"reate\\"" + Id;
    }
    function Create() {
        window.location = window.origin + ""\\Evento\\Create\\"";
    }
    function Excluir(Id) {
         window.location = window.origin + ""\\Evento\\Excluir\\"" + Id;
    }
    function Return() {
        window.location = window.origin + ""\\Home\\"";
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RelacionaW3.MVC.Models.EventoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591