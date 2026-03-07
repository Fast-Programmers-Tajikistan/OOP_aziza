namespace ООП_1.DTOs
{
    public class UpdateRoleRequest
    {
            public Guid Id { get; set; }
            public required string Name { get; set; }
            public string? Description { get; set; }
        }
    }
