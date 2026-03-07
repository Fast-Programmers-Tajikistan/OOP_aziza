using Microsoft.AspNetCore.Mvc;
using ООП_1.Services.Groups;

namespace ООП_1.Controllers
{
    public class GroupController(
            IGroupService groupService
            ) : ControllerBase
        {
            [HttpPost]
            public async Task<IActionResult> CreateGroup([FromBody] CreateGroupRequest request)
            {
                var group = await groupService.CreateGroup(request);

                return Ok(group);
            }
        }
        public class CreateGroupRequest
        {
            public string? Name { get; set; }
            public string? Code { get; set; }
        }
}