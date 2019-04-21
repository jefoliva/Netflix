using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Netflix.Models
{
    public class Pelicula
    {
        // public enum TiposDeGenero { TvParaNiños, Drama, AccionYAventuras }

        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        [RegularExpression("\\d{4}", ErrorMessage = "Entrada Invalida")]
        [Display(Name = "Año de lanzamiento")]
        public string AñoDeLanzamiento{ get; set;}

        [Required]
        public Genero Genero { get; set; }

        [Display(Name = "Genero")]
        public byte GeneroId { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public string urlImagen { get; set; }

        /* public string GetGenero()
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
        } */
    }
}