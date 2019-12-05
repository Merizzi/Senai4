using System;
using RoleTopMVC.Enums;
using RoleTopMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class ClienteController : AbstractController
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        
        [HttpGet]
        public IActionResult Login()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Login",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            ViewData["Action"] = "Login";
            try{
                System.Console.WriteLine("==================");
                System.Console.WriteLine(form["email"]);
                System.Console.WriteLine(form["senha"]);
                System.Console.WriteLine("==================");

                var usuario = form["email"];
                var senha = form["senha"];

                var cliente = clienteRepository.ObterPor(usuario);

                if(cliente != null)
                {
                    if(cliente.Senha.Equals(senha))
                    {
                            HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                            HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                            return RedirectToAction("Historico","Cliente");              
                    }
                    else
                    {
                        return View("Erro", new RespostaViewModel(){
                            Mensagem = $"senha incorreta {senha}",
                            NomeView = "Erro"
                        });
                    }
                }
                else
                {
                    return View("Erro", new RespostaViewModel(){
                        Mensagem = $"Usuario: {usuario} não foi encontrado",
                        NomeView = "Erro"
                    });
                }
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel(){
                    Mensagem= "Aaaaaaaaaaaaaaaaaaaaaa",
                    NomeView = "Erro"
                });
            }
        }
        
        // public IActionResult Historico()
        // {
        //     var emailCliente = ObterUsuarioSession();

        //     return View(new HistoricoViewModel()
        //     {
        //         NomeView = "Histórico",
        //         UsuarioEmail = ObterUsuarioSession(),
        //         UsuarioNome = ObterUsuarioNomeSession()
        //     });
        // }

        public IActionResult Logoff()
        {
            HttpContext.Session.Remove(SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE_NOME);
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Login");
        }
    }
}