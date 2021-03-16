using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Models.ViewModels
{
    public class EmployeeIndexVM
    {
        public int Id { get; set; }

        [Display(Name = "Name: ")]
        public string Name { get; set; }

        [Display(Name = "E-mail: ")]
        public string Email { get; set; }
        public bool ShowAsHighlighted { get; set; }
    }
}
