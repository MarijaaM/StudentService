using Model;

namespace DataAccess.Repositories.SubjectsRepository
{
    public class SubjectsRepository : ISubjectsRepository
    {
        public Task<bool> Add(Subject subject)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Subject>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Subject> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Subject subject)
        {
            throw new NotImplementedException();
        }
    }
}
