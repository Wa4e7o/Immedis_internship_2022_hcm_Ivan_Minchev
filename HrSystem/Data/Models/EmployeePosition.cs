
namespace ManagmentSystem.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.EmployeePosition;

    public class EmployeePosition
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(PositionMaxLength)]
        [Display(Name = "Position")]
        public string PositionName { get; set; }

        [Required]
        [MaxLength(DepartmentMaxLength)]
        [Display(Name = "Department")]
        public string DepartmentName { get; set;}

        [Required]
        public double Salary { get; set; }

        public List<EmployeeDetails> EmployeeRecords { get; set; }
    }
}
