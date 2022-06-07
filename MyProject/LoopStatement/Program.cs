using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Bai49.Output();
            Console.ReadLine();

        }
    }
    class Bai41
    {
        public static void Output()
        {

            int i;
            Console.WriteLine("\nEnter the number : ");
            int n = int.Parse(Console.ReadLine());

            for( i = 0; i <=n; i++)
            {
                Console.Write(i + " ");
            }


            Console.ReadLine();

        }
    }
    class Bai42
    {
        public static void Output()
        {
            Console.WriteLine("Enter the number a : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number b : ");
            int b = int.Parse(Console.ReadLine());

            for(int i = a; i<=b; i++)
            {
                Console.Write(i + " ");
            }

        }
    }
    class Bai43
    {
        public static void Output()
        {
            Console.WriteLine("Enter the number : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i >= -n; i--)
            {
                Console.Write(i + " ");
            }
        }
    }
    class Bai44
    {
        public static void Output()
        {
            Console.WriteLine("enter the number a :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number b :");
            int b = int.Parse(Console.ReadLine());
            int answer = 0;

        for(int i = a; i <=b; i++)
            {
                
                answer = answer + i;
            }
            Console.WriteLine(answer);

        }
    }
    class Bai45
    {
        public static void Output()
        {
            int answer =0;
            Console.WriteLine("enter the number : ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 0; i <= n; i++)
            {
                if(i % 2 != 0)
                {
                    answer += i;
                }
            }
            Console.WriteLine(answer);
        }
    }
    class Bai46
    {
        public static void Output()
        {
            Console.WriteLine("enter the starting number : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the last number : ");
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
    class Bai47
    {
        public static void Output()
        {
            Console.WriteLine("Enter the number : ");
            int n = int.Parse(Console.ReadLine());
            int answer = 1;
            for (int i = 1; i <= n; i++)
            {
                answer *= i;
            }
            Console.Write(answer);
        }
    }
    class Bai48
    {
        public static void Output()
        {
            Console.WriteLine("Enter the number : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
    class Bai49
    {
        public static void Output()
        {
            int n=9;
            for(int i = 0; i <=n ; i++)
            {
                for(int j = 0; j <=i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");

            }
        }
    }
    
}
