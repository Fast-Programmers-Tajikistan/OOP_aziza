namespace ООП_1.DTOs;

public class CreateUserRequest
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? MiddleName { get; set; }
    public string? PhoneNumber { get; set; }
    public required string Address { get; set; }
    public string? Email { get; set; }
    public required string Login { get; set; }
    public required string Password { get; set; }
}
