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


            Title[] title = {new Title( 2,"truong phong"),
            new Title(1,"Nhan vien")};


            Employee[] employees = { new Employee(1, "khoi", 18,1),
        new Employee(2, "Minh", 60,1),
        new Employee(3, "hai", 50,1),
        new Employee(4, "long", 11,2),
        new Employee(5, "nam", 3,2),
        new Employee(6, "hoang", 22,1),
        new Employee(7, "nhat", 32,1),};

            // tra ve kieu list 
            List<Employee> emplist = (employees.Where(e => e.Age > 20)).ToList(); //Tolist de ep kieu 
            // SELECT 
           var select =  employees.Select(e => { return  e.EmployeeName +" "+ e.Age; });
            var wheres = select.Where(e => e.Contains("Minh"));
  
            // WHERE
           var where = employees.Where(e => e.EmployeeName.Equals("Minh"));

            //ORDERBY
            var asc = employees.OrderBy(e => e.EmployeeName);
            var desc = employees.OrderByDescending(e=>e.EmployeeName);

            //GROUPBY (employee name)
            var groupBy = employees.GroupBy(e=>e.EmployeeName); // theo tên

            // MIN , MAX , SUM, AVERAGE
            int[] numbers = {1,2,4,6,8,11,22,98 };
            var min = numbers.Min();
            var max = numbers.Max();
            var sum = numbers.Sum();
            var average = numbers.Average();





            var maxAge = employees.Max(e => e.Age); 

            // que ry 
            var empQ1 = from emp in employees where emp.EmployeeName.StartsWith("n") select emp;//StartWith tương đương Like 'n%'



            var empQ2 = employees.Where(e => e.EmployeeName.StartsWith("h"));

            //sap sep OrderBy() , default : giam dan  | OrderByDescending : giam dan
            // sap sep giam dan 
            var empQ3 = employees.OrderByDescending(e => e.EmployeeName); // theo ten
            // sap sep tang dan
            employees.OrderBy(e => e.EmployeeName); // theo ten 

            // groupBy
            var ep = employees.GroupBy(e => e.EmployeeName);

            var group = from em in employees
                        group em by em.EmployeeId;
            // join 

            var join = employees.Join(title,
                e => e.IdRoll,
                t => t.IdRoll,
                (e, t) => {
                return e.EmployeeName + "chuc vu : " + t.NameRoll;
            });



            foreach (var item in join)
            {
                Console.WriteLine(item);
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
        public int IdRoll { get; set; }

        public Employee(int id, string name, int age)
        {
            this.EmployeeId = id;
            this.EmployeeName = name;
            this.Age = age;
        }
        public Employee(int id, string name, int age , int idRoll)
        {
            this.EmployeeId = id;
            this.EmployeeName = name;
            this.Age = age;
            this.IdRoll = idRoll;
        }
    }

    class Title
    {
        public int IdRoll { get; set; }
        public string NameRoll { get; set; }
        public Title(int idRoll , string NameRoll)
        {
            this.IdRoll = idRoll;
            this.NameRoll = NameRoll;
     
        }
        
    }
}
    

