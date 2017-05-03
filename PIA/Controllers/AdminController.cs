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
        
    }
}