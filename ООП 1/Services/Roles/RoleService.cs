using ООП_1.DataBase;
using ООП_1.DTOs;
using ООП_1.Entities;
using ООП_1.Responses;
using ООП_1.Services.Roles;

namespace OOPWEBAPI.Services.Roles
{
    public class RoleService(
        UserDbContext dbContext) : IRoleService
    {
        public async Task<BaseResponse<Guid>> CreateRole(
            CreateRoleRequest request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<Guid>();

            var roleExist = dbContext.Roles
                .Any(a => a.Name == request.Name);

            if (roleExist)
            {
                response.Status = ResponseStatus.Error;
                response.Message = "Ин рол алакай вуҷуд дорад";
                return response;
            }

            var role = new Role
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description,
            };

            dbContext.Roles.Add(role);
            await dbContext.SaveChangesAsync(cancellationToken);

            response.Data = role.Id;
            response.Message = "Рол дохил карда шуд!";
            response.Status = ResponseStatus.Sucess;

            return response;
        }

        public async Task<bool> UpdateRole(UpdateRoleRequest request, CancellationToken cancellationToken)
        {
            var role = dbContext.Roles
                .FirstOrDefault(r => r.Id == request.Id);

            if (role == null)
            {
                throw new ArgumentException("Role not found!");
            }

            role.Name = request.Name;
            role.Description = request.Description;

            dbContext.Roles.Update(role);
            await dbContext.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<bool> DeleteRole(Guid Id, CancellationToken cancellationToken)
        {
            var role = dbContext.Roles.FirstOrDefault(r => r.Id == Id);

            if (role == null)
            {
                throw new ArgumentException("Role not found!");
            }

            dbContext.Roles.Remove(role);

            await dbContext.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}