using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MeramecNetFlixProject.DataAccessLayer
{
    public class AccessDataSQLServer
    {
        public static SqlConnection GetConnection()
        {
            string ConnectionString = "Server=*;Database=*; User ID=*;Password=*";
            SqlConnection connection = new SqlConnection(ConnectionString);
            return connection;
        }
        //public AccessDataSQLServer()
        //{
        //}

        //Add public methods to expose to the outside world

    }

   
}
