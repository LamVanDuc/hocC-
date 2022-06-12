using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Lab6_ConnectSqlServer
{
    class Program
    {


       static  ConnectionDB connectionDb = new ConnectionDB();
        static SqlConnection conn = connectionDb.GetConnection();
        static void Main(string[] args)
        {
            
            
        }

        // get data
        public static void GetData()
        {
            ConnectionDB connectionDb = new ConnectionDB();
             SqlConnection conn = connectionDb.GetConnection();

            string query = "select * from product";
            SqlCommand command = new SqlCommand(query ,conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Product Name : {0} | Desc : {1} | price : {2}\n",reader[1],reader[2],reader[3]);
            }
            conn.Close();
        }


        // create value
        public static void AddProduct()
        {
            
            string query = "insert into product values('HuaWei','thong minh nhat 2022',20000)";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            int row = command.ExecuteNonQuery();

            if (row >0)
            {
                Console.WriteLine("inset thanh cong !");
            }
            else
            {
                Console.WriteLine("insert khong thanh cong");
            }
            conn.Close();
        }

        public static void UpdateData()
        {
            ConnectionDB connectionDB = new ConnectionDB();
            SqlConnection conn = connectionDB.GetConnection();

            string query = "UPDATE product SET proDESC = 'moi nhat 2020' , price = 50000 WHERE id=2; ";

            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            int check =command.ExecuteNonQuery();

            if (check > 0)
            {
                Console.WriteLine("update thanh cong");
            }
            else
            {
                Console.WriteLine("update khong thanh cong");
            }
            conn.Close();
        }

        public static void DeleteData()
        {
            ConnectionDB connectionDB = new ConnectionDB();
            SqlConnection conn = connectionDB.GetConnection();

            string query = "DELETE FROM product WHERE id =2; ";

            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            int check = command.ExecuteNonQuery();

            if (check > 0)
            {
                Console.WriteLine("delete thanh cong");
            }
            else
            {
                Console.WriteLine("delete khong thanh cong");
            }
            conn.Close();

        }
    }
}
