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
            return View();
        }

        public PartialViewResult FormPropiedades()
        {
            var catalogosCtx = new Catalogos();
            ViewBag.TiposInmueble = catalogosCtx.ObtenerTiposInmueble();
            return PartialView();
        }

        public PartialViewResult FormCaracteristicas()
        {
            var catalogosCtx = new Catalogos();
            ViewBag.Caracteristicas = catalogosCtx.ObtenerCaracteristicas();
            return PartialView();
        }

        public PartialViewResult FormUbicacion()
        {
            var catalogosCtx = new Catalogos();
            ViewBag.Estados = catalogosCtx.ObtenerEstados();
            return PartialView();
        }

        public PartialViewResult FormPublicaciones()
        {
            var catalogosCtx = new Catalogos();
            ViewBag.Operaciones = catalogosCtx.ObtenerOperaciones();
            return PartialView();
        }
    }
}