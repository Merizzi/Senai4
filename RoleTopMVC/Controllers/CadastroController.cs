using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}