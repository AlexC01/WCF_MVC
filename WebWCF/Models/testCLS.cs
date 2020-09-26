using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using WebWCF.Models;


namespace WebWCF.Models
{

    public class testCLS
    {
        public int user_id { get; set; }

        [Display(Name = "Nombre")]
        public string name { get; set; }

        [Display(Name = "Telefono")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "Username")]
        public string username { get; set; }

        [Display(Name = "Password")]
        public string password_user { get; set; }

        [Display(Name = "Rol de Usuario")]
        public int rol { get; set; }

        public string roles { get; set; }

        [NotMapped]
        public List<type_user> RolCollection { get; set; }


    }
}