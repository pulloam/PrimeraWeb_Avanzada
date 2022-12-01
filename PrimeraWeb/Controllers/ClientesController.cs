using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimeraWeb.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Buscar(string nombre, string edad, string credito)
        {
            if(nombre != null) { 
                return Content("<h1>Clientes -> " + nombre + "</h1> </hr> edad :" + edad + ", crédito : " + credito );
            }else
                return RedirectToAction("ListadoClientes");
        }


        public string ListadoClientes() {
            string htmlCreado = "";
            htmlCreado = "<ul>";
            for (int i = 0;i < 10;i++) {
                htmlCreado += "<li> Item " + i + "</li>";
            }
            htmlCreado = htmlCreado + "</ul>";
            return htmlCreado;
        }

    }

    

}