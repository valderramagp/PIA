using PIA.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PIA.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            Admin a = new Admin();
            var model = a.ObtenerPublicaciones();
            return View(model);
        }

        public ActionResult Detail()
        {
            return View();
        }

        public ActionResult New()
        {
            var catalogosCtx = new Catalogos();
            ViewBag.TiposInmueble = catalogosCtx.ObtenerTiposInmueble();
            ViewBag.Operaciones = catalogosCtx.ObtenerOperaciones();
            ViewBag.Estados = catalogosCtx.ObtenerEstados();
            ViewBag.Caracteristicas = catalogosCtx.ObtenerCaracteristicas();
            return View();
        }
    }
}