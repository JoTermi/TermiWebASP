#pragma checksum "C:\private\WS\WebProject\repos\Dev\ASP NET\TermiConsult\Views\Leistung\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84a5c3de45c03c7db531fc7e1f823460fb2cdf16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Leistung_Index), @"mvc.1.0.view", @"/Views/Leistung/Index.cshtml")]
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
#nullable restore
#line 1 "C:\private\WS\WebProject\repos\Dev\ASP NET\TermiConsult\Views\_ViewImports.cshtml"
using TermiConsult;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\private\WS\WebProject\repos\Dev\ASP NET\TermiConsult\Views\_ViewImports.cshtml"
using TermiConsult.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84a5c3de45c03c7db531fc7e1f823460fb2cdf16", @"/Views/Leistung/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4f77cc8e7bffaec1665bf5b12b22dbf1b44bb86", @"/Views/_ViewImports.cshtml")]
    public class Views_Leistung_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/MeineKompetenzen.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("opacity:0.1; overflow:no-display;background-repeat: no-repeat"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\private\WS\WebProject\repos\Dev\ASP NET\TermiConsult\Views\Leistung\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Leistung";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""leistung container"" id=""leistungId"" style=""background-color: aliceblue;margin-top:107px; padding-bottom:2px"">
    <div class=""container justify-content-xl-center text-center"">
        <h1 class=""justify-content-center font-weight-bold text-uppercase"" style=""font-family:Rockwell; margin-top:50px"">Meine Leistungen</h1>
        <hr class=""thick"" />

        <div class=""leistung_wrap"" style=""font-family: Rockwell; color:black"">

            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "84a5c3de45c03c7db531fc7e1f823460fb2cdf164610", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

            <div class=""container justify-content-xl-center"" style=""margin-bottom:3px; margin-top:2px"">
                <h5 class=""text-center font-weight-bold text-uppercase"" style=""margin-top:25px""> Freelancer</h5>
                <br />
                <p style=""text-align:justify"">
                    <span style=""font-style: italic; font-size:32px"">I</span>ch bin selbstständiger IT-Ingenieur.<br />
                    Ich habe in den vergangenen Jahren an Projekten unterschiedlicher Richtungen gearbeitet.
                    <br />
                    Meine bisherigen Einsatzpunkte sind die Erstellung von Spezifikationen und Designdokumenten, sowie die Implementierung und die Durchführung von Tests.
                    <br />
");
            WriteLiteral(@"                </p>
            </div>
            <div class=""container justify-content-xl-center"" style=""margin-bottom:3px"">
                <h5 class=""text-center font-weight-bold text-uppercase"" style=""margin-top:5px""> Entwickler</h5>
                <br />
                <p style=""text-align:justify"">
                    <span style=""font-style:italic; font-size:32px"">M</span>eine Tätigkeiten als Entwickler haben ihre Schwerpunkte in der Entwicklung von sowohl Desktop- als auch Webanwendungen.
                    Die Handhabung von Daten zwischen Front- und Backend ist unumgänglich.<br /> Dafür setze ich auf den Objekt Relationalen Mapper (ORM)- das Entity Framework- oder auch auf das Nhibernate.
                    Als Entwickler übernehme ich gern Verantwortung sei es in der ersten Projektphase (Requirement Engineering oder Design), in der Implementierung und dem Test oder auch im Delivery der implementierten Lösungen.
            </div>
            <div class=""container justify-content-xl-");
            WriteLiteral(@"center"" style=""margin-bottom:10px"">
                <h5 class=""text-center font-weight-bold text-uppercase"" style=""margin-top:5px""> Designer</h5>
                <br />
                <p style=""text-align:justify"">
                    <span style=""font-style:italic; font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif; font-size:32px"">I</span>ch arbeite strukturiert und zielorientiert. Wichtig ist mir vor jedem Projektstart größere wie auch kleinere
                    Brocken des Projekts zu erkennen und diese kenntlich zu machen. <br />Die Weiterarbeit stüzt sich auf diese Vorplanung und wird nach festgelegter Priorisierung abgearbeitet.<br />
                    Ich lege großen Wert auf Gründlichkeit. Das Erreichen der festgelegten Ziele unter Einhaltung der geplanten Zeit ist mir sehr wichtig.
                    <br />In meiner Arbeit beziehe ich mich auf etablierte Modelle, und Prinzipien wie beispielsweise das <a href=""https://de.wikipedia.org/wiki/Prinzipien_objektorientiert");
            WriteLiteral(@"en_Designs#SOLID-Prinzipien"" target=""_blank""><strong>S-O-L-I-D  Prinzip</strong></a> das
                    <a href=""https://de.wikipedia.org/wiki/V-Modell"" target=""_blank""><strong>V-Modell</strong></a>, die <a href=""https://de.wikipedia.org/wiki/ALPEN-Methode"" target=""_blank""><strong>ALPEN</strong></a> Methode, um methodisch in meiner Arbeit voran zu schreiten.
            </div>

        </div>
        <br />
    </div>
</div>");
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
