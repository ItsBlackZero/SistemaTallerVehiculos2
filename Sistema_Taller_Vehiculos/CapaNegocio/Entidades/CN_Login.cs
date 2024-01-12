using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Interface;
using CapaDatos.Entidades;
using CapaDatos.SqlExecute;
namespace CapaNegocio.Entidades
{
    public class CN_Login
    {
        private string user;
        private string password;
        private string nombre;
        private string email;

        private InterfaceNegocio obj_interface_login = new InterfaceNegocio();
        public int Login ( CN_Login login)
        {
            try
            {
                List<CD_ParameterSP> lista_parametro = new List<CD_ParameterSP>();
                lista_parametro.Add(new CD_ParameterSP("@usuario", login.user, System.Data.SqlDbType.Text));
                lista_parametro.Add(new CD_ParameterSP("@pass", login.password, System.Data.SqlDbType.Text));
                return obj_interface_login.Login(lista_parametro);

            }
            catch (Exception ex)
            {
                throw new Exception("Usuario o Password Incorrectos" + ex.Message);
            }
            
        }
        
        public bool crearUsuario(CN_Login usuario)
        {
            try
            {
                List<CD_ParameterSP> lista = new List<CD_ParameterSP>();
                lista.Add(new CD_ParameterSP("@nombre",usuario.nombre,System.Data.SqlDbType.Text));
                lista.Add(new CD_ParameterSP("@usuario",usuario.user,System.Data.SqlDbType.Text));
                lista.Add(new CD_ParameterSP("@pass",usuario.password,System.Data.SqlDbType.Text));
                lista.Add(new CD_ParameterSP("@correo",usuario.email,System.Data.SqlDbType.Text));
                return obj_interface_login.crearUsuario(lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el registro del usuario"+ex.Message);
            }
        }

        public string recoverPassword(string userRequest)
        {
            return obj_interface_login.recoverPassword(userRequest);
        }
        
        public string User { get { return user; } set {  user = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Email { get { return email; }set { email = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        
    }
}
