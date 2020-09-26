using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebWCF.Models;
using WebWCF.ServiceReference1;

namespace WebWCF.Controllers
{
    public class testController : Controller
    {

        Service1Client client = new Service1Client();
        // GET: test
        public ActionResult Index()
        {
            var lista = client.usuariosLista1();
            return View(lista);
        }
        public ActionResult Insert(int id = 0) 
        {
            testCLS testModel = new testCLS();
            using (andinoshopEntities db = new andinoshopEntities())
            {

                testModel.RolCollection = db.type_user.ToList<type_user>();
            }
         
            return View(testModel);
        }


        [HttpPost]
        public ActionResult Insert(testCLS otestCLS, testCLS test)
        {
          
            client.usuarioGuardar(0, otestCLS.name, otestCLS.phone, otestCLS.email, otestCLS.username, otestCLS.password_user, otestCLS.rol, "A");
            return RedirectToAction("Index");
        }

        public ActionResult Delete (int IdUsuario)
        {
            testCLS uTestCLS = new testCLS();
            var datos = client.usuarioDatos(IdUsuario);

            uTestCLS.user_id = datos.user_id;
            uTestCLS.name = datos.name;
            uTestCLS.phone = datos.phone;
            uTestCLS.email = datos.email;
            uTestCLS.username = datos.username;
            uTestCLS.password_user= datos.password_user;
            uTestCLS.roles = datos.rol;

            return View(uTestCLS);
        }

        [HttpPost]
        public ActionResult Delete(testCLS uTestCLS)
        {
            client.usuarioGuardar(uTestCLS.user_id, uTestCLS.name, uTestCLS.phone, uTestCLS.email, uTestCLS.username, uTestCLS.password_user, uTestCLS.rol, "D");
            return RedirectToAction("Index");
        }


    }
}