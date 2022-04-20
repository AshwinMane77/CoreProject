using CoreProject1.DTOClass;
using CoreProject1.Models;
using CoreProject1.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices _employeeService;
        public EmployeeController(IEmployeeServices employeeService)
        {
            _employeeService = employeeService;
        }

        //  [Authorize]
        [HttpGet]
        [Route("Get")]
        public string get()
        {
            return "Hello Ashwin Mane,You are connected now...";
        }
        //  [Authorize]
        [HttpPost]
        [Route("GetSalary")]
        public IActionResult getemloyesalary(employeeDTO em)
        {
            try
            {
                var salary = "Not found";

                if (em.joinDate > DateTime.Now)
                    return BadRequest("Joining date is wrong re");
                var emailCheck = _employeeService.GetEmployeebyEmail(em.Email);
                if (emailCheck != null || string.IsNullOrEmpty(em.Email))
                    return BadRequest("Email already exist or Enter correct email id.");
                
                if ((emailCheck == null))
                {
                    string y = "";
                    double z = 0.0, x = 0.0;
                    AccountServices ac = new AccountServices();
                    y = ac.save(em.name);
                    z = ac.CalculateSalary(em.perMonth, em.joinDate);
                    x = ac.CalculateAnnual(em.perMonth);
                    salary = y + z + " and Annual " + x;
                    EmployeeSalary es = new EmployeeSalary();
                    es.email = em.Email;
                    es.annualSalary = x;
                    es.perMonthSalary = em.perMonth;
                    _employeeService.Savesalary(es);
                    return Ok(salary);
                }
                return Ok(salary);

            }
            catch (Exception e)
            {
                string a = e.Message;
                return BadRequest(a);
            }

        }


        [HttpGet]
        [Route("GetAllEmployees")]
        public IEnumerable<Emplyees> GetEmployees()
        {
            return _employeeService.GetEmployees();
        }

        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult AddEmployee(Emplyees employee)
        {
            _employeeService.AddEmployee(employee);
            return Ok();
        }

        [HttpPost]
        [Route("UpdateEmployee")]
        public IActionResult UpdateEmployee(Emplyees employee)
        {
            _employeeService.UpdateEmployee(employee);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteEmployeeById")]
        public IActionResult DeleteEmployee(int id)
        {
            var existingEmployee = _employeeService.GetEmployee(id);
            if (existingEmployee != null)
            {
                _employeeService.DeleteEmployee(existingEmployee.Id);
                return Ok();
            }
            return NotFound($"Employee Not Found with ID : {existingEmployee.Id}");
        }

        //[Authorize]
        [HttpGet]
        [Route("GetEmployeeById")]
        public Emplyees GetEmployee(int id)
        {
            return _employeeService.GetEmployee(id);
        }


    }

}
