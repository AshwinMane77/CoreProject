using CoreProject1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject1.Services
{
   public interface IEmployeeServices
    {
        Emplyees AddEmployee(Emplyees employee);

        List<Emplyees> GetEmployees();

        void UpdateEmployee(Emplyees employee);

        void DeleteEmployee(int Id);

        Emplyees GetEmployee(int Id);

        EmployeeSalary Savesalary(EmployeeSalary salary);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        EmployeeSalary GetEmployeebyEmail(string email);
    }
}
