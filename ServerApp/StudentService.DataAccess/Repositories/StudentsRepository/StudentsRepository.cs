using DataAccess.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Model;

namespace DataAccess.Repositories.StudentsRepository
{
    public class StudentRepository : IStudentsRepository
    {
        private DatabaseContext _databaseContext;

        public StudentRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task Add(Student student)
        {
            _databaseContext.Add(student);
            await _databaseContext.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            Student? student = await GetById(id);
            _databaseContext.Remove(student.Id);
            await _databaseContext.SaveChangesAsync();
        }

        public async Task<List<Student>> GetAll()
        {
            return await _databaseContext.Students.Include(x => x.Exams).ToListAsync();
        }

        public async Task<Student> GetById(long id)
        {
            return await _databaseContext.Students.Include(x => x.Exams).FirstOrDefaultAsync(x => x.Id == id);

        }

        public async Task Update(Student student)
        {
            Student existingStudent = await GetById(student.Id);
            existingStudent.FirstName = student.FirstName;
            existingStudent.LastName = student.LastName;
            existingStudent.Email = student.Email;
            existingStudent.YearOfStudy = student.YearOfStudy;
            await _databaseContext.SaveChangesAsync();

        }
    }
}
