using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.StudentsRepository
{
    public interface IStudentsRepository
    {
        Task<List<Student>> GetAll();
        Task <Student> GetById(long id);
        Task<bool>Add(Student student);
        Task<bool>Update(Student student);
        Task<bool>Delete(long id);
    }
}
