using PIA.Business;
using PIA.Entities;
using PIA.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace PIA.Controllers
{
    [Autenticado]
    public class AdminController : Controller
    {
       
        public ActionResult Index()
        {
            Admin a = new Admin();
            var model = a.ObtenerPublicaciones();
            return View(model);
        }

        public ActionResult New()
        {
            return View();
        }

        public PartialViewResult PropiedadForm()
        {
            Catalogos c = new Catalogos();
            var tiposInmueble = c.ObtenerTiposInmueble();
            ViewBag.TiposInmueble = tiposInmueble;
            return PartialView();
        }

        [HttpPost]
        public JsonResult GuardarPropiedad(Propiedades propiedad)
        {
            propiedad.FechaCreada = DateTime.Now;
            propiedad.FechaActualizada = DateTime.Now;
            Admin a = new Admin();
            var result = a.AgregarPropiedad(propiedad);
            return Json(propiedad.IdPropiedad);
        }

        public PartialViewResult PublicacionForm()
        {
            Catalogos c = new Catalogos();
            ViewBag.Operaciones = c.ObtenerOperaciones();
            return PartialView();
        }

        [HttpPost]
        public JsonResult GuardarPublicacion(Publicaciones publicacion)
        {
            Admin a = new Admin();
            var result = a.AgregarPublicacion(publicacion);
            return Json(publicacion.IdPublicacion);
        }

        public PartialViewResult UbicacionForm()
        {
            Catalogos c = new Catalogos();
            ViewBag.Estados = c.ObtenerEstados();
            return PartialView();
        }

        
    }
}