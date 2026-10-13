using AutoMapper;
using CompanySystem.DTOs;
using CompanySystem.Models;
using CompanySystem.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanySystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private IUnitOfWork unitOfWork;
        private IMapper mapper;
        public DepartmentsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetDepartmentsAsync()
        {
            var depts= await unitOfWork.Departments.GetAll();
            List<DepartmentDTO> deptsDTO = new List<DepartmentDTO>();
            foreach (Department dept in depts)
            {
                DepartmentDTO deptt = mapper.Map<DepartmentDTO>(dept);
                deptsDTO.Add(deptt);
            }
            return Ok(deptsDTO);
        }
    }
}
