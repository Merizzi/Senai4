#pragma checksum "C:\Users\43097878866\Documents\Senai4\RoleTopMVC\Views\Cliente\Historico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "033cd652dcd18fbbd480bdf90a1773a8572267f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Historico), @"mvc.1.0.view", @"/Views/Cliente/Historico.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Historico.cshtml", typeof(AspNetCore.Views_Cliente_Historico))]
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
#line 1 "C:\Users\43097878866\Documents\Senai4\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\43097878866\Documents\Senai4\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"033cd652dcd18fbbd480bdf90a1773a8572267f3", @"/Views/Cliente/Historico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Historico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.HistoricoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\43097878866\Documents\Senai4\RoleTopMVC\Views\Cliente\Historico.cshtml"
  
    ViewData["Title"] = "Pedidos - RoleTop";
    ViewData["H2"] = "Histórico de Eventos";

#line default
#line hidden
            BeginContext(148, 18, true);
            WriteLiteral("\r\n<main>\r\n    <h2>");
            EndContext();
            BeginContext(167, 14, false);
#line 8 "C:\Users\43097878866\Documents\Senai4\RoleTopMVC\Views\Cliente\Historico.cshtml"
   Write(ViewData["H2"]);

#line default
#line hidden
            EndContext();
            BeginContext(181, 280, true);
            WriteLiteral(@"</h2>
    <table>
        <thead class=""hisorico"">
            <tr>
                <th>Data</th>
                <th>Horario</th>
                <th>Nome do Evento</th>
                <th>Responsável do Evento</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 19 "C:\Users\43097878866\Documents\Senai4\RoleTopMVC\Views\Cliente\Historico.cshtml"
            foreach( var orcamento in Model.Eventos){

#line default
#line hidden
            BeginContext(516, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(563, 20, false);
#line 21 "C:\Users\43097878866\Documents\Senai4\RoleTopMVC\Views\Cliente\Historico.cshtml"
                   Write(orcamento.DataEvento);

#line default
#line hidden
            EndContext();
            BeginContext(583, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(615, 17, false);
#line 22 "C:\Users\43097878866\Documents\Senai4\RoleTopMVC\Views\Cliente\Historico.cshtml"
                   Write(orcamento.Horario);

#line default
#line hidden
            EndContext();
            BeginContext(632, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(664, 16, false);
#line 23 "C:\Users\43097878866\Documents\Senai4\RoleTopMVC\Views\Cliente\Historico.cshtml"
                   Write(orcamento.Evento);

#line default
#line hidden
            EndContext();
            BeginContext(680, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(712, 22, false);
#line 24 "C:\Users\43097878866\Documents\Senai4\RoleTopMVC\Views\Cliente\Historico.cshtml"
                   Write(orcamento.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(734, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 26 "C:\Users\43097878866\Documents\Senai4\RoleTopMVC\Views\Cliente\Historico.cshtml"
            }

#line default
#line hidden
            BeginContext(779, 2019, true);
            WriteLiteral(@"        </tbody>
    </table>

</main>
<footer>
        
        <div class=""section-container"">
            
            <div class=""content-footer"">
                <div class=""content-icons"">
                    <img src=""../img/instaa.png""   class=""iconss""> 
                    <a> #Roletop </a>
                    <img src=""../img/twitter.png"" class=""iconss2"">
                    <a> #Roletoop</a>
                    <img src=""../img/face.png""    class=""iconss3"">
                    <a> faceboo.com/roletop</a>
                </div>
                <div class=""content-address"">
                    <address>
                        <img src=""../img/icon-small-map-4f3b6656.png"" class=""logmp"">
                        <div class=""content-address-info"">
                            <a> Avenida de Limeira,  </a>
                            <a> Campos Elíseos - SP  </a>
                            <a>  N°539    </a>
                        </div>
                    </address>
         ");
            WriteLiteral(@"           <address>
                        <img src=""../img/icon-small-phone-ee157a50.png"" class=""logotel"">
                        <div class=""content-address-info"">
                            <a> mcbonalds@email.com  </a>
                            <a> 11 1234 6789  </a>  
                        </div>
                    </address>
                </div>
                <div id=""local"">
                    <iframe
                    src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3657.8869961505543!2d-46.648477085071065!3d-23.53656648469522!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce5843deade6e3%3A0x124f377d06c7e71f!2sAlameda+Bar%C3%A3o+de+Limeira%2C+539+-+Campos+El%C3%ADseos%2C+S%C3%A3o+Paulo+-+SP%2C+01202-001!5e0!3m2!1sen!2sbr!4v1550223658410""
                    width=""100%"" height=""100%"" frameborder=""0"" style=""border:0"" ></iframe>
                </div>
            </div>
            

            
        </div>
    </footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.HistoricoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
