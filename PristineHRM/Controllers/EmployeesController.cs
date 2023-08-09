using Microsoft.AspNetCore.Mvc;
using PristineHRM.Services;
using PristineHRM.Services.DTOs;

namespace PristineHRM.Controllers
{
    [ApiController]
    [Route("employees")]
    public class EmployeesController : ControllerBase
    {
        public readonly IEmployeesService _emplyeeService;
        public EmployeesController(IEmployeesService emplyeesService)
        {
            _emplyeeService = emplyeesService;
        }

        [HttpPost]  
        public IActionResult Create(EmployeeDTO emplyeeDTO) 
        { 
           var result =  _emplyeeService.Create(emplyeeDTO);
            if (result)
            {
                return Created("SAVED", emplyeeDTO);
            }
            return BadRequest("EMPLYEE DID NOT SAVED");
        }

        [HttpGet]
        public IActionResult Get()
        {
            var employeesList = _emplyeeService.GetAll();
            if(employeesList is null)
            {
                return NotFound();
            }
            return Ok(employeesList);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var employee = _emplyeeService.GetById(id);
            if (employee is null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var result = _emplyeeService.Delete(id);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest("NO SUCH EMPLYEE");
        }

        [HttpPut]
        public IActionResult Update(EmployeeUpdateDTO emp)
        {
            var updatedEmplyee = _emplyeeService.Update(emp);
           
             return Ok(updatedEmplyee);
            
            
        }
    }
}