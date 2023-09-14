using DataAccess.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Model;
using StudentService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentService.DataAccess.Repositories.StudyProgramSubjectsRepository
{
    public class StudyProgramSubjectsRepository : IStudyProgramSubjectsRepository
    {
        private readonly DatabaseContext _databaseContext;
        public StudyProgramSubjectsRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public List<StudyProgramSubject> GetAllByStudent(long studentId)
        {
            /*
            User? u = _databaseContext.Users.Where(x => x.Id == studentId).FirstOrDefault();
            if (u != null && u is Student s)
            {
                List<StudyProgramSubjects> subjects = _databaseContext.StudyProgramSubjects.Where(x => x.StudyProgramId == s.StudyProgramId && x.Year <= s.YearOfStudy)
                                                                                           .Include(x => x.Subject)
                                                                                           .ToList();
                HashSet<long> exams = _databaseContext.Exams.Where(x => x.StudentId == studentId && x.Results == ExamState.Concluded && x.Mark > 5).Select(x => x.SubjectId).ToHashSet();

               List<StudyProgramSubjects> sub = subjects.Where(x => !exams.Contains(x.SubjectId)).ToList();
                sub.ForEach(item =>
                {
                    Subject subject = _databaseContext.Subjects.Where(x => x.Id == item.SubjectId).FirstOrDefault();
                    item.Subject = subject;
                });
                return sub;
            }
            return null;
            */
            return null;
        }


    }
}
