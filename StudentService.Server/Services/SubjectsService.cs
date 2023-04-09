using DataAccess.Repositories.SubjectsRepository;
using Model;
using StudentService.Server.Interfaces;

namespace StudentService.Server.Services
{
    public class SubjectsService : ISubjectService
    {
        private readonly ISubjectsRepository _subjectsRepository;

        public SubjectsService(ISubjectsRepository subjectsRepository)
        {
            _subjectsRepository = subjectsRepository;
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

        public Task<bool> Update(Subject subject)
        {
            return _subjectsRepository.Update(subject);
        }
    }
}
