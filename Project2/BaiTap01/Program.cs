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

                    Console.WriteLine("1, Employee join Project");
                    Console.WriteLine("2, ");
                    Console.WriteLine("3, ");
                    Console.WriteLine("4, ");
                    Console.WriteLine("5, ");
                    Console.WriteLine("6, ");
                    int ch = int.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            pro.EmployeeJoinProject();
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
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
        public void EmployeeJoinProject()
        {
            var employeeJoin = employees.Join(projects, emp => emp.ProjectId, pro => pro.ProjectId, (emp, pro) => new { emp.EmployeeName, pro.ProjectName });
            foreach (var item in employeeJoin)
            {
                Console.WriteLine(item.EmployeeName +"  Project Name : "+ item.ProjectName);
            }
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
