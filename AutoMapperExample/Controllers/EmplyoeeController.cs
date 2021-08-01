using AutoMapperExample.Models;
using AutoMapperExample.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoMapperExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmplyoeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmplyoeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IEnumerable<EmployeeModel> Get()
        {
            var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new EmployeeModel
            //{
            //    Id = index,
            //    Title = $"Title {index}",
            //    Name = $"Name {index}",
            //    Age = rng.Next(18, 55),
            //    RegistrationDate = DateTime.Now.AddDays(-index),
            //})
            //.ToArray();

            return _employeeService.GetEmployees();
        }
    }
}
