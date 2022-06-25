using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        List<Product> productList = new List<Product>();
        static void Main(string[] args)
        {
            Program program = new Program();
            try
            {
                while (true)
                {
                    program.menu();
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            program.AddProductRecords();
                            break;
                        case 2:
                            program.DisplayProductRecords();
                            break;
                        case 3:
                            program.DeleteProductById();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Please choose from the menu !");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error! An error occurred." + ex.Message);
            }
            Console.ReadLine();
        }


        // menu 
        public void menu()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("1 .Add product records");
            Console.WriteLine("2 .Display product records");
            Console.WriteLine("3 .Delete product by Id");
            Console.WriteLine("4 .Exit");
            Console.Write("choice : ");
        }

        //Add product records
        public void AddProductRecords()
        {
            Console.Write("\nEnter Product ID :");
            string id = Console.ReadLine();
            int count = 0;
            foreach (var item in productList)
            {
                if (item.ProductId.Equals(id))
                {
                    Console.WriteLine("already exists product id = {0}", id);
                    count = 1;
                    break;
                }

            }

            if (count == 0)
            {
                Console.Write("Enter product Name : ");
                string name = Console.ReadLine();
                Console.Write("Enter Product Price : ");
                float price = float.Parse(Console.ReadLine());
                productList.Add(new Product() { ProductId = id, Name = name, Price = price });
                Console.WriteLine("Add success !");
            }

        }


        // Display product records

        public void DisplayProductRecords()
        {
            Console.WriteLine(string.Format("{0,-10} {1,-10} {2}", "ProductID", "Name", "Price"));
            Console.WriteLine("---------------------------------------------------");
            if (productList.Count > 0)
            {
                foreach (var item in productList)
                {
                    Console.WriteLine(
                        string.Format("{0,-10} {1,-10} ${2}", item.ProductId, item.Name, item.Price)
                        );
                }
            }
            else
            {
                Console.WriteLine("No products !");
            }

        }

        //Delete product by Id
        public void DeleteProductById()
        {
            Console.Write("Enter Product ID to Delete : ");
            string id = Console.ReadLine();
            int count = 0;

            foreach (var item in productList)
            {
                if (item.ProductId.Equals(id))
                {
                    productList.Remove(
                        productList.Find(
                            p => { return p.ProductId == id; }
                            )
                        );
                    Console.WriteLine("Delete sucess !");
                    count = 1;
                    break;
                }
                else
                {
                    count = 0;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("Not Found ProductId : {0}", id);
            }
        }
    }
}
