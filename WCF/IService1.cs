using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        List<Clientes_Result4> clientesLista();

        [OperationContract]
        ClienteGuardar_Result3 clientesGuardar(int Id, string nombre, string telefono, string email, string password, string validate);

        [OperationContract]
        List<Productos_Result2> productosLista();

        [OperationContract]
        List<Usuario_Result1> usuariosLista1();

        [OperationContract]
        UsuarioGuardar_Result3 usuarioGuardar(int Id, string nombre, string telefono, string email, string username, string password, int rol, string validate);

        [OperationContract]
        ProductGuardar_Result1 productGuardar(int Id, string nombre, int brand, string description, int category, string validate);

        [OperationContract]
        Usuario_Result1 usuarioDatos(int IdUsuario);

        [OperationContract]
        Productos_Result2 productDatos(int IdProduct);

        [OperationContract]
        Clientes_Result4 clientesDatos(int IdClient);


    }


}
