#pragma checksum "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e0bc50fef48d1513fd0dc07ac852d1d85b63aef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\_ViewImports.cshtml"
using PokedexMalHecho;

#line default
#line hidden
#line 2 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\_ViewImports.cshtml"
using PokedexMalHecho.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e0bc50fef48d1513fd0dc07ac852d1d85b63aef", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c569150ac0364bcc92305dcb2f600f734e07f73", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Home\Index.cshtml"
   
    ViewData["Title"] = "Inicio";

#line default
#line hidden
            BeginContext(43, 366, true);
            WriteLiteral(@"
    <div class=""card-deck"">
        <div class=""card"" style=""width: 18rem"">
            <div class=""card-body"">
                <h4 class=""card-title"">Pokemones</h4>
                <p class=""card-text"">Listado de pokemones registrados. Administración de creaturas.</p>
            </div>
            <div class=""card-footer text-center"">
                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 409, "\"", 448, 1);
#line 12 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Home\Index.cshtml"
WriteAttributeValue("", 416, Url.Action("Index","Pokemones"), 416, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(449, 375, true);
            WriteLiteral(@" class=""btn btn-primary"">Listado</a>
            </div>
        </div>

        <div class=""card"" style=""width: 18rem;"">
            <div class=""card-body"">
                <h4 class=""card-title"">Regiones</h4>
                <p class=""card-text"">Administración de regiones</p>
            </div>
            <div class=""card-footer text-center"">
                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 824, "\"", 862, 1);
#line 22 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Home\Index.cshtml"
WriteAttributeValue("", 831, Url.Action("Index","Regiones"), 831, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(863, 393, true);
            WriteLiteral(@" class=""btn btn-primary"">Listado</a>
            </div>
        </div>

        <div class=""card"" style=""width: 18rem;"">
            <div class=""card-body"">
                <h4 class=""card-title"">Tipos</h4>
                <p class=""card-text"">Administración de tipos de pokemones y poderes.</p>
            </div>
            <div class=""card-footer text-center"">
                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1256, "\"", 1291, 1);
#line 32 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Home\Index.cshtml"
WriteAttributeValue("", 1263, Url.Action("Index","Tipos"), 1263, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1292, 84, true);
            WriteLiteral(" class=\"btn btn-primary\">Listado</a>\r\n            </div>\r\n        </div>\r\n    </div>");
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
