#pragma checksum "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Pessoa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b69d4458f1445027051b3bb0258a3be383a9bdeb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoa_Index), @"mvc.1.0.view", @"/Views/Pessoa/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pessoa/Index.cshtml", typeof(AspNetCore.Views_Pessoa_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b69d4458f1445027051b3bb0258a3be383a9bdeb", @"/Views/Pessoa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ff5f67da75fc0b1fd5374a73795734c2ee7e112", @"/Views/_ViewImports.cshtml")]
    public class Views_Pessoa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RelacionaW3.MVC.Models.PessoaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Pessoa\Index.cshtml"
  
    ViewData["Title"] = "Pessoas";

#line default
#line hidden
            BeginContext(40, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(94, 958, true);
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

<h2>Pessoas</h2>
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
            <th>Nome</th>
            <th>Classificação</th>
            <th>Empresa</th>
            <th>E-mail</th>
            <th>Celular</th>
            <th>Opções</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 41 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Pessoa\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1099, 54, true);
            WriteLiteral("        <tr  style=\"cursor:pointer;\">\n            <td>");
            EndContext();
            BeginContext(1154, 7, false);
#line 44 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Pessoa\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1161, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(1184, 9, false);
#line 45 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Pessoa\Index.cshtml"
           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1193, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(1216, 18, false);
#line 46 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Pessoa\Index.cshtml"
           Write(item.Classificacao);

#line default
#line hidden
            EndContext();
            BeginContext(1234, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(1257, 12, false);
#line 47 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Pessoa\Index.cshtml"
           Write(item.Empresa);

#line default
#line hidden
            EndContext();
            BeginContext(1269, 25, true);
            WriteLiteral("</td>   \n            <td>");
            EndContext();
            BeginContext(1295, 10, false);
#line 48 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Pessoa\Index.cshtml"
           Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1305, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(1328, 12, false);
#line 49 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Pessoa\Index.cshtml"
           Write(item.Celular);

#line default
#line hidden
            EndContext();
            BeginContext(1340, 85, true);
            WriteLiteral("</td>\n             <td>\n              <div class=\"btn-group\">\n                <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1425, "\"", 1451, 3);
            WriteAttributeValue("", 1435, "Editar(", 1435, 7, true);
#line 52 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Pessoa\Index.cshtml"
WriteAttributeValue("", 1442, item.Id, 1442, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1450, ")", 1450, 1, true);
            EndWriteAttribute();
            BeginContext(1452, 198, true);
            WriteLiteral(" class=\"btn btn-sm btn-success\" \n                data-toggle=\"tooltip\" data-placement=\"top\" title=\"Editar\" >\n                <i class=\"fa fa-edit\"></i>\n              </button> \n              <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1650, "\"", 1677, 3);
            WriteAttributeValue("", 1660, "Details(", 1660, 8, true);
#line 56 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Pessoa\Index.cshtml"
WriteAttributeValue("", 1668, item.Id, 1668, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1676, ")", 1676, 1, true);
            EndWriteAttribute();
            BeginContext(1678, 196, true);
            WriteLiteral(" class=\"btn btn-sm btn-info\"\n              data-toggle=\"tooltip\" data-placement=\"top\" title=\"Detalhes\" >\n              <i class=\"fa fa-book\"></i>   \n            </button>    \n              <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1874, "\"", 1919, 6);
            WriteAttributeValue("", 1884, "ExibirModal(", 1884, 12, true);
#line 60 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Pessoa\Index.cshtml"
WriteAttributeValue("", 1896, item.Id, 1896, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1904, ",", 1904, 1, true);
            WriteAttributeValue(" ", 1905, "\'", 1906, 2, true);
#line 60 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Pessoa\Index.cshtml"
WriteAttributeValue("", 1907, item.Nome, 1907, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1917, "\')", 1917, 2, true);
            EndWriteAttribute();
            BeginContext(1920, 434, true);
            WriteLiteral(@" class=""btn btn-sm btn-danger""
              data-toggle=""tooltip"" data-placement=""top"" title=""Excluir"" >
              <i class=""fa fa-eraser""></i>   
            </button> 
            
          </div>
        
        
          <!-- <a [routerLink]= ""['/evento', evento.id, 'edit']"" tooltip=""Edição Detalhada"" class=""btn btn-sm btn-warning"">
            <i class=""fa fa-edit""></i>
          </a> -->

        </td>
        </tr>
");
            EndContext();
#line 74 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Pessoa\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2364, 866, true);
            WriteLiteral(@"    </tbody>
</table>
<br />


      
      </div>
    </div>
  </div>
</div>


<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        ...
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
        <button type=""button"" class=""btn btn-primary btnConfirmar"">Save changes</button>
      </div>
    </div>
  </div>
</div>


");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3248, 4842, true);
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
                            ""sSearch"": ""Procurar"",");
                WriteLiteral(@"
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
                        //                       ");
                WriteLiteral(@" $(this).val()
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
    function ExibirModal(id) {
    Swal.fire({
         title: 'Você tem certeza?',");
                WriteLiteral(@"
         text: ""Esta ação não poderá ser desfeita!"",
         icon: 'warning',
         showCancelButton: true,
         confirmButtonColor: '#3085d6',
         cancelButtonColor: '#d33',
         confirmButtonText: 'Sim, excluir!',
         cancelButtonText: 'Cancelar'
    }).then((result) => {
       if (result.value) {
         Swal.fire(
               'Excluído!',
               'O item foi excluído com sucesso.',
               'success'
               )
         $.ajax({
            method: ""GET"",
            url: ""/Pessoa/Excluir"",
            data: { id: id },
            success: function () {
            //location.reload();
           dataTable.reload();
                    }
        });
    
  }
})}
 </script>



<script>
    function Editar(Id) {
        window.location = window.origin + ""\\Pessoa\\Create\\"" + Id;
    }

    function Create() {
        window.location = window.origin + ""\\Pessoa\\Create"";
    }

    function Details(Id) {
        window.location = window.origin + ""\\Pessoa\\Det");
                WriteLiteral(@"ails\\"" + Id;
    }

    function Excluir(Id) {
         window.location = window.origin + ""\\Pessoa\\Excluir\\"" + Id;
    }

    function Return() {
        window.location = window.origin + ""\\Home\\"";
    }
    
</script>


<!-- <script>
        
        function ExibirModal(id, nome) {
            $("".nome"").html(nome);

            $(""#exampleModal"").modal(""show"");

            $("".btnConfirmar"").on('click', function () {
                $.ajax({
                    method: ""GET"",
                    url: ""/Pessoa/Excluir"",
                    data: { id: id },
                    success: function () {
                        location.reload();
                    }
                });
            });
        }
    </script> -->

");
                EndContext();
            }
            );
            BeginContext(8092, 1, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RelacionaW3.MVC.Models.PessoaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
