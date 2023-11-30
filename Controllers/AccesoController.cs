using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ProyectoWebFinal.Models;

namespace ProyectoWebFinal.Controllers
{
    public class AccesoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string nombreUsuario, string clave)
        {
            usuario objeto = new Logica_usuarios().encontrarUsuarios(nombreUsuario, clave);
            if (objeto.nombre_usuario != null)
            {
                FormsAuthentication.SetAuthCookie(objeto.id_rol.ToString(), false);
                Session["usuario"] = objeto;
                return RedirectToAction("Index", "Home");
            }
            return View();
        }


    }
}
