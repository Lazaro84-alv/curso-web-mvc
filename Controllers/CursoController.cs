using curso.web.mvc.Models.Cursos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
            var cursos = new List<ListarCursoViewModelOutput>();

            cursos.Add(new ListarCursoViewModelOutput()
            {

                Nome = "Curso A",
                Descricao = "Descricao Curso A",
                Login = "lazaroalves",

            });

            cursos.Add(new ListarCursoViewModelOutput()
            {

                Nome = "Curso B",
                Descricao = "Descricao Curso B",
                Login = "lazaroalves",

            });

            return View(cursos);
        }
    }
}
