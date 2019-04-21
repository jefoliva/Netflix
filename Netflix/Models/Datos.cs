using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EstructurasDeDatos.Lista;

namespace Netflix.Models
{
    public class Datos
    {
        public static ListaDoble<Pelicula> tvniños = new ListaDoble<Pelicula> {
                new Pelicula { Id = 1, Nombre = "Plaza Sessamo", Genero = 0, urlImagen = "~/img/img01.jpg", FechaDeLanzamiento = new DateTime(), Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 2, Nombre = "Peppa Pig", Genero = 0, urlImagen = "/img/img01.jpg", FechaDeLanzamiento = new DateTime(), Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 3, Nombre = "Muppets", Genero = 0, urlImagen = "/img/img01.jpg", FechaDeLanzamiento = new DateTime(), Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 4, Nombre = "Peppa Pig", Genero = 0, urlImagen = "/img/img01.jpg", FechaDeLanzamiento = new DateTime(), Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 5, Nombre = "Muppets", Genero = 0, urlImagen = "/img/img01.jpg", FechaDeLanzamiento = new DateTime(), Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 6, Nombre = "Peppa Pig", Genero = 0, urlImagen = "/img/img01.jpg", FechaDeLanzamiento = new DateTime(), Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 7, Nombre = "Muppets", Genero = 0, urlImagen = "/img/img01.jpg", FechaDeLanzamiento = new DateTime(), Descripcion = "Lorem Ipsum Dolor" }
        };

        public static ListaDoble<Pelicula> drama = new ListaDoble<Pelicula> {
                new Pelicula { Id = 1, Nombre = "Plaza Sessamo", Genero = 0, urlImagen = "~/img/img01.jpg", FechaDeLanzamiento = new DateTime(), Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 2, Nombre = "Peppa Pig", Genero = 0, urlImagen = "/img/img01.jpg", FechaDeLanzamiento = new DateTime(), Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 3, Nombre = "Muppets", Genero = 0, urlImagen = "/img/img01.jpg", FechaDeLanzamiento = new DateTime(), Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 4, Nombre = "Peppa Pig", Genero = 0, urlImagen = "/img/img01.jpg", FechaDeLanzamiento = new DateTime(), Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 5, Nombre = "Muppets", Genero = 0, urlImagen = "/img/img01.jpg", FechaDeLanzamiento = new DateTime(), Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 6, Nombre = "Peppa Pig", Genero = 0, urlImagen = "/img/img01.jpg", FechaDeLanzamiento = new DateTime(), Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 7, Nombre = "Muppets", Genero = 0, urlImagen = "/img/img01.jpg", FechaDeLanzamiento = new DateTime(), Descripcion = "Lorem Ipsum Dolor" }
        };

        public static ListaDoble<Pelicula> accionyaventuras = new ListaDoble<Pelicula> {
                new Pelicula { Id = 1, Nombre = "Plaza Sessamo", Genero = 0, urlImagen = "~/img/img01.jpg", FechaDeLanzamiento = new DateTime(), Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 2, Nombre = "Peppa Pig", Genero = 0, urlImagen = "/img/img01.jpg", FechaDeLanzamiento = new DateTime(), Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 3, Nombre = "Muppets", Genero = 0, urlImagen = "/img/img01.jpg", FechaDeLanzamiento = new DateTime(), Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 4, Nombre = "Peppa Pig", Genero = 0, urlImagen = "/img/img01.jpg", FechaDeLanzamiento = new DateTime(), Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 5, Nombre = "Muppets", Genero = 0, urlImagen = "/img/img01.jpg", FechaDeLanzamiento = new DateTime(), Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 6, Nombre = "Peppa Pig", Genero = 0, urlImagen = "/img/img01.jpg", FechaDeLanzamiento = new DateTime(), Descripcion = "Lorem Ipsum Dolor" },
                new Pelicula { Id = 7, Nombre = "Muppets", Genero = 0, urlImagen = "/img/img01.jpg", FechaDeLanzamiento = new DateTime(), Descripcion = "Lorem Ipsum Dolor" }
        };
    }
}