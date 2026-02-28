namespace ООП_1.Entities.BaseEntities
{
    public class Role : BaseEntity
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
    }
}