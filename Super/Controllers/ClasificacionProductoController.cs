using Super.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Super.Controllers
{
    public class ClasificacionProductoController : Controller
    {
        private TiendaContext context;
        public ClasificacionProductoController()
        {
            context = new TiendaContext();
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            context.Dispose();
        }
        public ActionResult Index()
        {
            // mostrar todos los registros de las clasificaciones
            var producto = context.clasificacionProductos.ToList();
            return View(producto);
        }
    }
}