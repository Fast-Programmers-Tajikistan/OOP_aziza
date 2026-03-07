using ООП_1.DTOs;

namespace ООП_1.Services.Students
{
    public interface IStudentsService
    {
        Task<Guid> CreateStudent(CreateStudentRequest request);

    }
}
