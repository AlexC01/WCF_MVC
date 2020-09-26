using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        andinoshopEntities db = new andinoshopEntities();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public List<Clientes_Result4> clientesLista()
        {
            return db.Clientes_Result4().ToList();
        }

        public ClienteGuardar_Result3 clientesGuardar(int Id, string nombre, string telefono, string email, string password, string validate)
        {
            return db.ClienteGuardar_Result3(Id, nombre, telefono, email, password, validate).FirstOrDefault();
        }

        public List<Productos_Result2> productosLista()
        {
            return db.Productos_Result2().ToList();
        }

        public List<Usuario_Result1> usuariosLista1()
        {
            return db.Usuario_Result1().ToList();
        }

        public UsuarioGuardar_Result3 usuarioGuardar(int Id, string nombre, string telefono, string email, string username, string password, int rol, string validate)
        {
            return db.UsuarioGuardar_Result3(Id, nombre, telefono, email, username, password, rol, validate).FirstOrDefault();
        }

        public ProductGuardar_Result1 productGuardar(int Id, string nombre, int brand, string description, int category, string validate)
        {
            return db.ProductGuardar_Result1(Id, nombre, brand, description, category, validate).FirstOrDefault();
        }

        public Usuario_Result1 usuarioDatos(int IdUsuario)
        {
            return (from u in db.Usuario_Result1() where u.user_id.Equals(IdUsuario) select u).FirstOrDefault();
        }

        public Productos_Result2 productDatos (int IdProduct)
        {
            return (from p in db.Productos_Result2() where p.product_id.Equals(IdProduct) select p).FirstOrDefault();
        }

        public Clientes_Result4 clientesDatos (int IdClient)
        {
            return (from c in db.Clientes_Result4() where c.client_id.Equals(IdClient) select c).FirstOrDefault();
        }

 
    }
}
