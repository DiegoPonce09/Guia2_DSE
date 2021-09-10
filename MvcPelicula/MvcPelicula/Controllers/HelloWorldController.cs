using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPelicula.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        //
        //Get HelloWorld/Welcome
        public ActionResult Welcome(string nombre, string apellido, int numVeces = 1)
        {
            ViewBag.Mensaje = "Hola " + nombre + " " + apellido + ", veces mostrado: " + numVeces;
            ViewBag.NumVeces = numVeces;
            return View();
        }
    }
}