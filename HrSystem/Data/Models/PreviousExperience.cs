namespace ManagmentSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.PreviousExperience;

    public class PreviousExperience
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(EmployeerLength)]
        [Display(Name = "Company name")]
        public string Employeer { get; set; }

        [MaxLength(PositionNameLength)]
        [Display(Name = "Department and position in previous company")]
        public string PositionName { get; set; }

        [MaxLength(RecomendationLetterLength)]
        [Display(Name = "Feedback from previous company")]
        public string RecomendationLetter { get; set; }

        public int EmployeeDetailsId { get; set; }

        public EmployeeDetails EmployeeDetails { get; set; }
    }
}
