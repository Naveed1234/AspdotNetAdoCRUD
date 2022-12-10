using Ado.net_CRUD.DAL;
using Ado.net_CRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ado.net_CRUD.Controllers
{
    [Route("api/Employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeDAL employee;

        public EmployeeController(EmployeeDAL _employee)
        {
            employee = _employee;
        }

        [HttpGet]
        [Route("getAllEmployee")]
        public IActionResult getAllEmployee()
        {
            var result = employee.GetAllEmployees();
            if (result == null)
            {
                return NotFound(new { message = "Employee is not exist in database" });
            }
            else
            {
                return Ok(result);
            }

        }

        [HttpGet]
        [Route("getAllEmployeeById")]
        public IActionResult GetEmployeeById(int id)
        {
            var result = employee.GetEmployeeById(id);
            if (result == null)
            {
                return NotFound(new { message = "Employee is not exist in database" });
            }
            else
            {
                return Ok(result);
            }

        }


        [HttpPost]
        [Route("addEmployee")]
        public IActionResult AddEmployee(Employee employeeObj)
        {
            var result = employee.AddEmployee(employeeObj);
            if (result == null)
            {
                return NotFound(new { message = "Employee is not exist in database" });
            }
            else
            {
                return Ok(new { message = "Employee is Added in database", result });
            }

        }

        [HttpPut]
        [Route("updateEmployee")]
        public IActionResult UpdateEmployee(Employee employeeObj)
        {
            var result = employee.UpdateEmployee(employeeObj);
            if (result == null)
            {
                return NotFound(new { message = "Employee is not exist in database" });
            }
            else
            {
                return Ok(new { message = "Employee is Update successfully", result });
            }

        }

        [HttpDelete]
        [Route("deleteEmployee")]
        public IActionResult DeleteEmployee(int id)
        {
            var result = employee.DeleteEmployee(id);
            if (result == null)
            {
                return NotFound(new { message = "Employee is not exist in database" });
            }
            else
            {
                return Ok(result);
            }

        }
      }
    }
