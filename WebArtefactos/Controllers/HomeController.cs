using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebArtefactos.Models;

namespace WebArtefactos.Controllers
{
    
    public class HomeController : Controller
    {
        bdArtefactoEntities1 db = new bdArtefactoEntities1();

        public ActionResult Index()
        {
            return View(db.Artefacto.ToList());
        }

        public ActionResult getClients(string codArt, int price)
        {
            ViewBag.cod = codArt;
            ViewBag.pri = price;
            return View(db.Clientes.ToList());
        }

        public ActionResult Compra(string codi, int pric)
        {
           
            return View(db.Clientes.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}