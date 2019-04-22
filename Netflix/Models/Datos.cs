using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EstructurasDeDatos.Lista;
using EstructurasDeDatos.Cola;
using EstructurasDeDatos.Pila;

namespace Netflix.Models
{
    public class Datos
    {
        public static Lista<Genero> Generos = new Lista<Genero>
        {
            new Genero() { Id = 0, GeneroNombre = "TV para niños" },
            new Genero() { Id = 1, GeneroNombre = "Drama" },
            new Genero() { Id = 2, GeneroNombre = "Accion y aventuras" },

        };

        public static ListaDoble<Pelicula> peliculas = new ListaDoble<Pelicula>
        {
                new Pelicula { Id = 1, Nombre = "Plaza Sessamo", GeneroId = 0, urlImagen = "~/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 2, Nombre = "Peppa Pig", GeneroId = 0, urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 3, Nombre = "Muppets", GeneroId = 0, urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 4, Nombre = "Looney Tunes", GeneroId = 0, urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 5, Nombre = "Tom y Jerry", GeneroId = 0, urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 6, Nombre = "Adventure Time", GeneroId = 0, urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 7, Nombre = "Nancy Fancy", GeneroId = 0, urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },

                 new Pelicula { Id = 8, Nombre = "Gone Girl", GeneroId = 1, urlImagen = "~/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 9, Nombre = "Rain Man", GeneroId = 1, urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 10, Nombre = "Gone with the wind", GeneroId = 1, urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 11, Nombre = "Eye Wide Slut", GeneroId = 1, urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 12, Nombre = "La naranja mecanica", GeneroId = 1, urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 13, Nombre = "Eterno Resplandor de una mente sin recuerdos", GeneroId = 1, urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 14, Nombre = "Ragging Bull", GeneroId = 1, urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },

                new Pelicula { Id = 15, Nombre = "Mision Imposible", GeneroId = 2, urlImagen = "~/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 16, Nombre = "Pulp Fiction", GeneroId = 2, urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 17, Nombre = "Reservoir Dogs", GeneroId = 2, urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 18, Nombre = "Kill Bill", GeneroId = 2, urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 19, Nombre = "Whiplash", GeneroId = 2, urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 20, Nombre = "Fight Club", GeneroId = 2, urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 21, Nombre = "Se7en", GeneroId = 2, urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" }
        };

        public static ListaDoble<Pelicula> tvniños = Datos.FiltarPorGeneroId(0, peliculas);
        public static ListaDoble<Pelicula> drama = Datos.FiltarPorGeneroId(1, peliculas);
        public static ListaDoble<Pelicula> accionyaventuras = Datos.FiltarPorGeneroId(2, peliculas);
        public static Cola<Pelicula> miLista = new Cola<Pelicula>();
        public static Pila<Pelicula> continuarViendo = new Pila<Pelicula>();

        public static ListaDoble<Pelicula> FiltarPorGeneroId(int id, ListaDoble<Pelicula> lista)
        {
            ListaDoble<Pelicula> resultado = new ListaDoble<Pelicula>();

            foreach(var pelicula in lista)
            {
                if (pelicula.GeneroId == id)
                    resultado.Agregar(pelicula);
            }

            return resultado;
        }
    }
}