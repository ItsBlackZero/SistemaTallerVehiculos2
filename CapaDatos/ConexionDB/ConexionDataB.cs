using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos.ConexionDB
{
    internal class ConexionDataB
    {
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-KEAFE1A; database=TALLER_VEHICULOS; Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();

            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();

            return conexion;
        }

        public SqlConnection GetConnection()
        {
            return conexion;
        }
    }
}
