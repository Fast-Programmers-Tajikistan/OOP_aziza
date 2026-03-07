using System.Collections.Generic;
using System.Text.RegularExpressions;
using ООП_1.Entities;
using ООП_1.Entities.BaseEntities;
namespace ООП_1.DataBase
{
    public class UserDbContext
    {
        public List<User> Users { get; set; } = new List<User>();
        public List<Role> Roles { get; set; } = new List<Role>();
        public List<Group> Groups { get; set; } = new List<Group>();
        public List<Student> Students { get; set; } = new List<Student>();
    }
}


 