using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Netflix.Models;
using EstructurasDeDatos.Lista;
namespace Netflix.ViewModels
{
    public class PeliculasViewModel
    {
        public ListaDoble<Pelicula> TvNiños { get; set; }
        public ListaDoble<Pelicula> Drama { get; set; }
        public ListaDoble<Pelicula> AccionyAventuras { get; set; }
    }
}