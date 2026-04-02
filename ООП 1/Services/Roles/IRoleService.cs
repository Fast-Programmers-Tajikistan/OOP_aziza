using ООП_1.DTOs;
using ООП_1.Responses;

namespace ООП_1.Services.Roles
{
    public interface IRoleService
    {
        Task<BaseResponse<Guid>> CreateRole(CreateRoleRequest request, CancellationToken cancellationToken);
        Task<bool> DeleteRole(Guid Id, CancellationToken cancellationToken);
        Task<bool> UpdateRole(UpdateRoleRequest request, CancellationToken cancellationToken);
    }
}
