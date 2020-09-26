using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebWCF.Models;
using WebWCF.ServiceReference1;

namespace WebWCF.Controllers
{
    public class ProductController : Controller
    {
        Service1Client client = new Service1Client();
        // GET: Product
        public ActionResult Index()
        {
            var lista = client.productosLista();
            return View(lista);
        }
        public ActionResult Insert(int id = 0)
        {
            productCLS productModel = new productCLS();
            using (andinoshopEntities db = new andinoshopEntities())
            {

                productModel.CategoryCollection = db.category.ToList<category>();
                productModel.BrandCollection = db.brand.ToList<brand>();
            }

            return View(productModel);
        }


        [HttpPost]
        public ActionResult Insert(productCLS oproductCLS, productCLS product)
        {

            client.productGuardar(0, oproductCLS.name, oproductCLS.brand, oproductCLS.description, oproductCLS.category, "A");
            return RedirectToAction("Index");
        }



        public ActionResult Delete(int IdProduct)
        {
            productCLS tProductCLS = new productCLS();
            var datos = client.productDatos(IdProduct);

            tProductCLS.product_id = datos.product_id;
            tProductCLS.name = datos.name;
            tProductCLS.name_brand = datos.name_brand;
            tProductCLS.description = datos.description;
            tProductCLS.name_category = datos.name_category;

            return View(tProductCLS);
        }

        [HttpPost]
        public ActionResult Delete(productCLS tProductCLS)
        {
            client.productGuardar(tProductCLS.product_id, tProductCLS.name, tProductCLS.brand, tProductCLS.description, tProductCLS.category, "D");
            return RedirectToAction("Index");
        }
    }
}