#pragma checksum "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\GRUPO6\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Jugadores\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8be8fe1181f171b3d2b894787db78c656ea09bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TorneoFutbolistico.App.Frontend.Pages.Jugadores.Pages_Jugadores_Details), @"mvc.1.0.razor-page", @"/Pages/Jugadores/Details.cshtml")]
namespace TorneoFutbolistico.App.Frontend.Pages.Jugadores
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\GRUPO6\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\_ViewImports.cshtml"
using TorneoFutbolistico.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8be8fe1181f171b3d2b894787db78c656ea09bc", @"/Pages/Jugadores/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9755150b436199d2407957ca9da196c2dd0a17f0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Jugadores_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Detalles Jugadores</h1>\r\n<table class=\"table table-dark\">\r\n    <tr>\r\n        <th scope=\"col\">Nombre</th>\r\n        <td>");
#nullable restore
#line 9 "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\GRUPO6\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Jugadores\Details.cshtml"
       Write(Model.jugador.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">Apellidos</th>\r\n        <td>");
#nullable restore
#line 13 "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\GRUPO6\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Jugadores\Details.cshtml"
       Write(Model.jugador.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">NumeroTelefono</th>\r\n        <td>");
#nullable restore
#line 17 "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\GRUPO6\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Jugadores\Details.cshtml"
       Write(Model.jugador.NumeroTelefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">Documento</th>\r\n        <td>");
#nullable restore
#line 21 "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\GRUPO6\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Jugadores\Details.cshtml"
       Write(Model.jugador.Documento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">Id_P</th>\r\n        <td>");
#nullable restore
#line 25 "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\GRUPO6\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Jugadores\Details.cshtml"
       Write(Model.jugador.Id_P);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">Numero</th>\r\n        <td>");
#nullable restore
#line 29 "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\GRUPO6\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Jugadores\Details.cshtml"
       Write(Model.jugador.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">Posicion</th>\r\n        <td>");
#nullable restore
#line 33 "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\GRUPO6\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Jugadores\Details.cshtml"
       Write(Model.jugador.Posicion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th scope=\"col\">N_equipo</th>\r\n        <td>");
#nullable restore
#line 37 "C:\Users\Carlos\Desktop\Misiontic 2020 UCALDAS\DESARROLLO DE SOFTWARE\GRUPO6\TorneoFutbolisticoCS\TorneoFutbolistico.App.Frontend\Pages\Jugadores\Details.cshtml"
       Write(Model.jugador.N_equipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8be8fe1181f171b3d2b894787db78c656ea09bc7093", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TorneoFutbolistico.App.Frontend.Pages.Jugadores.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoFutbolistico.App.Frontend.Pages.Jugadores.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoFutbolistico.App.Frontend.Pages.Jugadores.DetailsModel>)PageContext?.ViewData;
        public TorneoFutbolistico.App.Frontend.Pages.Jugadores.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
