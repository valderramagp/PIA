using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace PIA.Business
{
    public class SessionHelper
    {
        public static void SignIn(string nombreUsuario, string idUsuario)
        {
            var cookieUsuario = FormsAuthentication.GetAuthCookie(nombreUsuario, true);
            cookieUsuario.Name = FormsAuthentication.FormsCookieName;
            cookieUsuario.Expires = DateTime.Now.AddDays(7);
            var ticket = FormsAuthentication.Decrypt(cookieUsuario.Value);
            var nuevoTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, ticket.IssueDate, ticket.Expiration, ticket.IsPersistent, idUsuario);
            cookieUsuario.Value = FormsAuthentication.Encrypt(nuevoTicket);
            HttpContext.Current.Response.Cookies.Add(cookieUsuario);
        }

        public static void SignOut()
        {
            FormsAuthentication.SignOut();
        }

        public static bool IsAuthenticated()
        {
            return HttpContext.Current.User.Identity.IsAuthenticated;
        }
    }
}