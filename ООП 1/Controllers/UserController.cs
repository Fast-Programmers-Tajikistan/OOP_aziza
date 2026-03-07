using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ООП_1.DTOs;
using ООП_1.Services.Users;

namespace ООП_1.Controllers
{
    public class UserController : ControllerBase
    {
            private readonly IUserService _userService;
            public UserController(IUserService userService)
            {
                _userService = userService;
            }

            [HttpGet("GetAll")]
            public Task<ActionResult> GetAllUsers(IUserService userService)
            {
                var users = userService.GetAllUsers();
                return Task.FromResult<ActionResult>(Ok(users));
            }
            [HttpPost]
            public Task<ActionResult> CreateUser(CreateUserRequest request)
            {
                var userId = _userService.CreateUser(request);
                return Task.FromResult<ActionResult>(Ok(userId));
            }
        }
    }
