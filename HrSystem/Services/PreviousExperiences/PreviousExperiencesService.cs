namespace HrSystem.Services.PreviousExperiences
{
    using HrSystem.Data;
    using HrSystem.Models.Base;
    using HrSystem.Data.Models;

    public class PreviousExperiencesService : EntityBaseRepository<PreviousExperience>, IPreviousExperiencesService
    {
        public PreviousExperiencesService(HrSystemDbContext data) : base(data) { }
    }
}
