using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace just_pl
{
    class Db
    {
        SqlConnection con = new SqlConnection("Server=tcp:justplay.database.windows.net,1433;Initial Catalog=just play;Persist Security Info=False;User ID=vlad;Password=fgdzasdf;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

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
        public SqlConnection getConnection()
        {
            return con;
        } 
    }
}
