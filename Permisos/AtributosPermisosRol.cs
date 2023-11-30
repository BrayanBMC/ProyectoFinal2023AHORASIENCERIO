using ProyectoWebFinal.Models;
using System;
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

                if (usuario == null || usuario.id_rol != 1) // Cambiado a id_rol == 1
                {
                    filterContext.Result = new RedirectResult("~/Home/SinPermisos");
                    return; // Agregado para evitar seguir ejecutando el código si se redirige
                }
            }
            else
            {
                filterContext.Result = new RedirectResult("~/Home/SinPermisos");
                return; // Agregado para evitar seguir ejecutando el código si se redirige
            }

            base.OnActionExecuting(filterContext);
        }
    }
}

