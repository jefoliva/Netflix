using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EstructurasDeDatos.Lista;
using Netflix.Models;

namespace Netflix.ViewModels
{
    public class PeliculasFormViewModel
    {
        public Pelicula Pelicula { get; set; }
        public Lista<Genero> Generos { get; set; }
    }
}