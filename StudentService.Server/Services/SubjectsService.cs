using DataAccess.Infrastructure;
using DataAccess.Repositories.SubjectsRepository;
using Model;
using StudentService.Server.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace StudentService.Server.Services
{
    public class SubjectsService : ISubjectService
    {
        private readonly ISubjectsRepository _subjectsRepository;
        private readonly DatabaseContext _databaseContext;

        public SubjectsService(ISubjectsRepository subjectsRepository, DatabaseContext databaseContext)
        {
            _subjectsRepository = subjectsRepository;
            _databaseContext = databaseContext;
        }

        public Task Add(Subject subject)
        {
            return _subjectsRepository.Add(subject);
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Subject>> GetAll()
        {
            return _subjectsRepository.GetAll();
        }

        public Task<Subject> GetById(long id)
        {
            return _subjectsRepository.GetById(id);
        }

        public Task<List<Subject>> GetByProfessor(long professorId)
        {
            // Professor? p = _databaseContext.Professors.Where(x => x.Id == professorId).FirstOrDefault();
            //if (p != null)
            //{
            var subjects = _databaseContext.Subjects.Where(x => x.ProfessorId == professorId).ToList();
            return Task.FromResult<List<Subject>>(subjects);
            //}
            //  return null;
        }

        public Task<bool> Update(Subject subject)
        {
            return _subjectsRepository.Update(subject);
        }
    }
}
