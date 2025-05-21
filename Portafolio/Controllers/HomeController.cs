using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            /*ViewBag.Nombre = "Christian Emanuel Flores Arcia";*/

            /*return View("index", "Christian Emanuel Flores Arcia");*/
            /* var persona = new Persona() {
                 Nombre = "Christian Emanuel Flores Arcia",
                 Edad = 30

             };
             return View(persona);*/

            var repositorio = new RepositorioProyectos();
            var proyectos = repositorio.ObtenerProyectos().Take(4).ToList();
            var modelo = new HomeIndexViewModel() {
                Proyectos = proyectos
            };
            return View(modelo);
        }
        
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
