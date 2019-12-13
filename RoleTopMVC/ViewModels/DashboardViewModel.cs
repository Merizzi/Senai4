using System.Collections.Generic;
using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
         public List<Orcamento> Orcamentos {get;set;}
        public uint PedidosAprovados {get;set;}
        public uint PedidosReprovados {get;set;}
        public uint PedidosPendentes {get;set;}

        public DashboardViewModel()
        {
            this.Orcamentos = new List<Orcamento>();
        }
    }
}