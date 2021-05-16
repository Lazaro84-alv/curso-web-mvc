using curso.web.mvc.Models.Usuarios;
using Microsoft.AspNetCore.Mvc;


namespace curso.web.mvc.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(RegistrarUsuarioViewModelInput registrarUsuarioViewModelInput)
        {
            return View();
        }

        public IActionResult Logar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logar(LoginViewModelInput loginViewModelInput)
        {
            return View();
        }
    }
}
