using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopWhileAndDo_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Bai57.Output();
            Console.ReadLine();
        }
    }
    class Bai50
    {
        public static void Output()
        {
            int n = 5;
            while (n != 0)
            {
                Console.Write(n + " ");
                n--;
            }
        }
    }
    class Bai51
    {
        public static void Output()
        {
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int answer = 0;
            while (i <= n)
            {
                if (n % i == 0)
                {
                    answer++;
                }
                i++;
            }
            Console.Write(answer);
        }
    }

    class Bai52
    {
        public static void Output()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int answer = 1;
            while (b > 0)
            {
                answer *= a;
                b--;
            }
            Console.Write(answer);
        }
    }

    class Bai53
    {
        public static void Output()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
    class Bai54
    {
        public static void Output()
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i == 11)
                {
                    break;
                }
                Console.Write(i + " ");
            }
        }
    }
    class Bai55
    {
        public static void Output()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
        }
    }
    class Bai56
    {
        public static void Output()
        {
            int i = 1;
            do
            {
                Console.Write("do-while");
            } while (i < 1);

            while (i < 1)
            {
                Console.Write("while");
            }
        }
    }

    class Bai57
    {
        public static void Output()
        {
            int i = 1;
            do
            {
                if (i % 10 == 0)
                {
                    Console.Write(i + " ");
                }
                i++;
            } while (i <= 1000);
        }
    }
}
    

