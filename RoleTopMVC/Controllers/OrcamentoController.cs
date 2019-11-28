using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class OrcamentoController : Controller
    {
         public IActionResult Orcamento()
        {
            return View(new BaseViewModel()
            {
                NomeView= "Orcamento"
            }
            );
        }
    }
}