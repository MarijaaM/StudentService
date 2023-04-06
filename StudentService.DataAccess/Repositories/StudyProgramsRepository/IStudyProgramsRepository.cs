using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.StudyProgramsRepository
{
    public interface IStudyProgramsRepository
    {
        Task<List<StudyProgram>> GetAll();
        Task <StudyProgram> GetById(long id);
        Task <bool> Add(StudyProgram studyProgram);
        Task<bool> Delete(long id);
        Task<bool> Update(StudyProgram studyProgram);

    }
}
