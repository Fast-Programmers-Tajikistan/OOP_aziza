using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ООП_1.Services.Users
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllUsers();
        Task<Guid> CreateUser(CreateUserRequest user);
        Task<UserDto> GetUserById(Guid id);
    }
}

 