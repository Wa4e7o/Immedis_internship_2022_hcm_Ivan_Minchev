using HrSystem.Models.Base;
using HrSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Services.Employees
{
    public interface IEmployeesService : IEntityBaseRepository<Employee>
    {
    }
}
