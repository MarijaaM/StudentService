
using DataAccess.Infrastructure;
using DataAccess.Repositories.StudentsRepository;
using Microsoft.AspNetCore.Mvc;
using Model;
using Server.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace Server.Services;

public class StudentsService : IStudentService
{
    private readonly IStudentsRepository _studentRepository;
    private readonly DatabaseContext _databaseContext;

    public StudentsService(IStudentsRepository studentRepository, DatabaseContext databaseContext)
    {
        _studentRepository = studentRepository;
        _databaseContext = databaseContext;
    }

    public Task Add(Student student)
    {
        if (_databaseContext.Students.Where(x => x.Email == student.Email).ToList().Count == 0)
        {

            student.Password = Encryption(student.Password);
            student.YearOfStudy = 1;
            return _studentRepository.Add(student);
        }
        return null;

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
    private const string _pepper = "rtrtjgg";
    private string Encryption(string password)
    {
        using (var sha = SHA256.Create())
        {
            var computedHash = sha.ComputeHash(
            Encoding.Unicode.GetBytes(password + _pepper));
            return Convert.ToBase64String(computedHash);
        }
    }
}
