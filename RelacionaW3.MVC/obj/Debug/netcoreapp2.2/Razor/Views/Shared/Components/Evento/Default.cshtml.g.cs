#pragma checksum "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Shared\Components\Evento\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2250af77a458ef4e59d238d85b8146d90849281a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Evento_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Evento/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Evento/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Evento_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2250af77a458ef4e59d238d85b8146d90849281a", @"/Views/Shared/Components/Evento/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ff5f67da75fc0b1fd5374a73795734c2ee7e112", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Evento_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RelacionaW3.Dominio.Models.Evento>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 512, true);
            WriteLiteral(@"

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
            <!-- <th>Status</th> -->
            <th>Opções</th>
            
        </tr>
    </thead>
    <tbody>

");
            EndContext();
#line 21 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Shared\Components\Evento\Default.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
            BeginContext(618, 81, true);
            WriteLiteral("            <tr  style=\"cursor:pointer;\">\r\n                \r\n                <td>");
            EndContext();
            BeginContext(700, 7, false);
#line 26 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Shared\Components\Evento\Default.cshtml"
               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(707, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(735, 14, false);
#line 27 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Shared\Components\Evento\Default.cshtml"
               Write(item.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(749, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(777, 19, false);
#line 28 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Shared\Components\Evento\Default.cshtml"
               Write(item.Area.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(796, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(824, 9, false);
#line 29 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Shared\Components\Evento\Default.cshtml"
               Write(item.Meio);

#line default
#line hidden
            EndContext();
            BeginContext(833, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(861, 19, false);
#line 30 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Shared\Components\Evento\Default.cshtml"
               Write(item.Caracteristica);

#line default
#line hidden
            EndContext();
            BeginContext(880, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(908, 16, false);
#line 31 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Shared\Components\Evento\Default.cshtml"
               Write(item.Pessoa.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(924, 147, true);
            WriteLiteral("</td>\r\n               \r\n             \r\n            \r\n        \r\n                <td>\r\n              <div class=\"btn-group\">\r\n                <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1071, "\"", 1097, 3);
            WriteAttributeValue("", 1081, "Editar(", 1081, 7, true);
#line 38 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Shared\Components\Evento\Default.cshtml"
WriteAttributeValue("", 1088, item.Id, 1088, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1096, ")", 1096, 1, true);
            EndWriteAttribute();
            BeginContext(1098, 202, true);
            WriteLiteral(" class=\"btn btn-sm btn-success\" \r\n                data-toggle=\"tooltip\" data-placement=\"top\" title=\"Editar\" >\r\n                <i class=\"fa fa-edit\"></i>\r\n              </button> \r\n              <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1300, "\"", 1327, 3);
            WriteAttributeValue("", 1310, "Details(", 1310, 8, true);
#line 42 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Shared\Components\Evento\Default.cshtml"
WriteAttributeValue("", 1318, item.Id, 1318, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1326, ")", 1326, 1, true);
            EndWriteAttribute();
            BeginContext(1328, 200, true);
            WriteLiteral(" class=\"btn btn-sm btn-info\"\r\n              data-toggle=\"tooltip\" data-placement=\"top\" title=\"Detalhes\" >\r\n              <i class=\"fa fa-book\"></i>   \r\n            </button>    \r\n              <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1528, "\"", 1563, 4);
            WriteAttributeValue("", 1538, "ExibirModal(", 1538, 12, true);
#line 46 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Shared\Components\Evento\Default.cshtml"
WriteAttributeValue("", 1550, item.Id, 1550, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1558, ",", 1558, 1, true);
            WriteAttributeValue(" ", 1559, "\'\')", 1560, 4, true);
            EndWriteAttribute();
            BeginContext(1564, 452, true);
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
#line 60 "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\Shared\Components\Evento\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(2027, 28, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2074, 1511, true);
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
                            ""sSear");
                WriteLiteral(@"ch"": ""Procurar"",
                            ""oPaginate"": {
                                ""sFirst"": ""Primeiro"",
                                ""sPrevious"": ""Anterior"",
                                ""sNext"": ""Próximo"",
                                ""sLast"": ""Último""
                            }
                        },
                        ""stateSave"": true,
                        ""orderCellsTop"": true,
                    });
            });

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RelacionaW3.Dominio.Models.Evento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
