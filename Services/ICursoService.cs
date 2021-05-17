using curso.web.mvc.Models.Cursos;
using Refit;
using System.Threading.Tasks;

namespace curso.web.mvc.Services
{
    public interface ICursoService
    {

        [Post("/api/v1/cursos")]
        Task<CadastrarCursoViewModelOutput> Registrar(CadastrarCursoViewModelInput cadastrarCursoViewModelInput);
    }
}
