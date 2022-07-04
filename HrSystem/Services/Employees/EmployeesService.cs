namespace HrSystem.Services.Employees
{
    using HrSystem.Data;
    using HrSystem.Models.Base;
    using HrSystem.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class EmployeesService : EntityBaseRepository<Employee>, IEmployeesService
    {
        public EmployeesService(HrSystemDbContext data) : base(data) { }
    }
}
