namespace HrSystem.Data.Models
{
    using HrSystem.Data.Base;
    using HrSystem.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static DataConstants.Employee;

    public class Employee : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required !")]
        [MaxLength(NameMaxLength)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required !")]
        [MaxLength(NameMaxLength)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Profil picture is required !")]
        [Display(Name = "Profil Picture")]
        public string ImageURL { get; set; }

        [Required(ErrorMessage = "Full address is required !")]
        [MaxLength(AddressMaxLength)]
        [Display(Name = "Current address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Age is Required")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Medical status is required !")]
        [MaxLength(MedicalStautsMaxLength)]
        [Display(Name = "Description of Healt Condition")]
        public string MedicalStauts { get; set; }

        [Required(ErrorMessage = "Telephone number is required !")]
        [MaxLength(PhoneNumberMaxLength)]
        [Display(Name = "Telephone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email is required !")]
        public string Email { get; set; }

        public DateTime StartDate { get; set; }

        [MaxLength(SkillsAssessmantLength)]
        [Display(Name = "Еmployee notes")]
        public string SkillsAssessment { get; set; }

        public int? PositionId { get; set; }

        [ForeignKey("PositionId")]
        public Position Position { get; set; }

        public int? PreviousExperienceId { get; set; }

        [ForeignKey("PreviousExperienceId")]
        public PreviousExperience PreviousExperience { get; set; }
    }
}
