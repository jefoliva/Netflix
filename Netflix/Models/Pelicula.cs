using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Netflix.Models
{
    public class Pelicula
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        [RegularExpression("\\d{4}", ErrorMessage = "Entrada Invalida")]
        [Display(Name = "Año de lanzamiento")]
        public string AñoDeLanzamiento { get; set; }

        public string Duracion { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "Calificaion debe estar entre 1 y 5")]
        public int Calificacion { get; set; }

        [Display(Name = "Genero")]
        public byte GeneroId { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public string PortadaURL { get; set; }

        public string FondoURL { get; set; }

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