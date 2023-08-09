using AutoMapper;
using Polly;
using PristineHRM.Models;
using PristineHRM.Repository;
using PristineHRM.Services.DTOs;

namespace PristineHRM.Services
{
    public class EmployeesService : IEmployeesService
    {
        public readonly EmployeesDbContext _emplyeeDbContext;
        private  IMapper _mapper;    
        public EmployeesService(IMapper mapper) { 
            _emplyeeDbContext = new EmployeesDbContext();  
            _mapper = mapper;
        }
        public List<Employee>? GetAll() {

            return _emplyeeDbContext.Emplyees.ToList();
        }

        public Employee? GetById(string empNo)
        {
            return _emplyeeDbContext.Emplyees.Where(emp => emp.empNo == empNo).First();
        }

        public bool Create(EmployeeDTO emplyeeDTO)
        {
            var emplyee = _mapper.Map<Employee>(emplyeeDTO);
            try
            {
                _emplyeeDbContext.Emplyees.Add(emplyee);
                _emplyeeDbContext.SaveChanges();
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }
        public Employee? Delete(string empNo)
        {
            var emplyee = GetById(empNo);
            if (emplyee != null)
            {
                _emplyeeDbContext.Remove(emplyee);
                _emplyeeDbContext.SaveChanges();
                return emplyee;
            }
            return null;
        }

        public Employee? Update(EmployeeUpdateDTO emplyeeUpdateDTO)
        {
            var existingEmployee = GetById(emplyeeUpdateDTO.empNo);
            if (existingEmployee != null) {
                if(emplyeeUpdateDTO.empName !=null) 
                { 
                    existingEmployee.empName = emplyeeUpdateDTO.empName;  
                }
                if (emplyeeUpdateDTO.empAddressLine1 != null)
                {
                    existingEmployee.empAddressLine1 = emplyeeUpdateDTO.empAddressLine1;
                }
                if (emplyeeUpdateDTO.empAddressLine2 != null)
                {
                    existingEmployee.empAddressLine2 = emplyeeUpdateDTO.empAddressLine2;
                }
                if (emplyeeUpdateDTO.empAddressLine3 != null)
                {
                    existingEmployee.empAddressLine3 = emplyeeUpdateDTO.empAddressLine3;  
                }
                if (emplyeeUpdateDTO.empDateOfJoin.HasValue)
                {
                    existingEmployee.empDateOfJoin =  emplyeeUpdateDTO.empDateOfJoin.Value;
                }
                if (emplyeeUpdateDTO.empStatus.HasValue)
                {
                    existingEmployee.empStatus = emplyeeUpdateDTO.empStatus.Value;
                }
                if (emplyeeUpdateDTO.empImage != null)
                {
                    existingEmployee.empImage = emplyeeUpdateDTO.empImage;
                }
            }

            _emplyeeDbContext.Update(existingEmployee);
            _emplyeeDbContext.SaveChanges();

            return existingEmployee;
        }
    }
}