using System.Collections.Generic;

namespace S2Ex1
{
    public class Company
    {
        public List<Employee> Employees { get; set; } = new List<Employee>(); 
        

        public double GetMonthlySalaryTotal()
        {
            double counter = 0;
            foreach (Employee employee in Employees)
            {
                counter += employee.GetMonthlySalary();
            }

            return counter;
        }

        public void HireNewEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
    }
}