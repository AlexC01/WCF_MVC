using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebWCF.Models
{
    public class clientCLS
    {
        public int client_id {get; set;}

        [Display(Name = "Nombre")]
        public string name { get; set; }

        [Display(Name = "Telefono")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "Password")]
        public string password_client { get; set; }
    }
}