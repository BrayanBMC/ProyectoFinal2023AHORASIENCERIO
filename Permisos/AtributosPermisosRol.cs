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
        private Rol idRol;
        public AtributosPermisosRol(Rol _idrol)
        {
            idRol = _idrol;
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["usuario"] != null)
            {
                usuario usuario = HttpContext.Current.Session["usuario"] as usuario;
                if ((Rol)usuario.id_rol != this.idRol)
                {
                    filterContext.Result = new RedirectResult("~/Home/SinPermisos");
                }
            }
            base.OnActionExecuting(filterContext);
        }
    }
}
