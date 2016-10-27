using SistemaAdopciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaAdopciones.Controllers
{
    public class MascotasController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        // GET: Mascotas
        public ActionResult Lista()
        {
            var AllMascotas = db.mascotas.ToList();

            return View(AllMascotas);
        }
        [HttpGet]
        public ActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Crear(Mascotas nuevaMascota)
        {
            if (ModelState.IsValid)
            {
                db.mascotas.Add(nuevaMascota);

                db.SaveChanges();

                return RedirectToAction("Lista");
            }
            ViewBag.MensajeError = "Hubo un Error, Revise los Datos";
            return View();
        }
    }
}