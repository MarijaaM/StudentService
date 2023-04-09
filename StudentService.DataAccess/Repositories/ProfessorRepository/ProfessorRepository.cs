using DataAccess.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Model;

namespace DataAccess.Repositories.ProfessorRepository
{
    public class ProfessorRepository : IProfessorRepository
    {
        private readonly DatabaseContext _databaseContext;
        public ProfessorRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task Add(Professor professor)
        {
            _databaseContext.Professors.Add(professor);
            await _databaseContext.SaveChangesAsync();
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Professor>> GetAll()
        {
            return await _databaseContext.Professors.Include(x => x.ProfessorSubjects).ToListAsync();
        }

        public async Task<Professor> GetById(long id)
        {
            return await _databaseContext.Professors.Include(x => x.ProfessorSubjects).FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<bool> Update(Professor professor)
        {
            throw new NotImplementedException();
        }
    }
}
