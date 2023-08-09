using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PristineHRM.Services.DTOs
{
    public class EmployeeDTO
    {

        public string empNo { get; set; }

        public string empName { get; set; }

        public string empAddressLine1 { get; set; }

        public string empAddressLine2 { get; set; }

        public string empAddressLine3 { get; set; }

        public DateTime empDateOfJoin { get; set; }

        public bool empStatus { get; set; }

        public string empImage { get; set; }
    }
}
