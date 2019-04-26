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

        // GET: /Peliculas/
        public ActionResult Index()
        {

            var viewModel = new ViewModels.IndexViewModel
            {
                TvNiños = Datos.tvniños,
                Drama = Datos.drama,
                AccionyAventuras = Datos.accionyaventuras,
                MiLista = Datos.miLista,
                ContinuarViendo = Datos.continuarViendo
            };

            return View(viewModel);
        }

        // /Peliculas/Reproducir/id
        public ActionResult Reproducir(int id)
        {
            var pelicula = Datos.peliculas.SingleOrDefault(p => p.Id == id);

            if (pelicula == null)
                return HttpNotFound();

            var viewModel = new ReproducirViewModel
            {
                Pelicula = pelicula,
                EstaEnMiLista = Datos.miLista.Any(p => p.Id == pelicula.Id),
                EstaContinuarViendo = Datos.continuarViendo.Any(p => p.Id == pelicula.Id)
            };

            return View(viewModel);
        }

        // /Peliculas/Nueva
        public ActionResult Nueva()
        {
            var viewModel = new PeliculasFormViewModel
            {
                Generos = Datos.Generos
            };

            return View("PeliculasForm", viewModel);
        }

        // POST: /Peliculas/Guardar/
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

            pelicula.Id = Datos.peliculas.Max(p => p.Id) + 1;
            pelicula.Duracion = "1h 30m";
            pelicula.PortadaURL = "/img/film-icon.jpg";
            pelicula.FondoURL = "/img/video-loading.png";

            if (pelicula.GeneroId == 0)
                Datos.tvniños.Agregar(pelicula);
            else if (pelicula.GeneroId == 1)
                Datos.drama.Agregar(pelicula);
            else
                Datos.accionyaventuras.Agregar(pelicula);

            Datos.peliculas.Agregar(pelicula);

            return RedirectToAction("Index", "Peliculas");
        }

        // DELETE: /Peliculas/Eliminar/id
        [HttpDelete]
        public ActionResult Eliminar(int id)
        {
            var pelicula = Datos.peliculas.Single(p => p.Id == id);

            if (pelicula.GeneroId == 0)
                Datos.tvniños.Remover(pelicula);
            else if (pelicula.GeneroId == 1)
                Datos.drama.Remover(pelicula);
            else
                Datos.accionyaventuras.Remover(pelicula);

            Datos.peliculas.Remover(pelicula);

            return RedirectToAction("Index", "Peliculas");
        }

        //  /Peliculas/AgreagarMiLista/id
        public ActionResult AgregarMiLista(int id)
        {
            var pelicula = Datos.peliculas.Single(p => p.Id == id);

            Datos.miLista.Enqueue(pelicula);

            var viewModel = new ReproducirViewModel
            {
                Pelicula = pelicula,
                EstaEnMiLista = true
            };

            return RedirectToAction("Reproducir", "Peliculas", new { Id = id });
        }

        // DELETE: /Peliculas/VerDeMiLista/
        public ActionResult VerDeMiLista()
        {
            var pelicula = Datos.miLista.Dequeue();
            return RedirectToAction("Reproducir", new { Id = pelicula.Id} );
        }

        // /Peliculas/PushContinuarViendo/id
        public ActionResult PushContinuarViendo(int id)
        {
            var pelicula = Datos.peliculas.Single(p => p.Id == id);

            Datos.continuarViendo.Push(pelicula);

            var viewModel = new ReproducirViewModel
            {
                Pelicula = pelicula,
                EstaContinuarViendo = true,
            };

            return View("Reproducir", viewModel);
        }

        // DELETE: peliculas/PushContinuarViendo/
        public ActionResult PopContinuarViendo()
        {
            var peliculaPop = Datos.continuarViendo.Pop();
            return RedirectToAction("Reproducir", new { Id = peliculaPop.Id });
        }
    }
}