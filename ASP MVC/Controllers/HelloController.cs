using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_MVC.Models;

namespace ASP_MVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index() {
            Visiteur visiteur = new Visiteur();
            return View(visiteur);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(Visiteur client)
        {
            Visiteur visiteur = new Visiteur();
            string nom = "";
            nom = Request.Form["nom_visiteur"];
            visiteur.nom = nom;
            ViewData["message"] = "Hello World " + visiteur.nom;
            return View("Index", visiteur);
        }
    }
}