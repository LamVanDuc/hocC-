using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ02
{
    class Program
    {
        public static List<Employee> listEmployee = new List<Employee>();
        public static List<Project> listProject = new List<Project>();
        static void Main(string[] args)
        {
            InitProject();
            InitEmployee();

            var group = from em in listEmployee
                        group em by em.ProjectId;

            foreach (var item in group)
            {
                Console.WriteLine("key : " + item.Key + "  Count:" + item.Count());
            }

            var queryJoin = from emp in listEmployee
                            join pro in listProject on emp.ProjectId equals pro.ProjectId
                            select new { emp.EmployeeName, pro.ProjectName };

            var query = listEmployee.Join(listProject, emp => emp.ProjectId, pro => pro.ProjectId, (emp, pro) => { return emp.EmployeeName + pro.ProjectName;});

            var query1 = listEmployee.Join(listProject, emp => emp.ProjectId, pro => pro.ProjectId, (emp, pro) => new { emp.EmployeeName , pro.ProjectName });


            foreach (var item in queryJoin)
            {
                Console.WriteLine(item.EmployeeName +"    -    "+item.ProjectName);
            }


            Console.ReadLine();
        }

        public static void InitProject()
        {
            listProject.Add(new Project() {ProjectId = 1 , ProjectName= "VNPT"});
            listProject.Add(new Project() { ProjectId = 2, ProjectName = "MB bank" });
            listProject.Add(new Project() { ProjectId = 3, ProjectName = "ABC" });
            listProject.Add(new Project() { ProjectId =4, ProjectName = "Vin Group" });
            listProject.Add(new Project() { ProjectId = 5, ProjectName = "AgriBank" });

        }
        public static void InitEmployee()
        {
            listEmployee.Add(new Employee() { EmployeeId = 101, EmployeeName = "Khoi", ProjectId = 1 });
            listEmployee.Add(new Employee() { EmployeeId = 102, EmployeeName = "Nam", ProjectId = 2 });
            listEmployee.Add(new Employee() { EmployeeId = 103, EmployeeName = "Thanh", ProjectId = 3 });
            listEmployee.Add(new Employee() { EmployeeId = 104, EmployeeName = "Hai", ProjectId = 4 });
            listEmployee.Add(new Employee() { EmployeeId = 105, EmployeeName = "Hoang", ProjectId = 3 });
            listEmployee.Add(new Employee() { EmployeeId = 106, EmployeeName = "Viet", ProjectId = 1 });
            listEmployee.Add(new Employee() { EmployeeId = 107, EmployeeName = "Minh", ProjectId = 2 });
            listEmployee.Add(new Employee() { EmployeeId = 108, EmployeeName = "Hong", ProjectId = 3 });
            listEmployee.Add(new Employee() { EmployeeId = 109, EmployeeName = "Khoa", ProjectId = 4 });
            listEmployee.Add(new Employee() { EmployeeId = 100, EmployeeName = "Hai", ProjectId = 5 });
            listEmployee.Add(new Employee() { EmployeeId = 1010, EmployeeName = "Thanh", ProjectId = 1 });
            listEmployee.Add(new Employee() { EmployeeId = 1012, EmployeeName = "Van", ProjectId = 2 });
            listEmployee.Add(new Employee() { EmployeeId = 1011, EmployeeName = "Huong", ProjectId = 3 });

        }
    }

    class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int ProjectId { get; set; }
    }

    class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
    }
}
