using ООП_1.DataBase;
using ООП_1.DTOs;
using ООП_1.Entities;

namespace ООП_1.Services.Students;

public class StudentsService (
    UserDbContext context
    ) : IStudentsService
{
    public async Task<Guid> CreateStudent(CreateStudentRequest request)
    {
        var groupExists = context.Groups
            .Any(g => g.Id == request.GroupId);

        if (!groupExists)
            throw new Exception($"Гурух бо чунин Id = {request.GroupId} ёфт нашуд");

        var studentsExists = context.Students
            .Any(s => s.PhoneNumber == request.PhoneNumber);

        if (studentsExists)
            throw new Exception($"Донишчу бо чунин ракам {request.PhoneNumber} вучуд дорад!");

        var student = new Student
        {
            Id = Guid.NewGuid(),
            FirstName = request.FirstName,
            LastName = request.LastName,
            MiddleName = request.MiddleName,
            Address = request.Address,
            PhoneNumber = request.PhoneNumber,
            Email = request.Email,
            Login = request.Login,
            Password = request.Password,
            GroupId = request.GroupId,
        };

        context.Students.Add(student);

        return student.Id;
    }
}
