namespace HrSystem.Services.SkillsAssessments
{
    using HrSystem.Data;
    using HrSystem.Models.Base;
    using ManagmentSystem.Data.Models;

    public class SkillsAssessmentsService : EntityBaseRepository<SkillsAssessment>, ISkillsAssessmentsService
    {
        public SkillsAssessmentsService(HrSystemDbContext data) : base(data) { }
    }
}
