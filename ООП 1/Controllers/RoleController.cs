
﻿using Microsoft.AspNetCore.Mvc;
using ООП_1.DTOs;
using ООП_1.Services.Roles;

namespace ООП_1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoleController(IRoleService roleService) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateRole([FromBody] CreateRoleRequest request, CancellationToken cancellationToken)
        {
            var role = await roleService.CreateRole(request, cancellationToken);

            return Ok(role);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRole([FromBody] UpdateRoleRequest request, CancellationToken cancellationToken)
        {
            var role = await roleService.UpdateRole(request, cancellationToken);

            return Ok(role);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteRole([FromQuery] Guid Id, CancellationToken cancellationToken)
        {
            await roleService.DeleteRole(Id, cancellationToken);
            return Ok();
        }
    }
}