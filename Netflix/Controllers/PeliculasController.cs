using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Netflix.Models;
using Netflix.ViewModels;
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
            var viewModel = new PeliculasFormViewModel
            {
                Generos = Datos.Generos
            };

            return View("PeliculasForm", viewModel);
        }

        [HttpPost]
        public ActionResult Guardar(Pelicula pelicula)
        {
            if(!ModelState.IsValid)
            {
                var viewModel = new PeliculasFormViewModel
                {
                    Generos = Datos.Generos
                };

                return View("PeliculasForm", viewModel);
            }

            Datos.tvniños.Agregar(pelicula);

            return RedirectToAction("Index", "Peliculas");
        }

        public ActionResult Reproducir(int id)
        {
            var pelicula = Datos.tvniños.SingleOrDefault(p => p.Id == id);

            if (pelicula == null)
                return HttpNotFound();

            return View(pelicula);
        }
    }
}