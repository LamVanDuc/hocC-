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
          
                InitProject();
                InitEmployee();


                foreach (var item in employees)
                {
                    Console.WriteLine(item.EmployeeId + " name : " + item.EmployeeName + " project ID" + item.ProjectId);
                }







            Console.ReadLine();
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
