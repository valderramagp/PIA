using PIA.Business;
using PIA.Entities;
using PIA.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PIA.Controllers
{
    public class AccesoController : Controller
    { 
        [NoLogin]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [NoLogin]
        public JsonResult LogIn(Usuarios usuario)
        {
            Admin ctx = new Admin();
            usuario.IdUsuario = ctx.LogIn(usuario);
            if (usuario.IdUsuario > 0)
            {
                SessionHelper.SignIn(usuario.Nombre, usuario.IdUsuario.ToString());
                return Json(new { acceso = true });
            }
            else
                return Json(new { acceso = false });

        }

        public ActionResult LogOut()
        {
            SessionHelper.SignOut();
            return RedirectToAction("Index");
        }
    }
}