
using DataAccess.Repositories.StudentsRepository;
using Model;
using Server.Interfaces;

namespace Server.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentsRepository _studentRepository;

        public StudentService(IStudentsRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Task Add(Student student)
        {
            return _studentRepository.Add(student);
        }

        public Task Delete(long id)
        {
            return _studentRepository.Delete(id);
        }

        public Task<List<Student>> GetAll()
        {
            return _studentRepository.GetAll();
        }

        public Task<Student> GetById(long id)
        {
            return _studentRepository.GetById(id);
        }

        public Task Update(Student student)
        {
            return _studentRepository.Update(student);
        }
    }
}
