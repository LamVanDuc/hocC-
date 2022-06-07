using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Bai27
    {
        public static void Output()
        {
            Console.WriteLine("enter the name :");
            string name = Console.ReadLine();
            Console.WriteLine("enter the age :");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("In 15 years, age of " + name + " will be " + (age + 15));
        }
    }
    class Bai28
    {
        public static void Output()
        {
            Console.WriteLine("enter the a :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the b :");
            int b = int.Parse(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("after swapping, a = " + a + ", b = " + b);
        }
    }
    class Bai29
    {
        public static void Output()
        {
            Console.WriteLine("Enter the radius :");
        
            double r = double.Parse(Console.ReadLine());
            double pi = 3.14;
            Console.WriteLine("Circumference = " + (2 * pi * r));
        }
    }
    class Bai30
    {
        public static void Output()
        {
            char c =(char)(char.Parse(Console.ReadLine())+1);
            Console.WriteLine(c);
        }

    }
    class Bai31
    {
        public static void Output()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a > b : "+(a > b));

        }
    }
}
