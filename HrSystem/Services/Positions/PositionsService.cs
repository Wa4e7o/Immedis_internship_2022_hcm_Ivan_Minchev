using HrSystem.Data;
using HrSystem.Models.Base;
using ManagmentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Services.Positions
{
    public class PositionsService : EntityBaseRepository<Position>, IPositionsService
    {
        public PositionsService(HrSystemDbContext data) : base(data) { }
    }
}
