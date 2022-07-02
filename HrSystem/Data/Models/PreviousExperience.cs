namespace ManagmentSystem.Data.Models
{
    using HrSystem.Data.Base;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.PreviousExperience;

    public class PreviousExperience : IEntityBase
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

        public int EmployeеId { get; set; }

        public Employee Employee { get; set; }
    }
}
