using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Bai25
    {
        public static void Output()
        {
            Console.WriteLine("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("a % b = "+a % b);
            Console.WriteLine("a % b =" +(a-b * (a/b)));


        }
    }
}
