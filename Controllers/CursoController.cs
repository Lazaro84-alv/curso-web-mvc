using curso.web.mvc.Models.Cursos;
using Microsoft.AspNetCore.Mvc;

namespace curso.web.mvc.Controllers
{
    public class CursoController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastrarCursoViewModelInput cadastrarCursoViewModelInput)
        {
            return View();
        }

        public IActionResult Listar()
        {
            return View();
        }
    }
}
