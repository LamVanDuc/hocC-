using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Bai21
    {
        public static void Output()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double gpa = double.Parse(Console.ReadLine());

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Grade Point Average: " + gpa);
            Console.ReadLine();
        }
    }
}
