using System;
using RoleTopMVC.Enums;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class OrcamentoController : AbstractController
    {
        OrcamentoRepository orcamentoRepository = new OrcamentoRepository();
        ClienteRepository clienteRepository = new ClienteRepository();

         public IActionResult Index()
        {
            OrcamentoViewModel ovm = new OrcamentoViewModel ();
            
            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterUsuarioNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                ovm.NomeUsuario = nomeUsuarioLogado;
            }

            var clienteLogado = clienteRepository.ObterPor(usuarioLogado);
            if(clienteLogado != null)
            {
                ovm.Cliente = clienteLogado;
            }

            ovm.NomeView = "Orcamento";
            ovm.UsuarioEmail = usuarioLogado;
            ovm.UsuarioNome = nomeUsuarioLogado;

            return View(ovm);
        }

        public IActionResult Registrar (IFormCollection form){
            ViewData["Action"] = "Orcamento";
            Orcamento orcamento = new Orcamento ();

            Cliente cliente = new Cliente(){
                Nome = form["nome"],
                Cpf = form["cpf"],
                Email = form["email"] 
            };

            orcamento.Cliente = cliente;

            if(orcamentoRepository.Inserir (orcamento))
            {
                return View("Sucesso", new RespostaViewModel()
                {
                    NomeView = "Orcamento",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
            else {
                return View ("Erro", new RespostaViewModel(){
                    NomeView = "Orcamento",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
    }
}
