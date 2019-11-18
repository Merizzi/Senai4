using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class PedidoController : Controller
    {
        PedidoRepository pedidoRepository = new PedidoRepository();

        HamburguerRepository hamburguerRepository = new HamburguerRepository();
        public IActionResult Index()
        {
            var hamburgueres = hamburguerRepository.ObterTodos();

            PedidoViewModel pedido = new PedidoViewModel();
            pedido.Hamburgueres = hamburgueres;

            return View();
        }

        [HttpPost]
        public IActionResult Registrar(IFormCollection form)
        {
            Pedido pedido = new Pedido();

            Shake shake = new Shake();
            shake.Nome = form["shake"];
            shake.Preco = 0.0;

            pedido.Shake = shake; //para falar que pertencente ao objeto pedido

            Hamburguer hamburguer = new Hamburguer(form["hamburguer"], 0.0);

            pedido.Hamburger = hamburguer; //para falar que pertencente ao objeto pedido
            
            Cliente cliente = new Cliente()
            {
                Nome = form["nome"],
                Endereco = form ["endereco"],
                Telefone = form["telefone"],
                Email = form["email"],
            };

            pedido.Cliente = cliente;//para falar que pertencente ao objeto pedido

            pedido.DataDoPedido = DateTime.Now;
            
            pedido.PrecoTotal = 0.0;

            pedidoRepository.Inserir(pedido);

            ViewData["Action"] = "Pedido";
            
            return View("Sucesso");
        }
    }
}