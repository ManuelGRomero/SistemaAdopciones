using SistemaAdopciones.Models;
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
    }
}