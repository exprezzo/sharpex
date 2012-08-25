using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Sharpex.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Ext()
        {
            return View();
        }



        public JsonResult listar()
        {
         
            List<Dictionary<string, object>> datos= new List<Dictionary<string, object>>();
            Dictionary<string, object> elemento = new Dictionary<string, object>();

            for (int i = 1; i < 15; i++ )
            {
                elemento = new Dictionary<string, object>();
                elemento["nombre"] = "Elemento Numero " + i;
                elemento["id"] = i;
                datos.Add(elemento);
            }        

            Dictionary<string, object> resultado= new Dictionary<string, object>();
            resultado["success"] = true;
            resultado["msg"] = "Datos servidos y alborotados";
            resultado["datos"] = datos;
            return this.Json(resultado);
            }
        }
    }
