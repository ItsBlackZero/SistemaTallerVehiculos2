using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Entidades;
using CapaDatos.Interface;

namespace CapaNegocio.Entidades
{
    public class CN_IngresoVehiculo
    {
        private string placa;
        private string modelo;
        private string anio;
        private string kilometraje;

        private InterfaceNegocio obj_inteface_Vehiculo = new InterfaceNegocio();

        public DataTable getVehiculo()
        {
            try
            {
                var tabla = new DataTable();
                tabla = obj_inteface_Vehiculo.getListaVehiculo();
                return tabla;


            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los clientes" + ex.Message);
            }
        }
        public DataTable getVehiculoByPlaca(CN_IngresoVehiculo vehiculo)
        {
            try
            {
                var tabla = new DataTable();
                List<CD_ParameterSP> lista = new List<CD_ParameterSP>();
                lista.Add(new CD_ParameterSP("@placa", vehiculo.placa, SqlDbType.Text));
                tabla = obj_inteface_Vehiculo.getVehiculoByPlaca(lista);
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener cliente" + ex.Message);
            }
        }

        public bool ingresarVehiculo(CN_IngresoVehiculo vehiculo)
        {
            try
            {
                List<CD_ParameterSP> lista = new List<CD_ParameterSP>();
                lista.Add(new CD_ParameterSP("@Placa", vehiculo.placa, SqlDbType.Text));
                lista.Add(new CD_ParameterSP("@Modelo", vehiculo.modelo, SqlDbType.Text));
                lista.Add(new CD_ParameterSP("@Anio", vehiculo.anio, SqlDbType.Text));
                lista.Add(new CD_ParameterSP("@Kilometraje", vehiculo.kilometraje, SqlDbType.Text));
                return obj_inteface_Vehiculo.crearVehiculo(lista);


            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Error al crear cliente" + ex.Message);
            }
        }

        public string Placa { get { return placa; } set { placa = value; } }
        public string Modelo { get {  return modelo; } set {  modelo = value; } }
        public string Anio { get {  return anio; } set {  anio = value; } }
        public string Kilometraje { get {  return kilometraje; } set {  kilometraje = value; } }
    }
}
