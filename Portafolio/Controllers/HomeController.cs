using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly IRepositorioProyectos repositorioProyectos;
        private readonly IServicioEmail servicioEmail;

        public HomeController(IRepositorioProyectos repositorioProyectos, IServicioEmail servicioEmail)
        {
            
            this.repositorioProyectos = repositorioProyectos;
            this.servicioEmail = servicioEmail;
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

            
            var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() {
                Proyectos = proyectos
            };
            return View(modelo);
        }

        /**/
        public IActionResult Proyectos() 
        {

            var proyectos = repositorioProyectos.ObtenerProyectos();

            return View(proyectos);

        }

        [HttpGet]
        public IActionResult Contacto() 
        { 
        
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Contacto(ContactoViewModel contacto) 
        {
            await servicioEmail.Enviar(contacto);
            return RedirectToAction("Gracias");
        }

        public IActionResult Gracias() 
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
