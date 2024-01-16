using CapaDatos.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entidades
{
    public class CN_factura
    {
        private InterfaceNegocio obj_Factura= new InterfaceNegocio();

        public DataTable getFactura()
        {
            try
            {
                var tabla = new DataTable();
                tabla = obj_Factura.getListaFactura();
                return tabla;


            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los Mecanico" + ex.Message);
            }
        }
    }
}
