using Portafolio.Models;

namespace Portafolio.Servicios
{
    public class RepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            /* cccc*/

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
    }
}
