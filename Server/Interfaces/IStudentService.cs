using Model;

namespace Server.Interfaces
{
    public interface IStudentService
    {
        Task<List<Student>> GetAll();
        Task<Student> GetById(long id);
        Task Add(Student student);
        Task Update(Student student);
        Task Delete(long id);
    }
}
