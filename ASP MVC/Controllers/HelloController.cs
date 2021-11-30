using ASP_MVC.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ASP_MVC.Controllers
{
    public class HelloController : Controller
    {
        public static List<string> lst = new List<string>();

        // GET: Hello
        public ActionResult Index()
        {
            Visiteur visiteur = new Visiteur();
            return View(visiteur);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(Visiteur client)
        {
            Visiteur visiteur = new Visiteur();
            string nom = Request.Form["nom_visiteur"];
            visiteur.nom = nom;
            //ViewData["message"] = "Hello World " + visiteur.nom;
            ViewData["message"] = DB_Visiteur.openConnection();
            Visiteur.lst.Add(visiteur);
            return View("Index", visiteur);
        }
    }
}