using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebWCF.Models;
using WebWCF.ServiceReference1;

namespace WebWCF.Controllers
{
    public class ClientController : Controller
    {
        Service1Client client = new Service1Client();
        // GET: Client
        public ActionResult Index()
        {
            var lista = client.clientesLista();
            return View(lista);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(clientCLS oclientCLS)
        {
            client.clientesGuardar(0, oclientCLS.name, oclientCLS.phone, oclientCLS.email, oclientCLS.password_client, "A");
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int IdClient)
        {
            clientCLS tClientCLS = new clientCLS();
            var datos = client.clientesDatos(IdClient);

            tClientCLS.client_id = datos.client_id;
            tClientCLS.name = datos.name;
            tClientCLS.phone = datos.phone;
            tClientCLS.email = datos.email;
            tClientCLS.password_client = datos.password_client;

            return View(tClientCLS);
        }

        [HttpPost]
        public ActionResult Delete(clientCLS tClientCLS)
        {
            client.clientesGuardar(tClientCLS.client_id, tClientCLS.name, tClientCLS.phone, tClientCLS.email, tClientCLS.password_client ,"D");
            return RedirectToAction("Index");
        }

    }
}