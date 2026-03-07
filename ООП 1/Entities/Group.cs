using ООП_1.Entities.BaseEntities;

namespace ООП_1.Entities
{
    public class Group: BaseEntity
    {
            public required string Name { get; set; }
            public string? Code { get; set; }
        }
    }