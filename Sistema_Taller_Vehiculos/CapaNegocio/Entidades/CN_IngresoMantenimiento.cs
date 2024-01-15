using CapaDatos.Entidades;
using CapaDatos.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entidades
{
    public class CN_IngresoMantenimiento
    {
        private InterfaceNegocio obj_interfaceMantenimiento = new InterfaceNegocio();
        private int id_mantenimiento;
        private string codigo;
        private int id_cliente;
        private int id_mecanico;
        private int id_Vehiculo;
        private string fechaMantenimiento;
        private string diagnostico;
        private string trabajosRealizados;
        private string tipoMantenimiento;
        private string repuestosUtilizados;
        private float valorRepuestos;
        private int id_servicio;

        public CN_IngresoMantenimiento ()
        {
            id_cliente = 0;
            id_mecanico = 0;
            id_Vehiculo = 0;
            id_servicio = 0;
            fechaMantenimiento = String.Empty;
            diagnostico = String.Empty;
            codigo = String.Empty;
            trabajosRealizados = String.Empty;
            tipoMantenimiento= String.Empty;
            repuestosUtilizados = String.Empty;
            valorRepuestos = 0;
            id_mantenimiento = 0;
        }
        public string getCodigoMantenimiento()
        {
            try
            {
                
                return obj_interfaceMantenimiento.getCodigoMantenimiento();
                


            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el codigo del mantenimiento" + ex.Message);
            }
        }
        public string getIdMantenimiento()
        {
            try
            {

                return obj_interfaceMantenimiento.getIdMantenimiento();



            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el codigo del mantenimiento" + ex.Message);
            }
        }

        public DataTable getMecanicoByCodigo(CN_IngresoMantenimiento mecanico)
        {
            try
            {
                var tabla = new DataTable();
                List<CD_ParameterSP> lista = new List<CD_ParameterSP>();
                lista.Add(new CD_ParameterSP("@id_mantenimiento", mecanico.id_mantenimiento, SqlDbType.Int));
                tabla = obj_interfaceMantenimiento.getCodigoMecanico(lista);
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener cliente" + ex.Message);
            }
        }
        public DataTable getMecanicos()
        {
            try
            {

                return obj_interfaceMantenimiento.getListaMecanico();



            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista mecanico" + ex.Message);
            }
        }
        public DataTable getIdMecanico()
        {
            try
            {

                return obj_interfaceMantenimiento.getListaMecanico();



            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista mecanico" + ex.Message);
            }
        }

        public DataTable getCliente()
        {
            try
            {

                return obj_interfaceMantenimiento.getListaCliente();



            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista mecanico" + ex.Message);
            }
        }
        public DataTable getVehiculo()
        {
            try
            {

                return obj_interfaceMantenimiento.getListaVehiculo();



            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista mecanico" + ex.Message);
            }
        }
        public DataTable getServicio()
        {
            try
            {

                return obj_interfaceMantenimiento.getListaServicio();



            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista mecanico" + ex.Message);
            }
        }

        public bool ingresarMantenimiento(CN_IngresoMantenimiento mantenimiento)
        {
            try
            {
                List<CD_ParameterSP> lista = new List<CD_ParameterSP>();
                lista.Add(new CD_ParameterSP("@Codigo", mantenimiento.codigo, SqlDbType.Text));
                lista.Add(new CD_ParameterSP("@Id_Cliente", mantenimiento.id_cliente, SqlDbType.Int));
                lista.Add(new CD_ParameterSP("@Id_Mecanico", mantenimiento.id_mecanico, SqlDbType.Int));
                lista.Add(new CD_ParameterSP("@Id_Vehiculo", mantenimiento.Id_Vehiculo, SqlDbType.Int));
                lista.Add(new CD_ParameterSP("@FechaMantenimiento", mantenimiento.fechaMantenimiento, SqlDbType.Date));
                lista.Add(new CD_ParameterSP("@Diagnostico", mantenimiento.diagnostico, SqlDbType.Text));
                lista.Add(new CD_ParameterSP("@TrabajosRealizados", mantenimiento.trabajosRealizados, SqlDbType.Text));
                lista.Add(new CD_ParameterSP("@TipoMantenimiento", mantenimiento.tipoMantenimiento, SqlDbType.Text));
                lista.Add(new CD_ParameterSP("@RepuestosUtilizados", mantenimiento.repuestosUtilizados, SqlDbType.Text));
                lista.Add(new CD_ParameterSP("@ValorRepuestos", mantenimiento.valorRepuestos, SqlDbType.Decimal));
                return obj_interfaceMantenimiento.crearMantenimiento(lista);


            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Error al crear cliente" + ex.Message);
            }
        }
        public bool ingresarServicio(CN_IngresoMantenimiento mantenimiento)
        {
            try
            {
                List<CD_ParameterSP> lista = new List<CD_ParameterSP>();
                lista.Add(new CD_ParameterSP("@Id_Mantenimiento", mantenimiento.id_mantenimiento, SqlDbType.Int));
                lista.Add(new CD_ParameterSP("@Id_Servicio", mantenimiento.id_servicio, SqlDbType.Int));
                
                return obj_interfaceMantenimiento.crearServicio(lista);


            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Error al crear cliente" + ex.Message);
            }
        }

        public int Id_Mantenimiento { get { return id_mantenimiento; } set { id_mantenimiento = value; } }
    
        public string Codigo { get { return codigo; } set { codigo= value; } }
        public int Id_Cliente {  get { return id_cliente; } set { id_cliente = value; } }
        public int Id_Mecanico { get { return id_mecanico;} set { id_mecanico = value; } }
        public int Id_Vehiculo { get { return id_Vehiculo; } set { id_Vehiculo = value; } }
        public string FechaMantenimiento { get {  return fechaMantenimiento; } set { fechaMantenimiento = value; } }
        public string Diagnostico { get { return diagnostico; } set {  diagnostico = value; } }
        public string TrabajosRealizados { get {  return trabajosRealizados; } set { trabajosRealizados = value; } }
        public string TipoMantenimiento { get { return tipoMantenimiento;}set { tipoMantenimiento= value; } }
        public string RepuestosUtilizados { get { return repuestosUtilizados; }set {  repuestosUtilizados = value;} }
        public float ValorRespuestos { get { return valorRepuestos; }set {  valorRepuestos = value; } }
        public int Id_servicio { get { return id_servicio;}set { id_servicio = value; } }

    }
}
