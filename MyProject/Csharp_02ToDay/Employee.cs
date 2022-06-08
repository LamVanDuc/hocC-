using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_02ToDay
{
    class Employee
    {
        private int empId;

        public Employee(int empId)
        {
            this.empId = empId;
        }
        public override string ToString()
        {
            return empId.ToString();
        }
    }

    class ObjectArray
    {
        public void Run()
        {
            int[] intArray;
            Employee[] empArray;
            intArray = new int[5];
            empArray = new Employee[3];

            for (int i = 0; i < empArray.Length ; i++)
            {
                empArray[i] = new Employee(i + 5);
            }

            Console.WriteLine("The int array ... ");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i].ToString());

            }
            Console.WriteLine("\nThe employee array ...");

            for (int i = 0; i < empArray.Length; i++)
            {
                Console.WriteLine(empArray[i].ToString());
            }
        }
    }


}
