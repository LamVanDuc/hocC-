using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BaiTap01
{
    class SqlServerConnection
    {
        public SqlConnection GetDataServer()
        {
            string stringConnection = "Data source = localhost ; Initial Catalog = Dbtest ; User = lamduc ; password = 123456";

            SqlConnection connection = new SqlConnection(stringConnection);
            
            return connection;
        }
    }
}
