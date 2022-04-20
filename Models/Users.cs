using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject1.Models
{
    public class Users
    {
        /// </summary>
        [Key]
        public int id { get; set; }
        /// <summary>
        /// FirstName
        /// </summary>
        [Required]
        public string UserName { get; set; }

        /// <summary>
        /// Password
        /// </summary>       
        public string Password { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
    }
}
