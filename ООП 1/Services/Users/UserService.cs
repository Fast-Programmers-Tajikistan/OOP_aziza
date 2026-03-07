using ООП_1.DataBase;
using ООП_1.DTOs;
using ООП_1.Entities;

namespace ООП_1.Services.Users;

public class UserService : IUserService
{
    private readonly UserDbContext _context;
    public UserService(UserDbContext context)
    {
        _context = context;
    }

    public Task<List<UserDto>> GetAllUsers()
    {
        var users = _context.Users.Select(u => new UserDto
        {
            Id = u.Id,
            FirstName = u.FirstName,
            LastName = u.LastName,
            MiddleName = u.MiddleName,
            PhoneNumber = u.PhoneNumber,
            Address = u.Address,
            Email = u.Email,
            Login = u.Login
        }).ToList();
        return Task.FromResult(users);
    }

    public async Task<Guid> CreateUser(CreateUserRequest user)
    {
        var createUser = new User
        {
            Id = Guid.NewGuid(),
            FirstName = user.FirstName,
            LastName = user.LastName,
            MiddleName = user.MiddleName,
            PhoneNumber = user.PhoneNumber,
            Address = user.Address,
            Email = user.Email,
            Login = user.Login,
            Password = user.Password
        };
        _context.Users.Add(createUser);

        return createUser.Id;
    }

    public async Task<UserDto> GetUserById(Guid id)
    {
        return _context.Users
            .Where(u => u.Id == id)
            .Select(u => new UserDto
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                MiddleName = u.MiddleName,
                PhoneNumber = u.PhoneNumber,
                Address = u.Address,
                Email = u.Email,
                Login = u.Login
            }).FirstOrDefault()

       ?? throw new Exception("User not found");
    }
}