using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject1.Models
{
    public class EmployeeSalary
    {
        [Key]
        public int Id { get; set; }

        public string email { get; set; }

        public double perMonthSalary { get; set; }

        public double annualSalary { get; set; }
    }
}
