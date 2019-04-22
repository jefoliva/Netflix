using EstructurasDeDatos.Cola;
using EstructurasDeDatos.Lista;
using EstructurasDeDatos.Pila;
using Netflix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netflix.ViewModels
{
    public class IndexViewModel
    {
        public ListaDoble<Pelicula> TvNiños { get; set; }
        public ListaDoble<Pelicula> Drama{ get; set; }
        public ListaDoble<Pelicula> AccionyAventuras { get; set; }
        public Cola<Pelicula> MiLista { get; set; }
        public Pila<Pelicula> ContinuarViendo{ get; set; }
    }
}