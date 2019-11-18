using System;

namespace McBonaldsMVC.Models
{
    public class Pedido
    {
        public Cliente Cliente {get; set;}
        public Hamburguer Hamburger {get; set;}
        public Shake Shake {get; set;}
        public DateTime DataDoPedido {get; set;}
        public double PrecoTotal {get; set;}
    }
}