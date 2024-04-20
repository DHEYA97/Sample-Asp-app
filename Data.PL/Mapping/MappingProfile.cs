using AutoMapper;
using Data.DL.Model;
using Data.PL.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Data.PL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Department, DepartmentVM>().ReverseMap();
            CreateMap<Department, SelectListItem>()
                            .ForMember(des => des.Value, op => op.MapFrom(src => src.Id))
                            .ForMember(des => des.Text, op => op.MapFrom(src => src.Name));

            CreateMap<Employee, EmployeeVM>()
                .ForMember(e => e.Departments, op => op.Ignore())
                .ForMember(e => e.SelectedDepartments, op => op.Ignore())
                .ReverseMap();

        }

    }
}
