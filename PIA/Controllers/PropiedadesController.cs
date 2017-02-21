using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PIA.Entities;

namespace PIA.Controllers
{
    public class PropiedadesController : Controller
    {
        private PIAEntities db = new PIAEntities();

        // GET: Propiedades
        public async Task<ActionResult> Index()
        {
            var propiedades = db.Propiedades.Include(p => p.TiposInmueble).Include(p => p.Ubicaciones);
            return View(await propiedades.ToListAsync());
        }

        // GET: Propiedades/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Propiedades propiedades = await db.Propiedades.FindAsync(id);
            if (propiedades == null)
            {
                return HttpNotFound();
            }
            return View(propiedades);
        }

        // GET: Propiedades/Create
        public ActionResult Create()
        {
            ViewBag.IdTipoInmueble = new SelectList(db.TiposInmueble, "IdTipoInmueble", "Descripcion");
            ViewBag.IdPropiedad = new SelectList(db.Ubicaciones, "IdPropiedad", "Calle");
            return View();
        }

        // POST: Propiedades/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "IdPropiedad,IdTipoInmueble,FechaCreada,FechaActualizada")] Propiedades propiedades)
        {
            if (ModelState.IsValid)
            {
                db.Propiedades.Add(propiedades);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.IdTipoInmueble = new SelectList(db.TiposInmueble, "IdTipoInmueble", "Descripcion", propiedades.IdTipoInmueble);
            ViewBag.IdPropiedad = new SelectList(db.Ubicaciones, "IdPropiedad", "Calle", propiedades.IdPropiedad);
            return View(propiedades);
        }

        // GET: Propiedades/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Propiedades propiedades = await db.Propiedades.FindAsync(id);
            if (propiedades == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdTipoInmueble = new SelectList(db.TiposInmueble, "IdTipoInmueble", "Descripcion", propiedades.IdTipoInmueble);
            ViewBag.IdPropiedad = new SelectList(db.Ubicaciones, "IdPropiedad", "Calle", propiedades.IdPropiedad);
            return View(propiedades);
        }

        // POST: Propiedades/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "IdPropiedad,IdTipoInmueble,FechaCreada,FechaActualizada")] Propiedades propiedades)
        {
            if (ModelState.IsValid)
            {
                db.Entry(propiedades).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.IdTipoInmueble = new SelectList(db.TiposInmueble, "IdTipoInmueble", "Descripcion", propiedades.IdTipoInmueble);
            ViewBag.IdPropiedad = new SelectList(db.Ubicaciones, "IdPropiedad", "Calle", propiedades.IdPropiedad);
            return View(propiedades);
        }

        // GET: Propiedades/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Propiedades propiedades = await db.Propiedades.FindAsync(id);
            if (propiedades == null)
            {
                return HttpNotFound();
            }
            return View(propiedades);
        }

        // POST: Propiedades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Propiedades propiedades = await db.Propiedades.FindAsync(id);
            db.Propiedades.Remove(propiedades);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
