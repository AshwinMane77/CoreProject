﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject1.Models
{
    public class AuthContext : DbContext
    {
        public AuthContext(DbContextOptions<AuthContext> options)
    : base(options)
        {
        }

        public DbSet<Emplyees> employees { get; set; }

        public DbSet<Users> Users { get; set; }

        public DbSet<EmployeeSalary> employeeSalaries { get; set; }
    }
    //Developed by Ashwin
    //3.0/ee//ee//55
    //3.0/ee//ee//44
    //97changes//5566
    //Ram
}
