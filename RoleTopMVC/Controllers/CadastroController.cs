using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;
using RoleTopMVC.Enums;

namespace RoleTopMVC.Controllers
{
    public class CadastroController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Cadastro()
        {
            return View(new BaseViewModel()
            {
                NomeView= "Cadastro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult CadastrarCliente(IFormCollection form)
        {
            ViewData["Action"] = "Cadastro";
            try{
                Cliente cliente = new Cliente(
                    form["nome"],
                    form["sobrenome"],
                    form["email"],
                    form["cpf"],
                    DateTime.Parse(form["data-nascimento"]),
                    form["senha"]
                    );

                    // cliente.TipoUsuario = (uint) TiposUsuario.CLIENTE;
                    clienteRepository.Inserir(cliente);

                    return View("Sucesso", new RespostaViewModel()
                    {
                        NomeView = "Cadastro",
                        UsuarioEmail = ObterUsuarioSession(),
                        UsuarioNome = ObterUsuarioNomeSession()
                    });
                }
                catch(Exception e)
                {
                    System.Console.WriteLine(e.StackTrace);
                    return View("Erro", new RespostaViewModel()
                    {
                        NomeView="Cadastro",
                        UsuarioEmail = ObterUsuarioSession(),
                        UsuarioNome = ObterUsuarioNomeSession()
                    });
                }
        }
    }
}