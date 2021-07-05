using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using videojuegos_api.Models;

namespace videojuegos_web.Controllers
{
    public class JuegosController : Controller
    {
        bd_videojuegos bd = new bd_videojuegos(); //CONEXION A LA BASE

        // GET: Juegos
        public ActionResult Index()
        {
            return View(bd.juegos);
        }

        // GET: Juegos/Details/5
        public ActionResult Details(int id)
        {
            juego edit_juego = bd.juegos.Find(id);
            return View(edit_juego);
        }

        // GET: Juegos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Juegos/Create
        [HttpPost]
        public ActionResult Create(juego new_juego)
        {
            try
            {
                // TODO: Add insert logic here
                bd.juegos.Add(new_juego);
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Juegos/Edit/5
        public ActionResult Edit(int id)
        {
            juego edit_juego = bd.juegos.Find(id);
            return View(edit_juego);
        }

        // POST: Juegos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, juego actualizar_juego)
        {
            try
            {
                // TODO: Add update logic here
                juego edit_juego = bd.juegos.Find(id);
                edit_juego.nombre = actualizar_juego.nombre;
                edit_juego.plataforma = actualizar_juego.plataforma;
                edit_juego.anio = actualizar_juego.anio;
                edit_juego.precio = actualizar_juego.precio;
                edit_juego.stock = actualizar_juego.stock;
                edit_juego.restriccion = actualizar_juego.restriccion;
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Juegos/Delete/5
        public ActionResult Delete(int id)
        {
            juego edit_juego = bd.juegos.Find(id);
            return View(edit_juego);
        }

        // POST: Juegos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                juego edit_juego = bd.juegos.Find(id);
                bd.juegos.Remove(edit_juego);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
