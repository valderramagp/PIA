using PIA.Business;
using System.Web.Mvc;

namespace PIA.Controllers
{
    public class HomeController : Controller
    {
        private Home ctx;

        public HomeController()
        {
            ctx = new Home();   
        }
        // GET: Home
        public ActionResult Index()
        {
            var model = ctx.ObtenerPublicacionesRecientes();
            return View(model);
        }

        public ActionResult Propiedades()
        {
            var list = ctx.ObtenerPublicacionesActivas();
            return View(list);
        }

        public ActionResult Detalle(int id = 0)
        {
            var model = ctx.ObtenerPublicacionPorId(id);
            if (model == null)
                return RedirectToAction("Index");
            return View(model);
        }
    }
}