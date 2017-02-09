using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PIA.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Propiedades()
        {
            return View();
        }

        public ActionResult Detalle(int id = 0)
        {
            return View();
        }
    }
}