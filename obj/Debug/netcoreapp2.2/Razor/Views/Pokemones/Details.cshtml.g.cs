#pragma checksum "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0075df4ac1c879d4c2d80d4322e8c90d00895025"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pokemones_Details), @"mvc.1.0.view", @"/Views/Pokemones/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pokemones/Details.cshtml", typeof(AspNetCore.Views_Pokemones_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0075df4ac1c879d4c2d80d4322e8c90d00895025", @"/Views/Pokemones/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c569150ac0364bcc92305dcb2f600f734e07f73", @"/Views/_ViewImports.cshtml")]
    public class Views_Pokemones_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PokedexMalHecho.Models.Pokemones>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Details.cshtml"
  
    ViewData["Title"] = "Detalles";
    var photoPath = "~/images/" + (Model.Photo ?? "noimage.jpg");

#line default
#line hidden
            BeginContext(154, 179, true);
            WriteLiteral("\r\n<h1>Detalles</h1>\r\n\r\n<div>\r\n    <hr />\r\n</div>\r\n\r\n<div class=\"card mb-3\" sytle=\"max-width:540px\">\r\n    <div class=\"row no-gutters\">\r\n        <div class=\"col-md-4\">\r\n            ");
            EndContext();
            BeginContext(333, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0075df4ac1c879d4c2d80d4322e8c90d008950255596", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#line 17 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Details.cshtml"
          WriteLiteral(photoPath);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 17 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(406, 128, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-md-8\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
            EndContext();
            BeginContext(535, 38, false);
#line 22 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Details.cshtml"
                                  Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(573, 52, true);
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">Región: ");
            EndContext();
            BeginContext(626, 55, false);
#line 23 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Details.cshtml"
                                        Write(Html.DisplayFor(model => model.RegionNavigation.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(681, 50, true);
            WriteLiteral("</p>\r\n                <p class=\"card-text\">Tipos: ");
            EndContext();
            BeginContext(732, 54, false);
#line 24 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.Tipo1Navigation.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(786, 3, true);
            WriteLiteral(" y ");
            EndContext();
            BeginContext(790, 54, false);
#line 24 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Details.cshtml"
                                                                                                 Write(Html.DisplayFor(model => model.Tipo2Navigation.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(844, 52, true);
            WriteLiteral("</p>\r\n                <p class=\"card-text\">Atáques: ");
            EndContext();
            BeginContext(897, 39, false);
#line 25 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Details.cshtml"
                                         Write(Html.DisplayFor(model => model.Ataque1));

#line default
#line hidden
            EndContext();
            BeginContext(936, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(939, 39, false);
#line 25 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Details.cshtml"
                                                                                   Write(Html.DisplayFor(model => model.Ataque2));

#line default
#line hidden
            EndContext();
            BeginContext(978, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(981, 39, false);
#line 25 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Details.cshtml"
                                                                                                                             Write(Html.DisplayFor(model => model.Ataque3));

#line default
#line hidden
            EndContext();
            BeginContext(1020, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1023, 39, false);
#line 25 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Details.cshtml"
                                                                                                                                                                       Write(Html.DisplayFor(model => model.Ataque4));

#line default
#line hidden
            EndContext();
            BeginContext(1062, 118, true);
            WriteLiteral("</p>\r\n                <p class=\"card-text\"></p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1180, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0075df4ac1c879d4c2d80d4322e8c90d0089502511826", async() => {
                BeginContext(1250, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "C:\Users\blask\source\repos\ITLA\C#Intermedio\PokedexMalHecho\Views\Pokemones\Details.cshtml"
                                                   WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1260, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1268, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0075df4ac1c879d4c2d80d4322e8c90d0089502514270", async() => {
                BeginContext(1290, 16, true);
                WriteLiteral("Volver a Listado");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1310, 10, true);
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
