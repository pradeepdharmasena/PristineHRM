using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PristineHRM.Services;
using PristineHRM.Services.DTOs;
using System.Collections.ObjectModel;

namespace PristineHRM.Controllers
{
    [ApiController]
    [Route("employees")]
    public class EmployeesController : ControllerBase
    {
        public readonly IEmployeesService _emplyeeService;
        public IMapper _mapper;
        public EmployeesController(IEmployeesService emplyeesService, IMapper mapper)
        {
            _emplyeeService = emplyeesService;
            _mapper = mapper;
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
            var empDTOList = _mapper.Map<Collection<EmployeeDTO>>(employeesList);
            return Ok(empDTOList);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var employee = _emplyeeService.GetById(id);
            if (employee is null)
            {
                return NotFound();
            }
            var empDTO = _mapper.Map<EmployeeDTO>(employee);
            return Ok(empDTO);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var emp = _emplyeeService.Delete(id);
            if (emp is null)
            {
                return BadRequest("NO SUCH EMPLYEE");
                
            }
            var empDTO = _mapper.Map<EmployeeDTO>(emp);
            return Ok(empDTO);

        }

        [HttpPut]
        public IActionResult Update(EmployeeUpdateDTO emp)
        {
            var updatedEmplyee = _emplyeeService.Update(emp);
            var empDTO = _mapper.Map<EmployeeDTO>(updatedEmplyee);
           
             return Ok(empDTO);
            
            
        }
    }
}