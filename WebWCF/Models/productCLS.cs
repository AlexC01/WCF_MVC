using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebWCF.Models
{
    public class productCLS
    {
        public int product_id { get; set; }
        [Display(Name = "Nombre")]
        public string name { get; set; }

        [Display(Name = "Marca")]
        public int brand { get; set; }

        public string name_brand { get; set; }

        [Display(Name = "Descripcion")]
        public string description { get; set; }

        [Display(Name = "Categoria")]
        public int category { get; set; }

        public string name_category { get; set; }
   

        [NotMapped]
        public List<category> CategoryCollection { get; set; }

        [NotMapped]
        public List<brand> BrandCollection { get; set; }

    }
}