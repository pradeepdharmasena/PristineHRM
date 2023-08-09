using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PristineHRM.Services.DTOs
{
    public class EmployeeUpdateDTO
    {
        public string empNo { get; set; }

        public string? empName { get; set; } = null!;

        public string? empAddressLine1 { get; set; } = null!;

        public string? empAddressLine2 { get; set; } = null!;

        public string? empAddressLine3 { get; set; } = null!;

        public DateTime? empDateOfJoin { get; set; } = null!;

        public bool? empStatus { get; set; } = null!;

        public string? empImage { get; set; } = null!;
    }
}
