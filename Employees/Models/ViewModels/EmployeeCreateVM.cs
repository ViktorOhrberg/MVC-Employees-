using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Models.ViewModels
{
    public class EmployeeCreateVM
    {
        [Display(Name = "Name: ")]
        [Required(ErrorMessage = "Enter a first name")]
        public string Name { get; set; }

        [Display(Name = "E-mail: ")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "What is 2+2: " )]
        [Required(ErrorMessage = "Field can not be left empty")]
        [Range(4,4)]

        public int BotCheck { get; set; }

    }
}
