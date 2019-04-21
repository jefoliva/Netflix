using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Netflix.Models
{
    public class Pelicula
    {
        public enum TiposDeGenero { TvParaNiños, Drama, AccionYAventuras }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaDeLanzamiento { get; set;}
        public TiposDeGenero Genero { get; set; }
        public string Descripcion { get; set; }
        public string urlImagen { get; set; }

        public string GetGenero()
        {
            switch(Genero)
            {
                case TiposDeGenero.TvParaNiños:
                    return "Tv para niños";
                case TiposDeGenero.Drama:
                    return "Drama";
                case TiposDeGenero.AccionYAventuras:
                    return "Accion y Aventura";
            }

            return "";
        }
    }
}