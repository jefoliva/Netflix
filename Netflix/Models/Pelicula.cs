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

        public Genero Genero { get; set; }

        [Display(Name = "Genero")]
        public byte GeneroId { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public string urlImagen { get; set; }

        public string GetGenero()
        {
            switch(GeneroId)
            {
                case 0:
                    return "Tv para niños";
                case 1:
                    return "Drama";
                case 2:
                    return "Accion y Aventura";
            }

            return "";
        }

        public override bool Equals(object obj)
        {
            Pelicula x = (Pelicula) obj;

            return this.Id == x.Id;
        }
    }
}