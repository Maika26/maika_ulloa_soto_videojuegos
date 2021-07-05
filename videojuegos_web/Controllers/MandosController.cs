using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using videojuegos_api.Models;

namespace videojuegos_web.Controllers
{
    public class MandosController : Controller
    {
        bd_videojuegos bd = new bd_videojuegos(); //CONEXION A LA BASE
        // GET: Mandos
        public ActionResult Index()
        {
            //AL LLAMAR A LA VISTA DEBEMOS ENTREGAR LOS MANDOS
            return View(bd.mandos);
        }

        // GET: Mandos/Details/5
        public ActionResult Details(int id)
        {
            mando edit_mando = bd.mandos.Find(id);
            return View(edit_mando);
        }

        // GET: Mandos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mandos/Create
        [HttpPost]
        public ActionResult Create(mando new_mando) //CODIGO A EJECUTAR AL PRESIONAR EL BOTON CREAR
        {
            try
            {
                // TODO: Add insert logic here
                bd.mandos.Add(new_mando);
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mandos/Edit/5
        public ActionResult Edit(int id)
        {
            mando edit_mando = bd.mandos.Find(id);
            return View(edit_mando);
        }

        // POST: Mandos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, mando actualizar_mando) //CODIGO A EJECUTAR AL PRESIONAR EL BOTON CREAR
        {
            try
            {
                // TODO: Add update logic here
                mando edit_mando = bd.mandos.Find(id);
                edit_mando.marca = actualizar_mando.marca;
                edit_mando.modelo = actualizar_mando.modelo;
                edit_mando.compatibilidad = actualizar_mando.compatibilidad;
                edit_mando.precio = actualizar_mando.precio;
                edit_mando.stock = actualizar_mando.stock;
                bd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mandos/Delete/5
        public ActionResult Delete(int id)
        {
            mando edit_mando = bd.mandos.Find(id);
            return View(edit_mando);
        }

        // POST: Mandos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection) //CODIGO A EJECUTAR AL PRESIONAR EL BOTON CREAR
        {
            try
            {
                // TODO: Add delete logic here
                mando edit_mando = bd.mandos.Find(id);
                bd.mandos.Remove(edit_mando);
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
