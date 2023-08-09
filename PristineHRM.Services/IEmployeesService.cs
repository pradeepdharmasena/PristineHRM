using PristineHRM.Models;
using PristineHRM.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PristineHRM.Services
{
    public interface IEmployeesService
    {
        public List<Employee>? GetAll();

        public Employee? GetById(string empNo);

        public bool Create(EmployeeDTO emplyeeDTO);

        public Employee? Update(EmployeeUpdateDTO emplyeeUpdateDTO);

        public bool Delete(string empNo);
    }
}
