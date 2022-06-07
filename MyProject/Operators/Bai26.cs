using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Bai26
    {
        public static void Output()
        {
            Console.WriteLine("enter the a :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the b :");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a / b = " + (a / b));
            Console.WriteLine("a % b = " + (a % b));
        }
    }
}
