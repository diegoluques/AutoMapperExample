using AutoMapper;
using AutoMapperExample.Domain;
using AutoMapperExample.Models;
using System;
using System.Collections.Generic;

namespace AutoMapperExample.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IMapper _mapper;

        public EmployeeService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<EmployeeModel> GetEmployees()
        {
            var employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Title = "Mr",
                    Name = "Diego",
                    Age = 27,
                    RegistrationDate = DateTime.Now.AddDays(-150),
                },
                new Employee()
                {
                    Id = 2,
                    Name = "Patricia",
                    Age = 22,
                    RegistrationDate = DateTime.Now.AddDays(-100),
                    OfficeAddress = "Rua do bem ali"
                },
                new Employee()
                {
                    Id = 3,
                    Title = "Mr",
                    Name = "Diogo",
                    Age = 29
                }
            };

            return _mapper.Map<List<EmployeeModel>>(employees);
        }
    }
}
