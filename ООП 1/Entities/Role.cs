using ООП_1.Entities.BaseEntities;

namespace ООП_1.Entities
{
    public class Role : BaseEntity
    {
            public required string Name { get; set; }
            public string? Description { get; set; }
        }
    }