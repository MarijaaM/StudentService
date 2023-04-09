using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.SubjectsRepository
{
    public interface ISubjectsRepository
    {
        Task<List<Subject>> GetAll();
        Task<Subject?> GetById(long id);
        Task Add(Subject subject);
        Task<bool> Update(Subject subject);
        Task Delete(long id);
    }
}
