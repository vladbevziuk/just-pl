using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace just_pl
{
    class Db
    {
        SqlConnection con = new SqlConnection(@"Data Source=justplay.database.windows.net;Initial Catalog=just_play;Persist Security Info=True;User ID=vlad;Password=Fgdzasdf1");

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
