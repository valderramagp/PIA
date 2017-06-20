using PIA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIA.Business
{
    public class Admin
    {
        PIAEntities ctx;
        public Admin()
        {
            ctx = new PIAEntities();
        }

        public List<Publicaciones> ObtenerPublicaciones()
        {
            return ctx.Publicaciones.ToList();
        }

        public bool AgregarPropiedad(Propiedades propiedad)
        {
            ctx.Propiedades.Add(propiedad);
            var result = ctx.SaveChanges();
            return result > 0;
        }

        public bool AgregarPublicacion(Publicaciones publicacion)
        {
            ctx.Publicaciones.Add(publicacion);
            var result = ctx.SaveChanges();
            return result > 0;
        }

        public int LogIn(Usuarios user)
        {
            var userInDb = ctx.Usuarios.FirstOrDefault(x => x.Nombre == user.Nombre && x.Contrasenia == user.Contrasenia);
            if (userInDb != null) return userInDb.IdUsuario;
            else return 0;
        }
    }
}