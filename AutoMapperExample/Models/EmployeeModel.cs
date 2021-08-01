using AutoMapper;
using AutoMapperExample.Domain;
using AutoMapperExample.Mappings;
using System;

namespace AutoMapperExample.Models
{
    public class EmployeeModel : IMapFrom<Employee>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string WorkAddress { get; set; }

        public void Mapping(Profile profile)
        {
            var c = profile.CreateMap<Employee, EmployeeModel>()
                .ForMember(d => d.RegistrationDate, op => op.Ignore())
                .ForMember(d => d.Title, opt => opt.NullSubstitute("N/A"))
                .ForMember(d => d.WorkAddress, opt => opt.MapFrom(s => s.OfficeAddress));;
        }
    }
}
