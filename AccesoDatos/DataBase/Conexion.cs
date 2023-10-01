﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AccesoDatos.DataBase
{
    public class Conexion
    {
        private static readonly Conexion instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion.instancia; }
        }
        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=.;Initial Catalog = Hotel_Central_p;" + "Integrated Security = true";

            return cn;
        }

    }
}
