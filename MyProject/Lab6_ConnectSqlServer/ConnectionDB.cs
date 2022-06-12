using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_ConnectSqlServer
{
    class ConnectionDB
    {
        public SqlConnection GetConnection()
        {
            //Sql aythentication (su dung SQLServer authentication)
            string connectionString = "Data source = localhost; Initial Catalog = DBtest ; User = lamduc; password =123456";
            //Sql authentication (su dung Window Authentication)
            // string connectionString = "Data source = localhost; Initial Catalog = BDtest ; Integrated security = SSPI";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }
    }
}
