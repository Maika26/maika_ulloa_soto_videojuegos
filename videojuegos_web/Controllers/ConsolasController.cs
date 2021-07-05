using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using videojuegos_api.Models;

namespace videojuegos_web.Controllers
{
    public class ConsolasController : Controller
    {
        bd_videojuegos bd = new bd_videojuegos(); //CONEXION A LA BASE

        // GET: Consolas
        public ActionResult Index()
        {
            return View(bd.consolas);
        }

        // GET: Consolas/Details/5
        public ActionResult Details(int id)
        {
            consola edit_consola = bd.consolas.Find(id);
            return View(edit_consola);
        }

        // GET: Consolas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Consolas/Create
        [HttpPost]
        public ActionResult Create(consola new_consola)
        {
            try
            {
                // TODO: Add insert logic here
                bd.consolas.Add(new_consola);
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Consolas/Edit/5
        public ActionResult Edit(int id)
        {
            consola edit_consola = bd.consolas.Find(id);
            return View(edit_consola);
        }

        // POST: Consolas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, consola actualizar_consola)
        {
            try
            {
                // TODO: Add update logic here
                consola edit_consola = bd.consolas.Find(id);
                edit_consola.marca = actualizar_consola.marca;
                edit_consola.modelo = actualizar_consola.modelo;
                edit_consola.anio = actualizar_consola.anio;
                edit_consola.nueva = actualizar_consola.nueva;
                edit_consola.precio = actualizar_consola.precio;
                edit_consola.stock = actualizar_consola.stock;
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Consolas/Delete/5
        public ActionResult Delete(int id)
        {
            consola edit_consola = bd.consolas.Find(id);
            return View(edit_consola);
        }

        // POST: Consolas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                consola edit_consola = bd.consolas.Find(id);
                bd.consolas.Remove(edit_consola);
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
