using RoleTopMVC.Enums;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class AdministradorController : AbstractController 
    {
        OrcamentoRepository orcamentoRepository = new OrcamentoRepository();
        public IActionResult Dashboard () {

            var ninguemLogado = string.IsNullOrEmpty(ObterUsuarioTipoSession());

            if (!ninguemLogado && 
            (uint) TiposUsuario.ADMINISTRADOR == uint.Parse(ObterUsuarioTipoSession())) {

                var pedidos = orcamentoRepository.ObterTodos ();
                DashboardViewModel dashboardViewModel = new DashboardViewModel ();

                foreach (var orcamento in pedidos) {
                    switch (orcamento.Status) {
                        case (uint) StatusPedido.APROVADO:
                            dashboardViewModel.PedidosAprovados++;
                            break;
                        case (uint) StatusPedido.REPROVADO:
                            dashboardViewModel.PedidosReprovados++;
                            break;
                        default:
                            dashboardViewModel.PedidosPendentes++;
                            dashboardViewModel.Orcamentos.Add (orcamento);
                            break;
                    }
                }
                dashboardViewModel.NomeView = "Dashboard";
                dashboardViewModel.UsuarioEmail = ObterUsuarioSession ();

                return View (dashboardViewModel);
            } 
            else 
            {
                return View ("Erro", new RespostaViewModel(){
                    NomeView = "Dashboard",
                    Mensagem = "Você não tem permissão para acessar o Dashboard"
                });

            }
        }
    }
}