using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Assignment1
{
    class ConnectionData
    {
        public SqlConnection GetDatabase()
        {
            string connectionString = "Data source = localhost ; Initial Catalog = Dbtest ;User = lamduc ; password = 123456"; //Integrated security = true
            SqlConnection connect = new SqlConnection(connectionString);           
                //Console.WriteLine("connection failed !");
                return connect;
        }
    }
}
