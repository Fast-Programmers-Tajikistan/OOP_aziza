using ООП_1.Controllers;

namespace ООП_1.Services.Groups
{
    public interface IGroupService
    {
            Task<Guid> CreateGroup(CreateGroupRequest request);
        }
    }
