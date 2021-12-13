using E_Jogos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Jogos.Controllers
{
    public class EquipeController : Controller
    {
        Equipe equipeModel = new Equipe();

        // IActionResult representa retorno de status HTTP
        public IActionResult Index()
        {
            // View = responsável pela exibição do frontend
            // ViewBag = armazenar as informações do backend
            // para serem acessadas no frontend

            ViewBag.Equipes = equipeModel.ReadAll();


            return View();
        }


        public IActionResult Cadastrar(IFormCollection form)
        {



        }
    }
}
