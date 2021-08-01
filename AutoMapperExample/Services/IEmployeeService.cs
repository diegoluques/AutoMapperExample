using AutoMapperExample.Models;
using System.Collections.Generic;

namespace AutoMapperExample.Services
{
    public interface IEmployeeService
    {
        List<EmployeeModel> GetEmployees();
    }
}
