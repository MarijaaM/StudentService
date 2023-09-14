using Model;
using StudentService.Server.DTO;

namespace StudentService.Server.Interfaces
{
    public interface IStudyProgramService
    {
        Task<List<StudyProgramDto>> GetAll();
    }
}
