using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Sharpex.Models;

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
            MARPAC_CorporativaEntities corp = new MARPAC_CorporativaEntities();
            List<Dictionary<string, object>> datos= new List<Dictionary<string, object>>();
            //Dictionary<string, object> elemento = new Dictionary<string, object>();

            var a = corp.RegimenesFiscales.ToList();
            foreach (var item in a)
            {
                Dictionary<string, object> elemento = new Dictionary<string, object>();
                elemento["CodigoRegimen"] = item.CodigoRegimen;
                elemento["NombreRegimen"] = item.NombreRegimen;
                elemento["PideCURP"] = item.PideCURP;
                elemento["Activo"] = item.Activo;
                datos.Add(elemento);
            }
            
            /*for (int i = 1; i < 15; i++ )
            {
                elemento = new Dictionary<string, object>();
                elemento["nombre"] = "Elemento Numero " + i;
                elemento["id"] = i;
                datos.Add(elemento);
            }*/
            Dictionary<string, object> resultado= new Dictionary<string, object>();
            resultado["success"] = true;
            resultado["msg"] = "Datos servidos y alborotados";
            resultado["datos"] = datos;
            return this.Json(resultado);
        }

        
         public JsonResult obtener(int codigoRegimen)
         {
            MARPAC_CorporativaEntities corp = new MARPAC_CorporativaEntities();
            Dictionary<string, object> elemento = new Dictionary<string, object>();
            elemento = new Dictionary<string, object>();
            Dictionary<string, object> data = new Dictionary<string, object>();
            var regimen = corp.RegimenesFiscales.SingleOrDefault(a => a.CodigoRegimen == codigoRegimen);
            data["CodigoRegimen"] = regimen.CodigoRegimen;
            data["NombreRegimen"] = regimen.NombreRegimen;
            data["PideCURP"] = regimen.PideCURP;
            data["Activo"] = regimen.Activo;
            
            elemento["success"] = true;
            elemento["data"] = data;
            // elemento["nombre"] = "Elemento Numero 1";
            //elemento["id"] = 1;
            

            return this.Json(elemento);
         }

         public JsonResult guardar(int codigoRegimen,string NombreRegimen,string PideCURP,string Activo)
         {
             MARPAC_CorporativaEntities corp = new MARPAC_CorporativaEntities();
             Dictionary<string, object> elemento = new Dictionary<string, object>();
             elemento = new Dictionary<string, object>();
             Dictionary<string, object> data = new Dictionary<string, object>();
             RegimenesFiscale regimen = corp.RegimenesFiscales.SingleOrDefault(a => a.CodigoRegimen == codigoRegimen);
             regimen.CodigoRegimen = codigoRegimen;
             regimen.NombreRegimen = NombreRegimen;
             regimen.PideCURP = PideCURP;
             regimen.Activo = Activo;
             corp.SaveChanges();
             
             
             
             elemento["success"] = true;
             //elemento["data"] = data;
             // elemento["nombre"] = "Elemento Numero 1";
             //elemento["id"] = 1;


             return this.Json(elemento);
         }

   }
}
