using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        
    }
}