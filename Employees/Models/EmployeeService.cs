using Employees.Models.ViewModels;
using Employees.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employees.Models.Entities;

namespace Employees.Models
{
    public class EmployeeService
    {
        //public List<Employee> Employees = new();
        IContentService contentService;
        private MyContext myContext;

        public EmployeeService(IContentService contentService, MyContext myContext)
        {
            this.contentService = contentService;
            this.myContext = myContext;
        }

        public void AddEmployee(EmployeeCreateVM employee)
        {
            myContext.Employees.Add(new Employee
            {
                Name = employee.Name,
                Email = employee.Email,
            });
            myContext.SaveChanges();
        }
        public bool checkMail(string mail)
        {
            return mail.StartsWith("admin");
        }

        public EmployeeIndexVM[] GetAllEmployees()
        {
            return myContext.Employees.Select(x => new EmployeeIndexVM
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                ShowAsHighlighted = x.Email.ToLower().StartsWith("admin")
            })
                .ToArray();
        }

        public Employee GetEmployeeById(int id)
        {
            return myContext.Employees.Find(id);
        }

        public void DeleteById(int id)
        {
            var employee = GetEmployeeById(id);
            myContext.Employees.Remove(employee);
            myContext.SaveChanges();
        }

        public void Update(EmployeeEditVM employee)
        {
            var tempEmp = GetEmployeeById(employee.Id);
            tempEmp.Name = employee.Name;
            tempEmp.Email = employee.Email;
            myContext.SaveChanges();
        }
        public AboutVM GetAbout()
        {
            return new AboutVM { Header = contentService.GetHeader(), Body = contentService.GetBody(), ListEmp = GetAllEmployees().Select(o => o.Name).ToArray() };
        }
    }
}
