using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject1.Models
{
    public class Emplyees
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string address { get; set;}

        public double salary { get; set; }

        public int age { get; set; }
    }
}
