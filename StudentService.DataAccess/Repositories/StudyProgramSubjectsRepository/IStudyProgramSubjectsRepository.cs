using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentService.DataAccess.Repositories.StudyProgramSubjectsRepository
{
    public interface IStudyProgramSubjectsRepository
    {
        List<StudyProgramSubject> GetAllByStudent(long studentId);
    }
}
