using FullStackApi.Data;
using FullStackApi.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FullStackApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private readonly FullStackDbContext _fullStackDbContext;
        public EmployeesController(FullStackDbContext fullStackDbContext)
        {
            _fullStackDbContext = fullStackDbContext;
        }
        [HttpGet]

        public async Task<IActionResult> GetAllEmployee()
        {
            var employees = await _fullStackDbContext.Employees.ToListAsync();
            return Ok(employees);
        }

        [HttpPost]

        public async Task<IActionResult> AddEmployees([FromBody] Employee employeeRequest)
        {
            employeeRequest.Id = Guid.NewGuid();

            await _fullStackDbContext.Employees.AddAsync(employeeRequest);
            await _fullStackDbContext.SaveChangesAsync();
            return Ok(employeeRequest);

        }

        

        //public async Task<IActionResult> UpdateEmployee([FromForm] Employee Employees, [FromRoute] int id)
        //{
        //    await _fullStackDbContext.Employees.UpdateEmployeeAsync(id, Employees);
        //    return Ok(Employees);
        //}

        //[HttpPatch("{id}")]

        //public async Task<IActionResult> UpdateEmployeePatch([FromRoute] int id, [FromBody] JsonPatchDocument Employees)
        //{
        //    await _fullStackDbContext.UpdateEmployeePatchAsync(id, Employees);
        //    return Ok();
        //}

        //[HttpDelete("{id}")]

        //public async Task<IActionResult> DeleteEmploee([FromRoute] int id)
        //{
        //    await _fullStackDbContext.DeleteEmployeeAsync(id);
        //    return Ok();
        //}
    }
}