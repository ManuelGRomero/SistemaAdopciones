﻿using SistemaAdopciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaAdopciones.Controllers
{
    public class DueñosController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        // GET: Dueños
        public ActionResult Lista()
        {

            var AllDueños = db.dueños.ToList();


            return View(AllDueños);
        }
        [HttpGet]
        public ActionResult Crear()
        {
            var mascotas = db.mascotas;

            SelectList MascotaID = new SelectList(mascotas, "MascotaID", "nombre");

            ViewBag.MascotaID = MascotaID;

            return View();
        }
        [HttpPost]
        public ActionResult Crear(Dueños nuevoDueño)
        {
            if (ModelState.IsValid)
            {
                db.dueños.Add(nuevoDueño);

                db.SaveChanges();

                return RedirectToAction("Lista");
            }
            ViewBag.MensajeError = "Hubo un error, Verifique bien los datos";

                return View();
        }
    }
}