using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PristineHRM.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string empNo { get; set; }

        [Required]
        [StringLength(100)]
        public string empName { get; set; }

        [Required]
        [StringLength(100)]
        public string empAddressLine1 { get; set; }


        [StringLength(100)]
        public string empAddressLine2 { get; set; }

        [StringLength(100)]
        public string empAddressLine3 { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime empDateOfJoin { get; set; }

        [Required]
        public bool empStatus { get; set; }

        [Required]
        public string empImage { get; set; }

    }
}