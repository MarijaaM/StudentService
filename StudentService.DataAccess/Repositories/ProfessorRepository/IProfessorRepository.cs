using Model;

namespace DataAccess.Repositories.ProfessorRepository
{
    public interface IProfessorRepository
    {
        Task<List<Professor>> GetAll();
        Task<Professor> GetById(long id);
        Task<bool> Add(Professor professor);
        Task<bool> Update(Professor professor);
        Task<bool> Delete(long id);
    }
}
