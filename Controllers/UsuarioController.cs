using curso.web.mvc.Models.Usuarios;
using curso.web.mvc.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Refit;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace curso.web.mvc.Controllers
{
    public class UsuarioController : Controller
    {

        private readonly IUsuarioService usuarioService;
        

        public UsuarioController(IUsuarioService usuarioService)
        {
            usuarioService = usuarioService;
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(RegistrarUsuarioViewModelInput registrarUsuarioViewModelInput)
        {
            try 
            {
                var usuario = await usuarioService.Registrar(registrarUsuarioViewModelInput);

                ModelState.AddModelError("", $"O usuário está autenticado {usuario.Token}");
            }
            catch (ApiException ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            /*var clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };


            var httpClient = new HttpClient(clientHandler);
            httpClient.BaseAddress = new Uri ("https://localhost:5001/");
            var registrarUsuarioViewModelInputJson = JsonConvert.SerializeObject(registrarUsuarioViewModelInput);
            var httpContent = new StringContent(registrarUsuarioViewModelInputJson, System.Text.Encoding.UTF8, "application/json");
            var httpPost = httpClient.PostAsync("/api/v1/usuario/registrar", httpContent).GetAwaiter().GetResult();

            if(httpPost.StatusCode == System.Net.HttpStatusCode.Created)
            {
                ModelState.AddModelError("", "Os dados foram cadastrados com sucesso");
            }
            else
            {
                ModelState.AddModelError("", "Erro ao cadastrar");
            }*/



            return View();
        }

        public IActionResult Logar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logar(LoginViewModelInput loginViewModelInput)
        {

            try
            {
                var usuario = await usuarioService.Logar(loginViewModelInput);

                ModelState.AddModelError("", $"O usuário está autenticado {usuario.Token}");
            }
            catch (ApiException ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return View();
        }
    }
}
