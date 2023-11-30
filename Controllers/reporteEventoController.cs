using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoWebFinal.Models;
using ProyectoWebFinal.Permisos;

namespace ProyectoWebFinal.Controllers
{
    public class reporteEventoController : Controller
    {
        proyectowebEntities bddatos = new proyectowebEntities();
        // GET: reporteEvento
        [AtributosPermisosRol((int)Rol.Administrador)]
        public ActionResult vistaEventos()
        {
            return View(bddatos.estadisticas_evento.ToList());
        }
    }
}