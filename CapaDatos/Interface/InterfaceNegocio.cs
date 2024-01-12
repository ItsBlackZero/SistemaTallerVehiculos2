﻿using CapaDatos.Entidades;
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
    }

       
}

