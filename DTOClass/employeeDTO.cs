using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject1.DTOClass
{
    public class employeeDTO
    {
        public string name  { get; set; }

        public double perMonth { get; set; }
        public DateTime joinDate { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
    }
}
