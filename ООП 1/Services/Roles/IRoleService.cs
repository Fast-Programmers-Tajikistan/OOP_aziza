using ООП_1.DTOs;
using ООП_1.Responses;

namespace ООП_1.Services.Roles
{
    public interface IRoleService
    {
        Task<BaseResponse<Guid>> CreateRole(CreateRoleRequest request);
        Task<bool> DeleteRole(Guid Id);
        Task<bool> UpdateRole(UpdateRoleRequest request);
    }
}
