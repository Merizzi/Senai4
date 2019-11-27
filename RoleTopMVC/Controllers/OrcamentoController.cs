using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class OrcamentoController : Controller
    {
         public IActionResult Orcamento()
        {
            return View();
        }
    }
}