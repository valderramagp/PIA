using PIA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIA.Business
{
    public class Home
    {
        PIAEntities ctx;
        public Home()
        {
            ctx = new PIAEntities();
        }

        public List<Publicaciones> ObtenerPublicacionesRecientes()
        {
            return ObtenerPublicacionesActivas().OrderBy(x => x.Propiedades.FechaCreada).Take(3).ToList();
        }

        public Publicaciones ObtenerPublicacionPorId(int idPublicacion)
        {
            return ctx.Publicaciones.FirstOrDefault(x => x.IdPublicacion == idPublicacion);
        }

        public List<Publicaciones> ObtenerPublicacionesActivas()
        {
            return ctx.Publicaciones.Where(x => x.Status).ToList();
        }
    }
}