#pragma checksum "C:\Users\pgcit\OneDrive\Área de Trabalho\Projetos-Git-Trabalho\RelacionaW3-Refatorado\relacionaw3.mvc\Views\CoreUI\base-collapse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffdef722a69c6fae3ea1875b7ec76c3811f069a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CoreUI_base_collapse), @"mvc.1.0.view", @"/Views/CoreUI/base-collapse.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CoreUI/base-collapse.cshtml", typeof(AspNetCore.Views_CoreUI_base_collapse))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffdef722a69c6fae3ea1875b7ec76c3811f069a4", @"/Views/CoreUI/base-collapse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ff5f67da75fc0b1fd5374a73795734c2ee7e112", @"/Views/_ViewImports.cshtml")]
    public class Views_CoreUI_base_collapse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 8558, true);
            WriteLiteral(@"<div class=""row"">
  <div class=""col-sm-12 col-xl-6"">
    <div class=""card"">
      <div class=""card-header"">
        <i class=""fa fa-align-justify""></i> Collapse
        <div class=""card-header-actions"">
          <a href=""http://coreui.io/docs/components/bootstrap-collapse/"" class=""card-header-action"" target=""_blank"">
            <small class=""text-muted"">docs</small>
          </a>
        </div>
      </div>
      <div class=""card-body"">
        <p>
          <a class=""btn btn-primary"" data-toggle=""collapse"" href=""#collapseExample"" aria-expanded=""false"" aria-controls=""collapseExample"">
            Link with href
          </a>
          <button class=""btn btn-primary"" type=""button"" data-toggle=""collapse"" data-target=""#collapseExample"" aria-expanded=""false"" aria-controls=""collapseExample"">
            Button with data-target
          </button>
        </p>
        <div class=""collapse"" id=""collapseExample"">
          <div class=""card card-body"">
            Anim pariatur cliche reprehenderit, enim eiusmod h");
            WriteLiteral(@"igh life accusamus terry richardson ad squid. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident.
          </div>
        </div>
      </div>
    </div>
    <div class=""card"">
      <div class=""card-header"">
        <i class=""fa fa-align-justify""></i> Collapse
        <small>multiple targets</small>
      </div>
      <div class=""card-body"">
        <p>
          <a class=""btn btn-primary"" data-toggle=""collapse"" href=""#multiCollapseExample1"" aria-expanded=""false"" aria-controls=""multiCollapseExample1"">Toggle first element</a>
          <button class=""btn btn-primary"" type=""button"" data-toggle=""collapse"" data-target=""#multiCollapseExample2"" aria-expanded=""false"" aria-controls=""multiCollapseExample1"">Toggle second element</button>
          <button class=""btn btn-primary"" type=""button"" data-toggle=""collapse"" data-target="".multi-collapse"" aria-expanded=""false"" aria-controls=""multiCollapseExample1 multiCollapseExample2"">Toggle both elements</button>
        </p>
     ");
            WriteLiteral(@"   <div class=""row"">
          <div class=""col-sm-12 col-md-6"">
            <div class=""collapse multi-collapse"" id=""multiCollapseExample1"">
              <div class=""card card-body"">
                Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident.
              </div>
            </div>
          </div>
          <div class=""col-sm-12 col-md-6"">
            <div class=""collapse multi-collapse"" id=""multiCollapseExample2"">
              <div class=""card card-body"">
                Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident.
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
  <div class=""col-sm-12 col-xl-6"">
    <div class=""card"">
      <div class=""card-header"">
     ");
            WriteLiteral(@"   <i class=""fa fa-align-justify""></i> Collapse
        <small>accordion</small>
      </div>
      <div class=""card-body"">
        <div id=""accordion"" role=""tablist"">
          <div class=""card"">
            <div class=""card-header"" role=""tab"" id=""headingOne"">
              <h5 class=""mb-0"">
                <a data-toggle=""collapse"" href=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">
                  Collapsible Group Item #1
                </a>
              </h5>
            </div>

            <div id=""collapseOne"" class=""collapse show"" role=""tabpanel"" aria-labelledby=""headingOne"" data-parent=""#accordion"">
              <div class=""card-body"">
                Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird
                on it squid single-origin coffee nulla assumenda shoreditch e");
            WriteLiteral(@"t. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft
                beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
              </div>
            </div>
          </div>
          <div class=""card"">
            <div class=""card-header"" role=""tab"" id=""headingTwo"">
              <h5 class=""mb-0"">
                <a class=""collapsed"" data-toggle=""collapse"" href=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">
                  Collapsible Group Item #2
                </a>
              </h5>
            </div>
            <div id=""collapseTwo"" class=""collapse"" role=""tabpanel"" aria-labelledby=""headingTwo"" data-parent=""#accordion"">
              <div class=""card-body"">
                Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non c");
            WriteLiteral(@"upidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird
                on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft
                beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
              </div>
            </div>
          </div>
          <div class=""card"">
            <div class=""card-header"" role=""tab"" id=""headingThree"">
              <h5 class=""mb-0"">
                <a class=""collapsed"" data-toggle=""collapse"" href=""#collapseThree"" aria-expanded=""false"" aria-controls=""collapseThree"">
                  Collapsible Group Item #3
                </a>
              </h5>
            </div>
            <div id=""collapseThree"" class=""collapse"" role=""tabpanel"" aria-labelledby=""headin");
            WriteLiteral(@"gThree"" data-parent=""#accordion"">
              <div class=""card-body"">
                Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird
                on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft
                beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class=""card"">
      <div class=""card-header"">
        <i class=""fa fa-align-justify""></i> Collapse
        <small>custom accordion</small>
      </div>
      <div class=""card-body"">
        <div i");
            WriteLiteral(@"d=""exampleAccordion"" data-children="".item"">
          <div class=""item"">
            <a data-toggle=""collapse"" data-parent=""#exampleAccordion"" href=""#exampleAccordion1"" aria-expanded=""true"" aria-controls=""exampleAccordion1"">
              Toggle item
            </a>
            <div id=""exampleAccordion1"" class=""collapse show"" role=""tabpanel"">
              <p class=""mb-3"">
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed pretium lorem non vestibulum scelerisque. Proin a vestibulum sem, eget tristique massa. Aliquam lacinia rhoncus nibh quis ornare.
              </p>
            </div>
          </div>
          <div class=""item"">
            <a data-toggle=""collapse"" data-parent=""#exampleAccordion"" href=""#exampleAccordion2"" aria-expanded=""false"" aria-controls=""exampleAccordion2"">
              Toggle item 2
            </a>
            <div id=""exampleAccordion2"" class=""collapse"" role=""tabpanel"">
              <p class=""mb-3"">
                Donec at ipsum dignissim, rutrum tur");
            WriteLiteral(@"pis scelerisque, tristique lectus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Vivamus nec dui turpis. Orci varius natoque penatibus et magnis dis parturient montes,
                nascetur ridiculus mus.
              </p>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</div>
");
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
