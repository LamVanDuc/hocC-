using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------- Bai 32--------------");
            Bai32.Output();
            Console.WriteLine("-------------- Bai 33--------------");
            Bai33.Output();
            Console.WriteLine("-------------- Bai 34--------------");
            Bai34.Output();
            Console.WriteLine("-------------- Bai 35--------------");
            Bai35.Output();
            Console.WriteLine("-------------- Bai 36--------------");
            Bai36.Output();
            Console.WriteLine("-------------- Bai 37--------------");
            Bai37.Output();
            Console.WriteLine("-------------- Bai 38--------------");
            Bai38.Output();
            Console.WriteLine("-------------- Bai 39--------------");
            Bai39.Output();
            Console.WriteLine("-------------- Bai 40--------------");
            Bai40.Output();

        }
    }
    class Bai32
    {
        public static void Output (){
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("n is an even number");
            }
            else
            {
                Console.WriteLine("n is an odd number");
            }
        }
       
    }
    class Bai33
    {
        public static void Output() {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("n is equal to 0");
            }
            else if (n < 0)
            {
                Console.WriteLine("n is a negative number");
            }
            else
            {
                Console.WriteLine("n is a positive number");
            }
        }
    }

    class Bai34
    {
        public static void Output()
        {
            Console.WriteLine("Enter the number a");

            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number b");
            int b = int.Parse(Console.ReadLine());
            if (a >= b)
            {
                Console.WriteLine("a is greater than or equal to b");
            }
            else
            {
                Console.WriteLine("a is smaller than b");
            }

        }
    }
    class Bai35
    {
        public static void Output()
        {
            Console.WriteLine("Enter the name1 : ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter the name2 : ");
            string name2 = Console.ReadLine();
            if (name1 == name2)
            {
                Console.WriteLine("two people have the same name");
            }
            else
            {
                Console.WriteLine("two people don't have the same name");
            }
        }
    }
    class Bai36
    {
        public static void Output()
        {

            Console.WriteLine("Enter the number a");

            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number b");
            int b = int.Parse(Console.ReadLine());
            if (a != 0 && b != 0)
            {
                Console.WriteLine("a is not equal to 0 and b is not equal to 0");
            }
            else
            {
                Console.WriteLine("a is equal to 0 or b is equal to 0");
            }

        }
    }
    class Bai37
    {
        public static void Output()
        {
            Console.WriteLine("Enter the number a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number c");
            int c = int.Parse(Console.ReadLine());
            if (a >= b && a >= c)
            {
                Console.WriteLine(a);
            }
            else if (b >= c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
    class Bai38
    {
        public static void Output()
        {
            Console.WriteLine("Enter the number a: ");
            int a = int.Parse(Console.ReadLine());
            if (a >= 10 && a <= 100)
            {
                Console.WriteLine(a + " is in the range [10, 100]");
            }
            else
            {
                Console.WriteLine(a + " is not in the range [10, 100]");
            }
        }
    }
    class Bai39
    {
        public static void Output()
        {
            Console.WriteLine("Enter the number score: ");
            int score = int.Parse(Console.ReadLine());
            if (score >= 0 && score <= 10)
            {
                Console.WriteLine("The score is valid");
            }
            else
            {
                Console.WriteLine("The score is not valid");
            }
        }
    }
    class Bai40
    {
        public static void Output()
        {
            Console.WriteLine("Enter the number a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number c");
            int c = int.Parse(Console.ReadLine());
            if (a <= b && b <= c)
            {
                Console.WriteLine("increasing");
            }
            else if (a >= b && b >= c)
            {
                Console.WriteLine("decreasing");
            }
            else
            {
                Console.WriteLine("neither increasing nor decreasing order");
            }
        }
    }
}
