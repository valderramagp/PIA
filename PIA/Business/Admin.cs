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

        public int LogIn(Usuarios user)
        {
            var userInDb = ctx.Usuarios.FirstOrDefault(x => x.Nombre == user.Nombre && x.Contraseña == user.Contraseña);
            if (userInDb != null) return userInDb.IdUsuario;
            else return 0;
        }
    }
}