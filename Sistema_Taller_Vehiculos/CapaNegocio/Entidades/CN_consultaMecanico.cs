using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Interface;

namespace CapaNegocio.Entidades
{
    public class CN_consultaMecanico
    {
        private string cedula;
        private InterfaceNegocio obj_Mecanico = new InterfaceNegocio();

        public DataTable getMecanico()
        {
            try
            {
                var tabla = new DataTable();
                tabla = obj_Mecanico.getListaMecanico();
                return tabla;


            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los Mecanico" + ex.Message);
            }
        }
        public DataTable getMecanicoByCedula(CN_consultaMecanico mecanico)
        {
            try
            {
                var tabla = new DataTable();
                List<CD_ParameterSP> lista = new List<CD_ParameterSP>();
                lista.Add(new CD_ParameterSP("@cedula", mecanico.cedula, SqlDbType.Text));
                tabla = obj_Mecanico.getMecanicoByCedula(lista);
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener cliente" + ex.Message);
            }
        }

        public DataTable getClienteByCedula(CN_consultaMecanico cliente)
        {
            try
            {
                var tabla = new DataTable();
                List<CD_ParameterSP> lista = new List<CD_ParameterSP>();
                lista.Add(new CD_ParameterSP("@cedula", cliente.cedula, SqlDbType.Text));
                tabla = obj_Mecanico.getClienteByCedula(lista);
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener cliente" + ex.Message);
            }
        }


        public string Cedula { get { return cedula; } set { cedula= value; } }
    }
}
