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
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            List<UserDto> userDtos = new List<UserDto>();
            var users = _userService.GetAll();
            if (users.Count > 0)
            {
                foreach (var user in users)
                    userDtos.Add(ConvertToDto(user));
                return Ok(userDtos);
            }
            throw new EntityNotFoundError("No users created");
        }
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.Get(id);
            if (user != null)
                return Ok(ConvertToDto(user));
            throw new EntityNotFoundError("No such user found");
        }
        [HttpPost]
        public IActionResult Add(UserDto userDto)
        {
            var user = ConvertToModel(userDto);
            int id = _userService.Add(user);
            if (id != null)
                return Ok(id);
            throw new EntityInsertError("Some issue while adding record");
        }
        [HttpPut]
        public IActionResult Update(UserDto userDto)
        {
            var existingUser = _userService.Check(userDto.UserId);
            if (existingUser != null)
            {
                var user = ConvertToModel(userDto);
                var modifiedUser = _userService.Update(user);
                return Ok(ConvertToDto(modifiedUser));
            }
            throw new EntityNotFoundError("No such record exists");
        }
        [HttpDelete("{id:int}")]
        public IActionResult DeleteById(int id)
        {
            var userToDelete = _userService.Check(id);
            if (userToDelete != null)
            {
                _userService.Delete(userToDelete);
                return Ok(userToDelete.UserId);
            }
            throw new EntityNotFoundError("No such record exists");
        }
        private UserDto ConvertToDto(User user)
        {
            return new UserDto()
            {
                UserId = user.UserId,
                UserName = user.UserName,
                Password = user.Password,
                RoleId = user.RoleId,
                //Contacts = user.Contacts
            };
        }
        private User ConvertToModel(UserDto userDto)
        {
            return new User()
            {
                UserId = userDto.UserId,
                UserName = userDto.UserName,
                Password = userDto.Password,
                RoleId = userDto.RoleId,
                IsActive = true,
                //Contacts = userDto.Contacts
            };
        }
    }
}
