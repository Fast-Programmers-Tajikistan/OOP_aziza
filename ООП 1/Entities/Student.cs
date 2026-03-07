namespace ООП_1.Entities;

public class Student: User
{
        public Guid? GroupId { get; set; }
        public Group? Group { get; set; }
    }
