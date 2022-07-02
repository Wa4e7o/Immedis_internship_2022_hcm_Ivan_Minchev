using HrSystem.Data;
using HrSystem.Models.Base;
using ManagmentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Services.Employees
{
    public class EmployeesService : EntityBaseRepository<Employee>, IEmployeesService
    {
        public EmployeesService(HrSystemDbContext data) : base(data) { }
    }
}
