#pragma checksum "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ccdf4c995c54fe07c5aa85846d77c196989c379"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pokemones_Delete), @"mvc.1.0.view", @"/Views/Pokemones/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pokemones/Delete.cshtml", typeof(AspNetCore.Views_Pokemones_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ccdf4c995c54fe07c5aa85846d77c196989c379", @"/Views/Pokemones/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c569150ac0364bcc92305dcb2f600f734e07f73", @"/Views/_ViewImports.cshtml")]
    public class Views_Pokemones_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PokedexMalHecho.Models.Pokemones>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Delete.cshtml"
  
    ViewData["Title"] = "Eliminación Pokemon";

#line default
#line hidden
            BeginContext(98, 177, true);
            WriteLiteral("\r\n<h1>Eliminación Pokemon</h1>\r\n<h3>¿Esta seguro que quiere eliminar este pokemon?</h3>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(276, 42, false);
#line 14 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(318, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(382, 38, false);
#line 17 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(420, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(483, 43, false);
#line 20 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ataque1));

#line default
#line hidden
            EndContext();
            BeginContext(526, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(590, 39, false);
#line 23 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ataque1));

#line default
#line hidden
            EndContext();
            BeginContext(629, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(692, 43, false);
#line 26 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ataque2));

#line default
#line hidden
            EndContext();
            BeginContext(735, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(799, 39, false);
#line 29 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ataque2));

#line default
#line hidden
            EndContext();
            BeginContext(838, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(901, 43, false);
#line 32 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ataque3));

#line default
#line hidden
            EndContext();
            BeginContext(944, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1008, 39, false);
#line 35 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ataque3));

#line default
#line hidden
            EndContext();
            BeginContext(1047, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1110, 43, false);
#line 38 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ataque4));

#line default
#line hidden
            EndContext();
            BeginContext(1153, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1217, 39, false);
#line 41 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ataque4));

#line default
#line hidden
            EndContext();
            BeginContext(1256, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1319, 52, false);
#line 44 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RegionNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1371, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1435, 58, false);
#line 47 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RegionNavigation.CodigoRga));

#line default
#line hidden
            EndContext();
            BeginContext(1493, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1562, 51, false);
#line 50 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Tipo1Navigation));

#line default
#line hidden
            EndContext();
            BeginContext(1613, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1677, 54, false);
#line 53 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Tipo1Navigation.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1731, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1800, 51, false);
#line 56 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Tipo2Navigation));

#line default
#line hidden
            EndContext();
            BeginContext(1851, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1915, 54, false);
#line 59 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Tipo2Navigation.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1969, 44, true);
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2013, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ccdf4c995c54fe07c5aa85846d77c196989c37912081", async() => {
                BeginContext(2039, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2049, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0ccdf4c995c54fe07c5aa85846d77c196989c37912474", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 64 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2085, 85, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Eliminar\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2170, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ccdf4c995c54fe07c5aa85846d77c196989c37914394", async() => {
                    BeginContext(2192, 16, true);
                    WriteLiteral("Volver a Listado");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2212, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2225, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PokedexMalHecho.Models.Pokemones> Html { get; private set; }
    }
}
#pragma warning restore 1591
