using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Netflix.Models;

namespace Netflix.Controllers.Api
{
    public class PeliculasController : ApiController
    {
        // GET: api/peliculas
        [HttpGet]
        public IHttpActionResult GetPeliculas(string query = null)
        {
            IEnumerable<Pelicula> peliculasQuery = Datos.peliculas;

            if (!String.IsNullOrWhiteSpace(query))
            {
                peliculasQuery = peliculasQuery.Where(c => c.Nombre.Contains(query));
            }

            return Ok(peliculasQuery);
        }
    }
}
