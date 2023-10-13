using Contracts.Services;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternSample.DTO;

namespace RepositoryPatternSample.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost("CreateUser")]
        public IActionResult CreateUser(UserDTO user)
        {
            try
            {
                userService.CreateUser(new User() { CreatedDateTime = DateTime.Now, Email = user.Email, FirstName = user.FirstName, LastName = user.LastName, MiddleName = user.MiddleName, MobileNumber = user.MiddleName, Password = user.Password, UserId = user.UserId });
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex);
            }

            return new OkResult();
        }

    }
}
