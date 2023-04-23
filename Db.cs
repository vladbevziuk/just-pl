﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace just_pl
{
    class Db
    {
        MySqlConnection con = new MySqlConnection("server = localhost; port = 3306; username = root; password = root; database = justpl");

        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }
        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();   
        }
        public MySqlConnection getConnection()
        {
            return con;
        } 
    }
}
