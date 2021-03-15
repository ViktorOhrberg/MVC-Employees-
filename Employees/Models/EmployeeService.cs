using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Models
{
    public class EmployeeService
    {
        public List<Employee> Employees = new();
        static int noOfEmployee = 1;
        public void AddEmployee(Employee employee)
        {
            employee.Id = noOfEmployee;
            noOfEmployee++;
            employee.TimeOfEmployment = DateTime.Now;
            Employees.Add(employee);
        }
        public Employee[] GetAllEmployees()
        {
            return Employees
                .ToArray();
        }
        public Employee GetEmployeeById(int id)
        {
            return Employees
                .Where(x => x.Id == id)
                .Single();
        }

        public void DeleteById(int id)
        {
            var employee = GetEmployeeById(id);
            Employees.Remove(employee);
        }

        public void Update(Employee employee)
        {
            var empToEdit = GetEmployeeById(employee.Id);
            empToEdit.Name = employee.Name;
            empToEdit.Email = employee.Email;
        }
    }
}
