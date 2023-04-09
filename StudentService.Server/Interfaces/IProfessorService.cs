using Model;

namespace StudentService.Server.Interfaces
{
    public interface IProfessorService
    {
        Task<List<Professor>> GetAll();
        Task<Professor> GetById(long id);
        Task Add(Professor professor);
        Task<bool> Update(Professor professor);
        Task Delete(long id);
    }
}
