﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Database
    {
        private SqlConnection conn;

        public SqlConnection ConectaDb()
        {
            try
            {
                string cadenadeconexion = "Data Source=.;Initial Catalog=HotelBooking;Integrated Security=True";
                conn = new SqlConnection(cadenadeconexion);
                conn.Open();
                return conn;
            }
            catch (SqlException e)
            {
                return null;
            }


        }

        public void DesconectaDb()
        {
            conn.Close();
        }

    }
}
