using System;
using System.Collections.Generic;

#nullable disable

namespace Employees.Models.Entities
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
