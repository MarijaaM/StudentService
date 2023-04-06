using Model;

namespace DataAccess.Repositories.ProfessorRepository
{
    public class ProfessorRepository : IProfessorRepository
    {
        public Task<bool> Add(Professor professor)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Professor>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Professor> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Professor professor)
        {
            throw new NotImplementedException();
        }
    }
}
