using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers {
    public class PedidoController : AbstractController {
        PedidoRepository pedidoRepository = new PedidoRepository ();
        HamburguerRepository hamburguerRepository = new HamburguerRepository();
        ShakeRepository shakeRepository = new ShakeRepository();

        ClienteRepository clienteRepository = new ClienteRepository();

        public IActionResult Index () {

            PedidoViewModel pvm = new PedidoViewModel();
            pvm.Hamburgueres = hamburguerRepository.ObterTodos();
            pvm.Shakes = shakeRepository.ObterTodos();

            var usuariologado = ObterUsuarioSession();
            var nomeUsuarioLogado=  ObterUsuarioNomeSession();

            if(!string.IsNullOrEmpty(nomeUsuarioLogado)){
                pvm.NomeUsuario = ObterUsuarioNomeSession();
            }

            var clienteLogado = clienteRepository.ObterPor(usuariologado);
            if(clienteLogado != null)
            {
                pvm.Cliente = clienteLogado;
            }

            return View (pvm);
        }

        public IActionResult Registrar (IFormCollection form) {
            ViewData["Action"] = "Pedido";
            Pedido pedido = new Pedido ();

            var nomeShake = form["shake"];
            Shake shake = new Shake ();
            shake.Nome = nomeShake;
            shake.Preco = shakeRepository.ObterPrecoDe(nomeShake);

            pedido.Shake = shake;

            var nomeHamburguer = form["hamburguer"];
            Hamburguer hamburguer = new Hamburguer (
                nomeHamburguer, 
                hamburguerRepository.ObterPrecoDe(nomeHamburguer));

            pedido.Hamburguer = hamburguer;

            Cliente cliente = new Cliente () {
                Nome = form["nome"],
                Endereco = form["endereco"],
                Telefone = form["telefone"],
                Email = form["email"]
            };

            pedido.Cliente = cliente;

            pedido.DataDoPedido = DateTime.Now;

            pedido.PrecoTotal = hamburguer.Preco + shake.Preco;

            if (pedidoRepository.Inserir (pedido)) {
                return View ("Sucesso");
            } else {
                return View ("Erro");
            }
        }
    }
}