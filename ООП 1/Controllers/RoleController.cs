using Microsoft.AspNetCore.Mvc;
using ООП_1.DTOs;
using ООП_1.Services.Roles;

namespace ООП_1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoleController(IRoleService roleService) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateRole([FromBody] CreateRoleRequest request)
        {
            var role = await roleService.CreateRole(request);

            return Ok(role);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateRole([FromBody] UpdateRoleRequest request)
        {
            var role = await roleService.UpdateRole(request);

            return Ok(role);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteRole([FromQuery] Guid Id)
        {
            await roleService.DeleteRole(Id);
            return Ok();
        }
    }
}