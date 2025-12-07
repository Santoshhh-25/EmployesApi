using EmployesApi.Data;
using EmployesApi.Models;
using EmployesApi.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace EmployesApi.Controllers
{
    //localhost/api/employee
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //get all employees;
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var allEmployees = dbContext.Employees.ToList();
            return Ok(allEmployees);
        }


        //add new employee;
        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDto addEmployeeDto)
        {
            var employeeEntity = new Employee()
            {
                Name = addEmployeeDto.Name,
                Email = addEmployeeDto.Email,
                Phone = addEmployeeDto.Phone,
                Salary = addEmployeeDto.Salary
            };

            dbContext.Employees.Add(employeeEntity);
            dbContext.SaveChanges();
            return Ok(employeeEntity);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult getEmployeeById(Guid id)
        {
            var employee = dbContext.Employees.Find(id);
            if(employee == null)
            {
                return NotFound();
            } else return Ok(employee);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateEmployee(Guid id, UpdateEmpoyeeDto updateEmpoyeeDto )
        {
            var Employee = dbContext.Employees.Find(id);
            if(Employee == null)
            {
                return NotFound();
            }
            Employee.Name = updateEmpoyeeDto.Name;
            Employee.Email = updateEmpoyeeDto.Email;
            Employee.Phone = updateEmpoyeeDto.Phone;
            Employee.Salary = updateEmpoyeeDto.Salary;

            dbContext.SaveChanges();
            return Ok(Employee);
        }


        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult deleteEmployee(Guid id)
        {
            var employee = dbContext.Employees.Find(id);
            if(employee == null)
            {
                return NotFound();
            }
            dbContext.Employees.Remove(employee);
            dbContext.SaveChanges();
            return Ok("Deleted Sucessfully" + employee);
        }
    }
}
