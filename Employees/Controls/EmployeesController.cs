using Employees.Models;
using Employees.Models.Entities;
using Employees.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Controls
{
    public class EmployeesController : Controller
    {
        public IContentService contentService;
        EmployeeService service;
        public EmployeesController(EmployeeService service, IContentService contentService)
        {
            this.contentService = contentService;
            this.service = service;
        }

        [Route("")]
        [Route("index")]


        public IActionResult Index()
        {
            var employees = service.GetAllEmployees();
            return View(employees);
        }
        [Route("about")]

        public IActionResult About()
        {
            return View(service.GetAbout());
        }


        [Route("Create")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Route("Create")]
        [HttpPost]
        public IActionResult Create(EmployeeCreateVM employee)
        {
            if (!ModelState.IsValid)
            {
                return View(employee);
            }
            service.AddEmployee(employee);
            return RedirectToAction(nameof(Index));
        }

        [Route("index/{id}")]
        [HttpGet]

        public IActionResult Details(int Id)
        {
            var employee = service.GetEmployeeById(Id);
            return View(employee);
        }

        [Route("Delete/{id}")]
        [HttpGet]

        public IActionResult Delete(int Id)
        {
            service.DeleteById(Id);
            return RedirectToAction(nameof(Index));
        }
        [Route("Edit/{id}")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var employee = service.GetEmployeeById(id);
            EmployeeEditVM emp = new()
            {
                Name = employee.Name,
                Email = employee.Email
            };
            return View(emp);
        }

        [Route("Edit/{id}")]
        [HttpPost]
        public IActionResult Edit(EmployeeEditVM employee)
        {
            if (!ModelState.IsValid)
            {
                return View(employee);
            }
            service.Update(employee);
            return RedirectToAction(nameof(Index));
        }
    }
}
