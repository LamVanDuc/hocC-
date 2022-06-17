using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Product> inV = new List<Product>();

            //inV.Add(new Product("A", 5.9, 3));
            //inV.Add(new Product("B", 8.2, 2));
            //inV.Add(new Product("C", 3.5, 4));
            //inV.Add(new Product("D", 1.8, 8));
            //Console.WriteLine("Product list :");

            //foreach (Product item in inV)
            //{
            //    Console.WriteLine("  " + item);
            //}
            //Console.ReadLine();


            //    String a = "a";
            //    String b = "b";
            //    Swap<String>(ref a, ref b);
            //    System.Console.WriteLine(a + " " + b);
            //    Console.ReadLine();
            //}

            //static void Swap<T>(ref T lhs, ref T rhs)
            //{
            //    T temp = lhs;
            //    lhs = rhs;
            //    rhs = temp;
            //}

            //Test in case return null
            Console.WriteLine("{0}",null);

            List<int> list = new List<int>();
            list.Add(10);
            list.Add(1);
            list.Add(1230);

            Console.WriteLine("{0}", GetFirst(list));
            Console.ReadLine();
         }
    private static int? GetFirst(List<int> list)
    {
        if (list == null || list.Count == 0)
        {
            return null;
        }
        return list[0];
    }


}


class Product
    {
        private string name;
        private double cost;
        private int onhand;
        public Product(string n, double c, int h)
        {
            name = n;
            cost = c;
            onhand = h;
        }

        public override string ToString()
        {
            return String.Format("{0 , -10}Cost : {1,6:C} On hand: {2}", name, cost, onhand);
        }
    }
    class Pair<T>
    {
        private T first;
        private T second;

        public Pair(T first, T second)
        {
            this.first = first;
            this.second = second;
        }

        public T First
        {
            get { return first; }

        }

        public T Second
        {
            get { return second; }
        }
    }

    class GenericClass
    {
        static void Main(string[] args)
        {
            Pair<String> pair = new Pair<String>("An", "Nga");
            Console.WriteLine("({0} , {1}) ", pair.First, pair.Second);

            Console.ReadLine();
        }
    }

}