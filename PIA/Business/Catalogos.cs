using PIA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIA.Business
{
    public class Catalogos
    {
        PIAEntities ctx;
        public Catalogos()
        {
            ctx = new PIAEntities();
        }

        public List<TiposInmueble> ObtenerTiposInmueble()
        {
            return ctx.TiposInmueble.ToList();
        }

        public List<Operaciones> ObtenerOperaciones()
        {
            return ctx.Operaciones.ToList();
        }

        public List<Estados> ObtenerEstados()
        {
            return ctx.Estados.ToList();
        }

        public List<Caracteristicas> ObtenerCaracteristicas()
        {
            return ctx.Caracteristicas.ToList();
        }
    }
}