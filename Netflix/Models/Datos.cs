using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EstructurasDeDatos.Lista;

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
        public static ListaDoble<Pelicula> tvniños = new ListaDoble<Pelicula> {
                new Pelicula { Id = 1, Nombre = "Plaza Sessamo", Genero = Generos.Single(g => g.Id == 0), urlImagen = "~/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 2, Nombre = "Peppa Pig", Genero = Generos.Single(g => g.Id == 0), urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 3, Nombre = "Muppets", Genero = Generos.Single(g => g.Id == 0), urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 4, Nombre = "Peppa Pig", Genero = Generos.Single(g => g.Id == 0), urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 5, Nombre = "Muppets", Genero = Generos.Single(g => g.Id == 0), urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 6, Nombre = "Peppa Pig", Genero = Generos.Single(g => g.Id == 0), urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 7, Nombre = "Muppets", Genero = Generos.Single(g => g.Id == 0), urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" }
        };

        public static ListaDoble<Pelicula> drama = new ListaDoble<Pelicula> {
                new Pelicula { Id = 1, Nombre = "Plaza Sessamo", Genero = Generos.Single(g => g.Id == 1), urlImagen = "~/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 2, Nombre = "Peppa Pig", Genero = Generos.Single(g => g.Id == 1), urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 3, Nombre = "Muppets", Genero = Generos.Single(g => g.Id == 1), urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 4, Nombre = "Peppa Pig", Genero = Generos.Single(g => g.Id == 1), urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 5, Nombre = "Muppets", Genero = Generos.Single(g => g.Id == 1), urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 6, Nombre = "Peppa Pig", Genero = Generos.Single(g => g.Id == 1), urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 7, Nombre = "Muppets", Genero = Generos.Single(g => g.Id == 1), urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" }
        };

        public static ListaDoble<Pelicula> accionyaventuras = new ListaDoble<Pelicula> {
                new Pelicula { Id = 1, Nombre = "Plaza Sessamo", Genero = Generos.Single(g => g.Id == 0), urlImagen = "~/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 2, Nombre = "Peppa Pig", Genero = Generos.Single(g => g.Id == 0), urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 3, Nombre = "Muppets", Genero = Generos.Single(g => g.Id == 0), urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 4, Nombre = "Peppa Pig", Genero = Generos.Single(g => g.Id == 0), urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 5, Nombre = "Muppets", Genero = Generos.Single(g => g.Id == 0), urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 6, Nombre = "Peppa Pig", Genero = Generos.Single(g => g.Id == 0), urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 7, Nombre = "Muppets", Genero = Generos.Single(g => g.Id == 0), urlImagen = "/img/img01.jpg", AñoDeLanzamiento = "2018", Descripcion = "Lorem Ipsum Dolor" }
        };
    }
}