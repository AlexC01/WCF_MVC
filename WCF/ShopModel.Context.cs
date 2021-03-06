﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class andinoshopEntities : DbContext
    {
        public andinoshopEntities()
            : base("name=andinoshopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<Usuario_Result1> Usuario_Result1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Usuario_Result1>("Usuario_Result1");
        }
    
        public virtual ObjectResult<ProductGuardar_Result> ProductGuardar(Nullable<int> product_id, string name, Nullable<int> brand_id, string description, Nullable<int> category_id, string validate)
        {
            var product_idParameter = product_id.HasValue ?
                new ObjectParameter("product_id", product_id) :
                new ObjectParameter("product_id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var brand_idParameter = brand_id.HasValue ?
                new ObjectParameter("brand_id", brand_id) :
                new ObjectParameter("brand_id", typeof(int));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("description", description) :
                new ObjectParameter("description", typeof(string));
    
            var category_idParameter = category_id.HasValue ?
                new ObjectParameter("category_id", category_id) :
                new ObjectParameter("category_id", typeof(int));
    
            var validateParameter = validate != null ?
                new ObjectParameter("Validate", validate) :
                new ObjectParameter("Validate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProductGuardar_Result>("ProductGuardar", product_idParameter, nameParameter, brand_idParameter, descriptionParameter, category_idParameter, validateParameter);
        }
    
        public virtual ObjectResult<ProductGuardar_Result1> ProductGuardar_Result1(Nullable<int> product_id, string name, Nullable<int> brand_id, string description, Nullable<int> category_id, string validate)
        {
            var product_idParameter = product_id.HasValue ?
                new ObjectParameter("product_id", product_id) :
                new ObjectParameter("product_id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var brand_idParameter = brand_id.HasValue ?
                new ObjectParameter("brand_id", brand_id) :
                new ObjectParameter("brand_id", typeof(int));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("description", description) :
                new ObjectParameter("description", typeof(string));
    
            var category_idParameter = category_id.HasValue ?
                new ObjectParameter("category_id", category_id) :
                new ObjectParameter("category_id", typeof(int));
    
            var validateParameter = validate != null ?
                new ObjectParameter("Validate", validate) :
                new ObjectParameter("Validate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProductGuardar_Result1>("ProductGuardar_Result1", product_idParameter, nameParameter, brand_idParameter, descriptionParameter, category_idParameter, validateParameter);
        }
    
        public virtual ObjectResult<Productos_Result1> Productos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Productos_Result1>("Productos");
        }
    
        public virtual ObjectResult<Productos_Result2> Productos_Result2()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Productos_Result2>("Productos_Result2");
        }
    
        public virtual ObjectResult<Clientes_Result3> Clientes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Clientes_Result3>("Clientes");
        }
    
        public virtual ObjectResult<Clientes_Result4> Clientes_Result4()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Clientes_Result4>("Clientes_Result4");
        }
    
        public virtual ObjectResult<ClienteGuardar_Result2> ClienteGuardar(Nullable<int> client_id, string name, string phone, string email, string password_client, string validate)
        {
            var client_idParameter = client_id.HasValue ?
                new ObjectParameter("client_id", client_id) :
                new ObjectParameter("client_id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var password_clientParameter = password_client != null ?
                new ObjectParameter("password_client", password_client) :
                new ObjectParameter("password_client", typeof(string));
    
            var validateParameter = validate != null ?
                new ObjectParameter("Validate", validate) :
                new ObjectParameter("Validate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ClienteGuardar_Result2>("ClienteGuardar", client_idParameter, nameParameter, phoneParameter, emailParameter, password_clientParameter, validateParameter);
        }
    
        public virtual ObjectResult<UsuarioGuardar_Result2> UsuarioGuardar(Nullable<int> user_id, string name, string phone, string email, string username, string password_user, Nullable<int> type_user_id, string validate)
        {
            var user_idParameter = user_id.HasValue ?
                new ObjectParameter("user_id", user_id) :
                new ObjectParameter("user_id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var password_userParameter = password_user != null ?
                new ObjectParameter("password_user", password_user) :
                new ObjectParameter("password_user", typeof(string));
    
            var type_user_idParameter = type_user_id.HasValue ?
                new ObjectParameter("type_user_id", type_user_id) :
                new ObjectParameter("type_user_id", typeof(int));
    
            var validateParameter = validate != null ?
                new ObjectParameter("Validate", validate) :
                new ObjectParameter("Validate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UsuarioGuardar_Result2>("UsuarioGuardar", user_idParameter, nameParameter, phoneParameter, emailParameter, usernameParameter, password_userParameter, type_user_idParameter, validateParameter);
        }
    
        public virtual ObjectResult<ClienteGuardar_Result3> ClienteGuardar_Result3(Nullable<int> client_id, string name, string phone, string email, string password_client, string validate)
        {
            var client_idParameter = client_id.HasValue ?
                new ObjectParameter("client_id", client_id) :
                new ObjectParameter("client_id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var password_clientParameter = password_client != null ?
                new ObjectParameter("password_client", password_client) :
                new ObjectParameter("password_client", typeof(string));
    
            var validateParameter = validate != null ?
                new ObjectParameter("Validate", validate) :
                new ObjectParameter("Validate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ClienteGuardar_Result3>("ClienteGuardar_Result3", client_idParameter, nameParameter, phoneParameter, emailParameter, password_clientParameter, validateParameter);
        }
    
        public virtual ObjectResult<UsuarioGuardar_Result3> UsuarioGuardar_Result3(Nullable<int> user_id, string name, string phone, string email, string username, string password_user, Nullable<int> type_user_id, string validate)
        {
            var user_idParameter = user_id.HasValue ?
                new ObjectParameter("user_id", user_id) :
                new ObjectParameter("user_id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var password_userParameter = password_user != null ?
                new ObjectParameter("password_user", password_user) :
                new ObjectParameter("password_user", typeof(string));
    
            var type_user_idParameter = type_user_id.HasValue ?
                new ObjectParameter("type_user_id", type_user_id) :
                new ObjectParameter("type_user_id", typeof(int));
    
            var validateParameter = validate != null ?
                new ObjectParameter("Validate", validate) :
                new ObjectParameter("Validate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UsuarioGuardar_Result3>("UsuarioGuardar_Result3", user_idParameter, nameParameter, phoneParameter, emailParameter, usernameParameter, password_userParameter, type_user_idParameter, validateParameter);
        }
    }
}
