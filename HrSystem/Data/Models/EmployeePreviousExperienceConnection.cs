using ManagmentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Data.Models
{
    public class EmployeePreviousExperienceConnection
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int PreviousExperienceId { get; set; }
        public PreviousExperience PreviousExperience { get; set; }
    }
}
