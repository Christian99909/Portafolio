using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;

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


            var proyectos = ObtenerProyectos().Take(4).ToList();
            var modelo = new HomeIndexViewModel() {
                Proyectos = proyectos
            };
            return View(modelo);
        }

        private List<Proyecto> ObtenerProyectos (){

            return new List<Proyecto>() {

                new Proyecto() {
                    Titulo = "Amazon",
                    Descripcion = "E-commerce realizado en ASP.NET Core",
                    Url = "https://amazon.com",
                    ImagenURL = "/img/amazon.png",
                  
                },
                new Proyecto() {
                    Titulo = "New York Times",
                    Descripcion = "Pagina de nocticias React",
                    Url = "https://nytimes.com",
                    ImagenURL = "/img/nyt.png",

                },
                new Proyecto() {
                    Titulo = "Reddit",
                    Descripcion = "Red social para compartir en comunidades",
                    Url = "https://reddit.com",
                    ImagenURL = "/img/reddit.png",

                },
                new Proyecto() {
                    Titulo = "Steam",
                    Descripcion = "Tienda en linea para comprar videojuegos",
                    Url = "https://store.steampowered.com",
                    ImagenURL = "/img/steam.png",

                },



            };


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
