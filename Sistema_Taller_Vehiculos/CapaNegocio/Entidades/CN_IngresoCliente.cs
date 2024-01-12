using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Interface;
using CapaDatos.Entidades;
namespace CapaNegocio.Entidades
{
    public class CN_IngresoCliente
    {

        private string nombres;
        private string apellidos;
        private string cedula;
        private string telefono;
        private string direccion;

        private InterfaceNegocio obj_interface_Ingreso_Cliente = new InterfaceNegocio();
        
        public DataTable getCliente()
        {
            try
            {
                var tabla = new DataTable();
                tabla = obj_interface_Ingreso_Cliente.getListaCliente();
                return tabla;


            }catch (Exception ex)
            {
                throw new Exception("Error al obtener los clientes"+ ex.Message);
            }
        }

        public bool crearCliente(CN_IngresoCliente cliente)
        {
            try { 
                List<CD_ParameterSP> lista = new List<CD_ParameterSP>();
                lista.Add(new CD_ParameterSP("@Apellidos",cliente.apellidos,SqlDbType.Text));
                lista.Add(new CD_ParameterSP("@Nombres",cliente.nombres,SqlDbType.Text));
                lista.Add(new CD_ParameterSP("@Cedula",cliente.cedula,SqlDbType.Text));
                lista.Add(new CD_ParameterSP("@Telefono",cliente.telefono,SqlDbType.Text));
                lista.Add(new CD_ParameterSP("@Direccion",cliente.direccion,SqlDbType.Text));
                return obj_interface_Ingreso_Cliente.crearUsuario(lista);


            }catch (Exception ex)
            {
             return false;
                   throw new Exception("Error al crear cliente"+ ex.Message);
            }
        }

        public string Nombres { get { return nombres; } set { nombres = value; } }
        public string Apellidos { get {  return apellidos; } set {  apellidos = value; } }
        public string Cedula { get { return cedula; } set { cedula = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public string Direccion { get {  return direccion; } set { direccion = value; } }
    }
}
