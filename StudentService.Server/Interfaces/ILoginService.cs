using StudentService.Server.DTO;
using StudentService.Server.DTO.StudentDtos;

namespace StudentService.Server.Interfaces
{
    public interface ILoginService
    {
        TokenDto Login(string email, string password);
        bool RegisterStudent(StudentDto student);
    }
}
