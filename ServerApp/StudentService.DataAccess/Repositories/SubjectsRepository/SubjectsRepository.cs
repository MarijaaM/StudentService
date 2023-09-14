using DataAccess.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Model;

namespace DataAccess.Repositories.SubjectsRepository
{
    public class SubjectsRepository : ISubjectsRepository
    {
        private DatabaseContext _databaseContext;

        public SubjectsRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task Add(Subject subject)
        {
            _databaseContext.Add(subject);
            await _databaseContext.SaveChangesAsync();
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Subject>> GetAll()
        {
            return await _databaseContext.Subjects.ToListAsync();
        }

        public async Task<Subject?> GetById(long id)
        {
            return _databaseContext.Subjects.FirstOrDefault(x => x.Id == id);

        }

        public async Task<bool> Update(Subject subject)
        {
            Subject? s = await GetById(subject.Id);
            if (s != null)
            {
                s.Name = subject.Name;
                _databaseContext.SaveChanges();
                return true;
            }
            return false;

        }
    }
}
