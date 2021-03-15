using Employees.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Controls
{
    public class EmployeesController : Controller
    {
        IContentService contentService;
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
            return View(contentService);
        }


        [Route("Create")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Route("Create")]
        [HttpPost]
        public IActionResult Create(Employee employee)
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
            return View(employee);
        }

        [Route("Edit/{id}")]
        [HttpPost]
        public IActionResult Edit(Employee employee)
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
