
namespace ManagmentSystem.Data.Models
{
    using HrSystem.Data.Base;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.SkillsAssessment;

    public class SkillsAssessment : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name and position is required !")]
        [MaxLength(AuthorNameMaxLength)]
        [Display(Name = "Assessor name and Department position")]
        public string AuthorName { get; set; }

        [Required]
        [Range(1,5, ErrorMessage = "Vote must be from 1 to 5. One is the worst and five is the best ")]
        [Display(Name = "Skills Vote")]
        public int SkillsRaiting { get; set; }

        [Required(ErrorMessage = "Must write a few words as feedback !")]
        [MaxLength(FeedBackMaxLength)]
        public string FeedBack { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}
