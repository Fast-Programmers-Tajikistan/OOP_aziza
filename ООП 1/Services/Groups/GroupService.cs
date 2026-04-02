using ООП_1.Controllers;
using ООП_1.DataBase;
using ООП_1.Entities;


namespace ООП_1.Services.Groups
{
    public class GroupService(
        UserDbContext context
        ) : IGroupService
    {
        public async Task<Guid> CreateGroup(CreateGroupRequest request, CancellationToken cancellationToken)
        {
            var groupExists = context.Groups
                .Any(g => g.Name == request.Name);

            if (groupExists)
                throw new Exception("Чунин гурух вучуд дорад!");

            var group = new Group
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Code = request.Code,
            };

            context.Groups.Add(group);
            await context.SaveChangesAsync(cancellationToken);

            return group.Id;
        }

        public Task<Guid> CreateGroup(CreateGroupRequest request)
        {
            throw new NotImplementedException();
        }
    }
}