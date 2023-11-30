using ProyectoWebFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace ProyectoWebFinal.Permisos
{
    public class AtributosPermisosRol : ActionFilterAttribute
    {
        private int idRol;

        public AtributosPermisosRol(int _idRol)
        {
            idRol = _idRol;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["usuario"] != null)
            {
                usuario usuario = HttpContext.Current.Session["usuario"] as usuario;

                if (usuario != null && usuario.id_rol != idRol)
                {
                    filterContext.Result = new RedirectResult("~/Home/SinPermisos");
                }
            }

            base.OnActionExecuting(filterContext);
        }
    }
}
