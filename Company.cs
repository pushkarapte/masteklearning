using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    public class Company
    {
        private List<Employee> listEmployees;
        public Company()
        {
            listEmployees = new List<Employee>();
            listEmployees.Add(new Employee { EmployeeId = 1, Name = "Pushkar", Gender = "Male" });
            listEmployees.Add(new Employee { EmployeeId = 2, Name = "Payal", Gender = "Female" });
            listEmployees.Add(new Employee { EmployeeId = 3, Name = "Harsh", Gender = "Male" });
        }
        
        public string this[int EmployeeId]
        {
            get
            {
                return this.listEmployees.FirstOrDefault(emp => emp.EmployeeId == EmployeeId).Name;
            }
            set
            {
                listEmployees.FirstOrDefault(emp => emp.EmployeeId == EmployeeId).Name = value;
            }
        }
    
        }
}
