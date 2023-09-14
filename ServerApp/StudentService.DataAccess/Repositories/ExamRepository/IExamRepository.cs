using Model;
using StudentService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentService.DataAccess.Repositories.ExamRepository
{
    public interface IExamRepository
    {
        Task<Exam> GetAllByStudent(long studentId);
        Task<Exam> GetById(long id);
        Task Add(Exam exam);
        Task<bool> Update(Exam Exam);
        Task Delete(long id);
    }
}
