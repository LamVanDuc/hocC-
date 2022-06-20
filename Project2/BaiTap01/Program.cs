using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap01
{
    class Program
    {
        public static SqlConnection connection = new SqlServerConnection().GetDataServer();
        public static List<Project> projects = new List<Project>();
        public static List<Employee> employees = new List<Employee>();
        static void Main(string[] args)
        {
            Program pro = new Program();
                InitProject();
                InitEmployee();

            try
            {

                while (true)
                {
                    Console.WriteLine("===========================================================");
                    Console.WriteLine("  1, Employee join Project");
                    Console.WriteLine("  2, Search employee by name or Project Name :");
                    Console.WriteLine("  3, Show ALL");
                    Console.WriteLine("  0, Exit !");
                    Console.Write("Choice : ");
                    int ch = int.Parse(Console.ReadLine());
                    Console.WriteLine("--------------------------------------");
                    switch (ch)
                    {
                        case 1:
                            pro.EmployeeJoinProject();
                            break;
                        case 2:
                            Console.Write("Enter Employee Name or project Name :");
                            string name = Console.ReadLine();
                            pro.SearchByName(name);
                            break;
                        case 3:
                            pro.ShowAll();
                            break;
                        case 0:
                          
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Da say ra loi : "+ex.Message);
            }
            Console.ReadLine();
        }


        public void ShowAll()
        {
            var query = EmployeeJoinProject();
            Console.WriteLine(string.Format("   {0,-9} {1}", "Employee", "Project Name"));
            Console.WriteLine("--------------------------------------------");
            foreach (var item in query)
            {
                Console.WriteLine(string.Format("  {0,-9} {1}",item.EmployeeName , item.ProjectName));

            }
            Console.WriteLine("-------------------- End --------------------");
        }


        public void SearchByName(string name)
        {
            int count = 0;
            var join = EmployeeJoinProject();

            Console.WriteLine(string.Format("   {0,-9} {1}", "Employee", "Project Name"));
            Console.WriteLine("--------------------------------------------");
            foreach (var item in join)
            {
                
                if (item.EmployeeName.Contains(name) || item.ProjectName.Contains(name))
                {
                    count = 1;
                    Console.WriteLine(string.Format("   {0,-9} {1}",item.EmployeeName,item.ProjectName));
                }
            }
            if (count == 0)
            {
                Console.WriteLine(string.Format("{0} not found !",name));
            }
            Console.WriteLine("-------------------- End --------------------");
        }



        public dynamic  EmployeeJoinProject()
        {
           var  employeeJoin = employees.Join(projects, emp => emp.ProjectId, pro => pro.ProjectId, (emp, pro) => 
                           new { emp.EmployeeName, pro.ProjectName });
            
            var employee = employeeJoin.OrderBy(e => e.EmployeeName);
         
           // var query = from emp in employees
                        //join pro in projects on emp.ProjectId equals pro.ProjectId
                        //select new{
                        //    pro.ProjectName,
                        //    emp.EmployeeName
                        //  };

            return employee;
        }

        public static void InitEmployee()
        {
            string query = "Select * from Employee";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                int EmployeeId = Convert.ToInt32(read[0]);
                string EmployeeName = Convert.ToString(read[1]);
                int ProjectId = Convert.ToInt32(read[2]);

                employees.Add(new Employee() {EmployeeId = EmployeeId, EmployeeName = EmployeeName , ProjectId = ProjectId });
            }
            connection.Close();
        }
        public static void InitProject()
        {
            string query = "Select * from Project";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int projectId = Convert.ToInt32(reader[0]);
                string projectName = Convert.ToString(reader[1]);

                projects.Add(new Project() { ProjectId = projectId, ProjectName = projectName });

            }
            connection.Close();
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
