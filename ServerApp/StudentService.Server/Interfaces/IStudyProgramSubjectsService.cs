using Model;
using StudentService.Server.DTO;

namespace StudentService.Server.Interfaces
{
    public interface IStudyProgramSubjectsService
    {
        List<StudyProgramSubject> GetAllByStudent(long studentId);
    }
}
