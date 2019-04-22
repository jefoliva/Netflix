using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Netflix.Models;

namespace Netflix.ViewModels
{
    public class ReproducirViewModel
    {
        public Pelicula Pelicula { get; set; }
        public bool EstaEnMiLista { get; set; }
        public bool EstaContinuarViendo { get; set; }
    }
}