using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Diagnostics;

namespace Assignment1
{
    class Program
    {
        Model model = new Model();

        static void Main(string[] args)
        {
            try
            {
                Program program = new Program();
                while (true)
                {
                    Console.WriteLine("============================== Actions <List=============================");
                    Console.WriteLine("1. Add product");
                    Console.WriteLine("2. Delete product");
                    Console.WriteLine("3. Update product");
                    Console.WriteLine("4. Search Product by Name ");
                    Console.WriteLine("5. Search product by id");
                    Console.WriteLine("6. Show ALL");
                    Console.WriteLine("7. Select Procedure ");
                    Console.WriteLine("8. Select Procedure By ID  ");
                    Console.WriteLine("==========Hash table ===========");
                    Console.WriteLine("9. Show All Hash table");
                    Console.WriteLine("10. Search product by id (hashtable)");
                    Console.WriteLine("11. Search product by Name(hashtable)");
                    Console.WriteLine("0. Exit ! ");
                    Console.WriteLine("----------------------------------------------");
                    Console.Write("your choice : ");
                    int c = int.Parse(Console.ReadLine());
                    switch (c)
                    {
                        case 1:
                            program.AddProduct();
                            break;
                        case 2:
                            program.DeleteProduct();
                            break;
                        case 3:
                            program.UpdateProduct();
                            break;
                        case 4:
                            program.SearchProductByName();
                            break;
                        case 5:
                            program.SearchProductByID();
                            break;
                        case 6:
                            // program.ShowAll();
                            program.ShowAll();
                            break;
                        case 7:
                            program.TestProcedure();
                            break;
                        case 8:
                            program.SelectProcedureByID();
                            break;
                        case 9:
                            program.ShowAllWithHashTable();
                            break;
                        case 10:
                            program.SearchHastableById();
                            break;
                        case 11:
                            program.SearchHastableByName();
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Please choose a number from 1-7 !");
                            break;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error : "+ sqlEx.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("?");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please choose a number from 1-7 !");
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        // add product 
        public void AddProduct()
        {

            Console.WriteLine("----------------- Add Product ------------------");
            Console.Write("Enter product name : ");
            string proName = Console.ReadLine();
            Console.Write("Enter product description : ");
            string proDesc = Console.ReadLine();
            Console.Write("Enter Product price : ");
            double price = double.Parse(Console.ReadLine());
            model.AddProduct(new Product(proName, proDesc, price));
        }

        // Delete  product
        public void DeleteProduct()
        {
            Console.WriteLine("----------------- Delete Product ------------------");
            Console.WriteLine("Enter product id : ");
            int id = int.Parse(Console.ReadLine());
            model.DeleteProduct(id);
        }


        //Update product
        public void UpdateProduct()
        {
            Console.WriteLine("----------------- Update Product ------------------");
            Console.Write("Enter Product ID : ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter product name : ");
            string proName = Console.ReadLine();
            Console.Write("Enter product description : ");
            string proDesc = Console.ReadLine();
            Console.Write("Enter Product price : ");
            double price = double.Parse(Console.ReadLine());

            model.UpdateProduct(new Product(id, proName, proDesc, price));
        }

        // show all 
        public void ShowAll()
        {

            Stopwatch time = new Stopwatch();
            time.Start();
            List<Product> products = model.ShowAll();
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine("{0}  :  {1}  :    {2}", products[i].proName, products[i].proDesc, products[i].price);
            }
            time.Stop();
            Console.WriteLine("------------------- Show ALL With List --------------------------");
            Console.WriteLine("Run For : " + time.ElapsedMilliseconds + " ms");

        }

        //Search   product by id
        public void SearchProductByID()
        {
            Console.WriteLine("----------------- Search Product ------------------");
            Console.Write("Enter Product ID : ");
            int id = int.Parse(Console.ReadLine());
            model.SearchProductByID(id);
        }


        // search product by name 
        public void SearchProductByName()
        {
            Console.WriteLine("----------------- Search Product ------------------");
            Console.Write("Enter product name :");
            string name = Console.ReadLine();
            model.SearchProductByName(name);
        }


        public void TestProcedure()
        {
            model.TestProcedure();
        }


        public void SelectProcedureByID()
        {
            Console.WriteLine("Enter Product ID : ");
            int id = int.Parse(Console.ReadLine());
            model.SelectProcedureByID(id);
        }

        //==========================================================================
        // hashtable 
        public void ShowAllWithHashTable()
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            Hashtable hashtable = model.ShowWithHasbTable();
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + "  "+item.Value);
            }
            time.Stop();
            Console.WriteLine("------------------- Show ALL With HasHtable --------------------------");
            Console.WriteLine("Run For : " + time.ElapsedMilliseconds +" ms");
        }

        public void SearchHastableById()
        {
            Console.WriteLine("enter product id: ");
            int id = int.Parse(Console.ReadLine());
            model.SearchHastableById(id);
        }


        public void SearchHastableByName()
        {
            Console.WriteLine("Enter product name : ");
            string name = Console.ReadLine();

            model.SearchHastableByName(name);
        }

    }
}
