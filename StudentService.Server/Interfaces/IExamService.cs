using Model;
using StudentService.Model;
using StudentService.Server.DTO;

namespace StudentService.Server.Interfaces
{
    public interface IExamService
    {

        Task<Exam> GetById(long id);
        Task Add(Exam exam);
        Task<bool> Update(Exam Exam);
        Task Delete(long id);
        Task<bool> CreateExam(ExamDto exam);
    }
}
