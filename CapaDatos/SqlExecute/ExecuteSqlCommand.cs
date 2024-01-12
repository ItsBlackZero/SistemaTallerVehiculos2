using CapaDatos.ConexionDB;
using CapaDatos.Entidades;
using CapaDatos.Recuperacion;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos.SqlExecute
{
    public class ExecuteSqlCommand
    {
        private ConexionDataB conn = new ConexionDataB();


        

        public int ExecuteLogin(string nombre_SP, List<CD_ParameterSP> lista)
        {
            using (SqlConnection conn = new SqlConnection("server=DESKTOP-KEAFE1A; database=TALLER_VEHICULOS; Integrated Security=true"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = nombre_SP;

                    if (lista != null)
                    {
                        foreach (var parametro in lista)
                            cmd.Parameters.Add(parametro.NombreParametro, parametro.TipoDato).Value = parametro.ValorParametro;
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetInt32(0);
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    

                }
            }
            
        }
        public string recoverPassword(string user)
        {
            using (var connexion= conn.GetConnection())
            {
                connexion.Open();
                using(var command = new SqlCommand())
                {
                    command.Connection = connexion;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "SP_GET_USUARIO2";
                    command.Parameters.AddWithValue("@usuario", user);
                    
                    SqlDataReader reader = command.ExecuteReader();

                    if(reader.Read()==true )
                    {
                        string userName = reader.GetString(1);
                        string usermail = reader.GetString(4);
                        string password = reader.GetString(3);

                        var mailService = new SystemSupportMail();
                        mailService.sendMail(
                            subject: "SYSTEM: Recuperacion de Password",
                            body: " Hola, " + userName + "\nsolicitaste una recuperacion de password\n" + 
                            "tu password actual es: " + password +
                            "\n Porfavor, Cuando ingreses al sistema cambia tu password",
                            recipientMail:new List<string> { usermail }
                            );
                        return " Hola, " + userName + "\nsolicitaste una recuperacion de password\n" +
                            "Por favor revisa tu correo: " + usermail +
                            "\n Porfavor, Cuando ingreses al sistema cambia tu password";

                    }
                    else
                    {
                        return "Lo siento , no existe una cuenta registrada con ese correo electronico";
                    }

                }

            }
        }

        public bool ExecuteSpNonQuery(string nombre_sp, List<CD_ParameterSP> lista_parametros)
        {
            var comando = new SqlCommand();
            comando.Connection = conn.AbrirConexion(); //asigno conexion
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombre_sp;
            if (lista_parametros.Count > 0)
            {
                foreach (var parametro in lista_parametros)
                    comando.Parameters.Add(parametro.NombreParametro, parametro.TipoDato).Value = parametro.ValorParametro;
            }
            var resultado = comando.ExecuteNonQuery();
            conn.CerrarConexion();
            if (resultado > 0)
                return true;
            else
                return false;
        }

        public DataTable ExecuteSpQuery(string nombre_sp, List<CD_ParameterSP> lista_paramteros)
        {

            var comando = new SqlCommand();
            comando.Connection = conn.AbrirConexion(); //asigno conexion
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombre_sp;
            if (lista_paramteros.Count > 0)
            {
                foreach (var parametro in lista_paramteros)
                    comando.Parameters.Add(parametro.NombreParametro, parametro.TipoDato).Value = parametro.ValorParametro;
            }

            SqlDataReader reader = comando.ExecuteReader();

            using (var tabla = new DataTable())
            {
                tabla.Load(reader);
                reader.DisposeAsync();
                conn.CerrarConexion();
                return tabla;
            }

        }


    }
}
