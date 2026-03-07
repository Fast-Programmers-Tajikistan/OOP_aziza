using ООП_1.DataBase;
using ООП_1.DTOs;
using ООП_1.Entities;
using ООП_1.Entities.BaseEntities;
using ООП_1.Responses;

namespace ООП_1.Services.Roles
{
        public class RoleService(
            UserDbContext dbContext) : IRoleService
        {
            public async Task<BaseResponse<Guid>> CreateRole(
                CreateRoleRequest request)
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

                response.Data = role.Id;
                response.Message = "Рол дохил карда шуд!";
                response.Status = ResponseStatus.Sucess;

                return response;
            }

            public Task<bool> UpdateRole(UpdateRoleRequest request)
            {
                var role = dbContext.Roles
                    .FirstOrDefault(r => r.Id == request.Id);

                if (role == null)
                {
                    throw new ArgumentException("Role not found!");
                }

                role.Name = request.Name;
                role.Description = request.Description;

                return Task.FromResult(true);
            }

            public async Task<bool> DeleteRole(Guid Id)
            {
                var role = dbContext.Roles.FirstOrDefault(r => r.Id == Id);

                if (role == null)
                {
                    throw new ArgumentException("Role not found!");
                }

                dbContext.Roles.Remove(role);
                return true;
            }
        }
    }
