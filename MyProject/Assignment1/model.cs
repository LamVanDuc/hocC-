using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace Assignment1
{

    class Model
    {
        
        SqlConnection connection = new ConnectionData().GetDatabase();
        //show all product
        public List<Product> ShowAll()
        {
            
            List<Product> listProduct = new List<Product>();

            string query = "select * from product";
            connection.Open();
            SqlCommand command = new SqlCommand(query , connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader[0]);
                string proName = Convert.ToString(reader[1]);
                string proDesc = Convert.ToString(reader[2]);
                double price = Convert.ToDouble(reader[3]);
                listProduct.Add(new Product(id,proName , proDesc , price));
            }

            connection.Close();
            return listProduct;
            listProduct.Clear();
        }
        
        
        // Add product
        public void AddProduct(Product product)
        {

            connection.Open();
            //string query = "Insert Into product values('"+product.proName+"','"+product.proDesc+ "'," + product.price + ")";
            //SqlCommand command = new SqlCommand(query, connection);
            SqlCommand command = new SqlCommand("Insert into product values (@proName,@proDesc,@price)",connection);
            command.Prepare();
            command.Parameters.AddWithValue("@proName",product.proName);
            command.Parameters.AddWithValue("@proDesc", product.proDesc);
            command.Parameters.AddWithValue("@price", product.price);

            int check = command.ExecuteNonQuery();
            if (check > 0)
            {
                Console.WriteLine("Add Product Success !");
            }
            else
            {
                Console.WriteLine("Add Product Fasle ! ");
            }
            connection.Close();

        }
        

        // Delete product
        public void DeleteProduct(int id)
        {
            connection.Open();
            string query = "Delete product Where id ="+id;
            SqlCommand command = new SqlCommand(query,connection);
            int check = command.ExecuteNonQuery();
            if (check >0)
            {
                Console.WriteLine("Delete sucsses !");
            }
            else
            {
                Console.WriteLine("Delete False ! check product id ");
            }

            connection.Close();
        }

        //Update product 
        public void UpdateProduct(Product product)
        {

            connection.Open();
           // SqlCommand command = new SqlCommand(query, connection);
            SqlCommand command = new SqlCommand("Update product Set proName = @proName,proDesc = @proDesc,price=@price Where id = @id", connection);
            command.Parameters.AddWithValue("@id", product.id);
            command.Parameters.AddWithValue("@proName", product.proName);
            command.Parameters.AddWithValue("@proDesc", product.proDesc);
            command.Parameters.AddWithValue("@price", product.price);

            
            int check = command.ExecuteNonQuery();
            if (check > 0)
            {
                Console.WriteLine("Update sucsses !");
            }
            else
            {
                Console.WriteLine("Update False ! check product ");
            }

            connection.Close();
        }

        //Search product by id
        public void SearchProductByID(int id)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            List<Product> productList = ShowAll();
            var fint = productList.Find(p => 
            {
                return p.id == id;
             });


            if (fint == null)
            {
                Console.WriteLine("ID {0} Not found ! ",id);
            }
            else
            {
                Console.WriteLine("Product Name : {0}\nProduct Description : {1}\nProduct Price : {2}", fint.proName, fint.proDesc, fint.price);
            }
            time.Stop();
            Console.WriteLine("----------------------- list search by id-------------------");
            Console.WriteLine("Run for : " + time.ElapsedMilliseconds +" ms");

        }


        // search product by name
        public void SearchProductByName(string name)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            List<Product> productList = ShowAll();
            var findAll = productList.FindAll(p =>
            {
                return p.proName == name;
            });


            if (findAll == null)
            {
                Console.WriteLine("Name {0} Not found ! ", name);
            }
            else
            {
                int count = 0;
                foreach (var item in findAll)
                {
                    Console.WriteLine("-------------------------------- index : {0} --------------------------------", count++);
                    Console.WriteLine("Product Name : {0}\nProduct Description : {1}\nProduct Price : {2}", item.proName, item.proDesc, item.price);
                    
                }
                
            }
            time.Stop();

            Console.WriteLine("run for : " + time.ElapsedMilliseconds + " ms");

        }

        public void TestProcedure()
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("SelectProduct",connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.ExecuteNonQuery();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader[0]);
                string proName = Convert.ToString(reader[1]);
                string proDesc = Convert.ToString(reader[2]);
                double price = Convert.ToDouble(reader[3]);
                Console.WriteLine(" ID : {0} ProName : {1} ProDesc : {2} | price : {3}" , id , proName , proDesc , price);
            }

            connection.Close();
        }

        public void SelectProcedureByID(int id)

        {
            connection.Open();
            SqlCommand command = new SqlCommand("SelectProductByID", connection);
            command.Parameters.AddWithValue("@id",id);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int idproduct = Convert.ToInt32(reader[0]);
                string proName = Convert.ToString(reader[1]);
                string proDesc = Convert.ToString(reader[2]);
                double price = Convert.ToDouble(reader[3]);
                Console.WriteLine(" ID : {0} ProName : {1} ProDesc : {2} | price : {3}", idproduct, proName, proDesc, price);
            }


            connection.Close();
        }

        // ====================================== HashTable ===================================== 
        public Hashtable ShowWithHasbTable()
        {

            Hashtable hashtable = new Hashtable();
            
            string query = "select * from product";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader[0]);
                string proName = Convert.ToString(reader[1]);
                string proDesc = Convert.ToString(reader[2]);
                double price = Convert.ToDouble(reader[3]);
                hashtable.Add(id, new Product(proName,proDesc, price));
            }

            connection.Close();
            return hashtable;
        }

        public void SearchHastableById(int id)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            Hashtable hashtable = ShowWithHasbTable();

            if (hashtable.ContainsKey(id))
            {
                Console.WriteLine(" {0}  {1} ", id, hashtable[id]);
            }
            else
            {
                Console.WriteLine("Not found key : {0}", id);
            }
            time.Stop();
            Console.WriteLine("--------------------  HasHtable Search By ID ------------------");
            Console.WriteLine("run for : " + time.ElapsedMilliseconds +" ms");
        }



        public void SearchHastableByName(string name)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            Hashtable hashtable = ShowWithHasbTable();

            int count = 0;
            foreach (Product productItem in hashtable.Values)
            {
                if (productItem.proName.Equals(name))
                {
                    count = 1;
                    Console.WriteLine("{0} | {1} | {2} ", productItem.proName , productItem.proDesc , productItem.price);
                }
                
            }
            if (count != 0)
            {
                Console.WriteLine("Not found !");
            }
            time.Stop();

            Console.WriteLine("--------------------  HasHtable Search By Name ------------------");
            Console.WriteLine("run for : " + time.ElapsedMilliseconds + " ms");
        }


    }

}
