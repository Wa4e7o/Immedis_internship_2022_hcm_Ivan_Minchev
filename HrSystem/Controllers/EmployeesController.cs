namespace HrSystem.Controllers
{
    using HrSystem.Services.Employees;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class EmployeesController : Controller
    {
        private readonly IEmployeesService _data;

        public EmployeesController(IEmployeesService data)
        {
            this._data = data;
        }

        public async Task<IActionResult> Index()
        {
            var allActiors = await _data.GetAllAsync();
            return View(allActiors);
        }
    }
}
