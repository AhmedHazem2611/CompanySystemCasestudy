using AutoMapper;
using CompanySystem.DTOs;
using CompanySystem.Models;

namespace CompanySystem.Profiles
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<Department, DepartmentDTO>();
            CreateMap<UpdateDepartmentDTO, Department>();
        }
    }
}
