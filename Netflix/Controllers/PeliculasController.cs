using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Netflix.Models;
using EstructurasDeDatos.Lista;

namespace Netflix.Controllers
{
    public class PeliculasController : Controller
    {
        

        // GET: Peliculas
        public ActionResult Index()
        {
           
            ListaDoble<Pelicula> peliculas = Datos.tvniños;

            return View(peliculas);
        }

        public ActionResult Nueva()
        {
            return View("PeliculaForm");
        }

        [HttpPost]
        /*public ActionResult Agregar(Pelicula pelicula)
        {
            if(!ModelState.IsValid)

        } */

        public ActionResult Reproducir(int id)
        {
            var pelicula = Datos.tvniños.SingleOrDefault(p => p.Id == id);

            if (pelicula == null)
                return HttpNotFound();

            return View(pelicula);
        }
    }
}