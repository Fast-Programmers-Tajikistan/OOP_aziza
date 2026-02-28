using ООП_1.Entities.BaseEntities;

namespace ООП_1.Entities
{
    public class User : BaseEntity

    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string? MiddleName { get; set; }
        public string? PhoneNumber { get; set; }
        public required string Addres { get; set; } 
        public string? Email { get; set; }
        public required string Login { get; set; }
        public required string Password { get; set; }
    }
}