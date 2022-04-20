using CoreProject1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject1.Services
{
    public class EmployeeService : IEmployeeServices
    {
        /// <summary>
        /// _employeeDbContext
        /// </summary>
        public AuthContext _employeeDbContext;
        public EmployeeService(AuthContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }
        public Emplyees AddEmployee(Emplyees employee)
        {
            _employeeDbContext.employees.Add(employee);
            _employeeDbContext.SaveChanges();
            return employee;
        }
        public List<Emplyees> GetEmployees()
        {
            return _employeeDbContext.employees.ToList();
        }

        public void UpdateEmployee(Emplyees employee)
        {
            _employeeDbContext.employees.Update(employee);
            _employeeDbContext.SaveChanges();
        }

        public void DeleteEmployee(int Id)
        {
            var employee = _employeeDbContext.employees.FirstOrDefault(x => x.Id == Id);
            if (employee != null)
            {
                _employeeDbContext.Remove(employee);
                _employeeDbContext.SaveChanges();
            }
        }

        public Emplyees GetEmployee(int Id)
        {
            return _employeeDbContext.employees.FirstOrDefault(x => x.Id == Id);
        }

        public  EmployeeSalary Savesalary(EmployeeSalary salary )
        {
            _employeeDbContext.employeeSalaries.Add(salary);
            _employeeDbContext.SaveChanges();
            return salary;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public EmployeeSalary GetEmployeebyEmail(string email)
        {
            return _employeeDbContext.employeeSalaries.FirstOrDefault(x => x.email == email);
        }
    }
}
