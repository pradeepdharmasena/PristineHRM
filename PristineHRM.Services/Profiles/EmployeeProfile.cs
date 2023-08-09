using AutoMapper;
using PristineHRM.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PristineHRM.Models.Profiles
{
    public class EmployeeProfile:Profile
    {
        public EmployeeProfile() 
        {
            CreateMap<Employee, EmployeeDTO>();

            CreateMap<EmployeeDTO, Employee>();
        } 
    }
}
