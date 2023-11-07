using InsuranceApp.DTO;
using InsuranceApp.Exceptions;
using InsuranceApp.Models;
using InsuranceApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet("get")]
        public IActionResult Get()
        {
            List<AdminDto> adminDtos = new List<AdminDto>();
            var admins = _adminService.GetAll();
            if (admins.Count > 0)
            {
                foreach (var admin in admins)
                    adminDtos.Add(ConvertToDto(admin));
                return Ok(adminDtos);
            }

            throw new EntityNotFoundError("No admins created");
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var admin = _adminService.Get(id);
            if (admin != null)
                return Ok(ConvertToDto(admin));
            throw new EntityNotFoundError("No such admin found");
        }

        [HttpPost]
        public IActionResult Add(AdminDto adminDto)
        {
            var admin = ConvertToModel(adminDto);
            int id = _adminService.Add(admin);
            if (id != 0)
                return Ok(id);
            throw new EntityInsertError("Some issue while adding the admin");
        }

        [HttpPut]
        public IActionResult Update(AdminDto adminDto)
        {
            var existingAdmin = _adminService.Check(adminDto.AdminId);
            if (existingAdmin != null)
            {
                var admin = ConvertToModel(adminDto);
                var modifiedAdmin = _adminService.Update(admin);
                return Ok(ConvertToDto(modifiedAdmin));
            }
            throw new EntityNotFoundError("No such admin record exists");
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteById(int id)
        {
            var adminToDelete = _adminService.Check(id);
            if (adminToDelete != null)
            {
                _adminService.Delete(adminToDelete);
                return Ok(adminToDelete.AdminId);
            }
            throw new EntityNotFoundError("No such record exists");
        }

        private AdminDto ConvertToDto(Admin admin)
        {
            return new AdminDto()
            {
                AdminId = admin.AdminId,
                FirstName = admin.FirstName,
                LastName = admin.LastName,
                IsActive = admin.IsActive,
                UserId = admin.UserId
            };
        }

        private Admin ConvertToModel(AdminDto adminDto)
        {
            return new Admin()
            {
                AdminId = adminDto.AdminId,
                FirstName = adminDto.FirstName,
                LastName = adminDto.LastName,
                IsActive = adminDto.IsActive,
                UserId = adminDto.UserId
            };
        }
    }
}
    
