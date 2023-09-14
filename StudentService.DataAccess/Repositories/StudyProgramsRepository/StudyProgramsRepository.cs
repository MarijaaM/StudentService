using DataAccess.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.StudyProgramsRepository
{
    public class StudyProgramsRepository : IStudyProgramsRepository
    {
        private readonly DatabaseContext _databaseContext;

        public StudyProgramsRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public Task<bool> Add(StudyProgram studyProgram)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<StudyProgram>> GetAll()
        {
            return _databaseContext.StudyPrograms.Include(x => x.Subjects)
                                                 .ThenInclude(x => x.Subject)
                                                 .ToListAsync();
        }

        public Task<StudyProgram> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(StudyProgram studyProgram)
        {
            throw new NotImplementedException();
        }
    }
}
