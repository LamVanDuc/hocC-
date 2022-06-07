using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Bai24
    {
        public static void Output()
        {

            Console.WriteLine("Enter the length : ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width : ");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Area : "+length * width);
        }
    }
}
