using CapaDatos.Entidades;
using CapaDatos.SqlExecute;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos.Interface
{
    public class InterfaceNegocio
    {
        private ExecuteSqlCommand obj_db = new ExecuteSqlCommand();

        public int Login(List<CD_ParameterSP> lista)
        {
            try
            {
                return obj_db.ExecuteLogin("SP_LOGIN", lista);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ingresar" + ex.Message);
                return -1;
            }

           
        }
        public string recoverPassword(string userRequest)
        {
            return obj_db.recoverPassword(userRequest);
        }
        
        public bool crearUsuario(List<CD_ParameterSP> lista)
        {
            try
            {
                return obj_db.ExecuteSpNonQuery("SP_CREAR_USUARIO",lista);
            }catch (Exception ex)
            {
                throw new Exception("ERROR AL CREAR USUARIO"+ ex.Message);
            }
        }

        public bool crearMantenimiento(List<CD_ParameterSP> lista)
        {
            try
            {
                return obj_db.ExecuteSpNonQuery("SP_INSERTAR_MANTENIMIENTO", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR AL CREAR MANTENIMIENTO" + ex.Message);
            }
        }
        public bool crearServicio(List<CD_ParameterSP> lista)
        {
            try
            {
                return obj_db.ExecuteSpNonQuery("SP_INSERTAR_SERVICIO_MANTENIMIENTO", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR AL CREAR SERVICIO" + ex.Message);
            }
        }

        public bool crearVehiculo(List<CD_ParameterSP> lista)
        {
            try
            {
                return obj_db.ExecuteSpNonQuery("SP_INSERTAR_VEHICULO", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR AL CREAR VEHICULO" + ex.Message);
            }
        }
        
        public DataTable getListaCliente()
        {
            try
            {
                List<CD_ParameterSP> lista = new List<CD_ParameterSP>();
                return obj_db.ExecuteSpQuery("SP_GET_CLIENTES", lista);
            }catch (Exception ex)
            {
                throw new Exception("Error al obtener clientes"+ ex.Message);
            }
        }
        public string getCodigoMantenimiento()
        {
            try
            {
               
                return obj_db.ExecuteSpQueryC("SP_GET_CODIGO_MANTENIMIENTO");
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener codigo mantenimiento" + ex.Message);
            }
        }
        public string getIdMantenimiento()
        {
            try
            {

                return obj_db.ExecuteSpQueryC("SP_GET_ID_MANTENIMIENTO");
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener codigo mantenimiento" + ex.Message);
            }
        }
        public DataTable getCodigoMecanico(List<CD_ParameterSP> lista)
        {
            try
            {

                return obj_db.ExecuteSpQuery("SP_GET_CODIGO_MANTENIMIENTO",lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener codigo mantenimiento" + ex.Message);
            }
        }
        

        public DataTable getListaVehiculo()
        {
            try
            {
                List<CD_ParameterSP> lista = new List<CD_ParameterSP>();
                return obj_db.ExecuteSpQuery("SP_GET_VEHICULO", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener clientes" + ex.Message);
            }
        }
        public DataTable getListaServicio()
        {
            try
            {
                List<CD_ParameterSP> lista = new List<CD_ParameterSP>();
                return obj_db.ExecuteSpQuery("SP_GET_SERVICIO", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener clientes" + ex.Message);
            }
        }

        public DataTable getListaMecanico()
        {
            try
            {
                List<CD_ParameterSP> lista = new List<CD_ParameterSP>();
                return obj_db.ExecuteSpQuery("SP_GET_MECANICO", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener Mecanico" + ex.Message);
            }
        }

        

        public DataTable getClienteByCedula(List<CD_ParameterSP>lista)
        {
            try
            {
                return obj_db.ExecuteSpQuery("SP_GET_CLIENTE_BY_CEDULA", lista);
            }catch (Exception ex)
            {
                throw new Exception ("Error al obtener cliente "+ ex.Message);
            }
        }

        public DataTable getVehiculoByPlaca(List<CD_ParameterSP> lista)
        {
            try
            {
                return obj_db.ExecuteSpQuery("SP_GET_VEHICULO_BY_PLACA", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener cliente " + ex.Message);
            }
        }

        public DataTable getMecanicoByCedula(List<CD_ParameterSP> lista)
        {
            try
            {
                return obj_db.ExecuteSpQuery("SP_GET_MECANICO_BY_CEDULA", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener cliente " + ex.Message);
            }
        }
    }

       
}


