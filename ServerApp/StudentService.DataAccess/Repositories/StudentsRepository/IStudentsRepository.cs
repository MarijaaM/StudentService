using Model;

namespace DataAccess.Repositories.StudentsRepository
{
    public interface IStudentsRepository
    {
        Task<List<Student>> GetAll();
        Task<Student> GetById(long id);
        Task Add(Student student);
        Task Update(Student student);
        Task Delete(long id);
    }
}
