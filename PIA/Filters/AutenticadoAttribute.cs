using PIA.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PIA.Filters
{
    public class AutenticadoAttribute : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (!SessionHelper.IsAuthenticated())
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                { controller = "Acceso", action = "Index" }));
            }
        }
    }

    public class NoLoginAttribute : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filtro)
        {

            if (SessionHelper.IsAuthenticated())
            {
                filtro.Result = new RedirectToRouteResult(
                   new RouteValueDictionary(new { controller = "Admin", action = "Index" }));
            }
        }
    }
}