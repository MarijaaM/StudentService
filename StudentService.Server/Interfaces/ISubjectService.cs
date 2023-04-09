using Model;

namespace StudentService.Server.Interfaces
{
    public interface ISubjectService
    {
        Task<List<Subject>> GetAll();
        Task<Subject> GetById(long id);
        Task Add(Subject subject);
        Task<bool> Update(Subject subject);
        Task Delete(long id);
    }
}
