using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
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
            string query = "Insert Into product values('"+product.proName+"','"+product.proDesc+ "'," + product.price + ")";
            SqlCommand command = new SqlCommand(query, connection);
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
     
            
            string query = "Update product Set proName = '"+product.proName+"',proDesc = '"+product.proDesc+"',price='"+product.price+"' Where id ="+product.id ;

            connection.Open();
           // SqlCommand command = new SqlCommand(query, connection);



            SqlCommand command = new SqlCommand("Update product Set proName = @proName,proDesc = @proDesc,price=@price Where id = @id", connection);
            command.Prepare();
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
            

        }


        // search product by name
        public void SearchProductByName(string name)
        {
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
        }


    }

}
