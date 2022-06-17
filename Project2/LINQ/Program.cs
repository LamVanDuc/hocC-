using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = { new Employee(1, "khoi", 18),
        new Employee(2, "Minh", 60),
        new Employee(3, "hai", 50),
        new Employee(4, "long", 11),
        new Employee(5, "nam", 3),
        new Employee(6, "hoang", 22),
        new Employee(7, "nhat", 32),};


            var empQ1 = from emp in employees where emp.EmployeeName.StartsWith("n") select emp;
            var empQ2 = employees.Where(e => e.EmployeeName.StartsWith("h"));

            //sap sep OrderBy() , default : giam dan  | OrderByDescending : giam dan
            // sap sep giam dan 
            var empQ3 = employees.OrderByDescending(e => e.EmployeeName);
            // sap sep tang dan
            employees.OrderBy(e => e.EmployeeName);

            // groupBy
            var ep = employees.GroupBy(e => e.EmployeeName);
            foreach (var item in ep)
            {
                Console.WriteLine(item.Key);
            }


            var itemEmployye = employees.Where(e => e.Age > 18 && e.Age < 60);




            Console.ReadLine();
        }

    }

    class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }

        public Employee(int id, string name, int age)
        {
            this.EmployeeId = id;
            this.EmployeeName = name;
            this.Age = age;
        }
    }
}
    }
}
