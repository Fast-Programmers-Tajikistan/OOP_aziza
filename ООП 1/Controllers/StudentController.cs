using Microsoft.AspNetCore.Mvc;
using ООП_1.DTOs;
using ООП_1.Services.Students;

namespace ООП_1.Controllers
{
    public class StudentController(
        IStudentsService service
        ) : ControllerBase
        {
            [HttpPost]
            public async Task<IActionResult> CreateStudent([FromBody] CreateStudentRequest request)
            {
                try
                {
                    var studentId = await service.CreateStudent(request);

                    return Ok(studentId);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }
    }