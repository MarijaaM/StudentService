using DataAccess.Repositories.ProfessorRepository;
using Model;
using StudentService.Server.Interfaces;

namespace StudentService.Server.Services
{
    public class ProfessorsService : IProfessorService
    {
        private readonly IProfessorRepository _professorRepository;

        public ProfessorsService(IProfessorRepository professorRepository)
        {
            _professorRepository = professorRepository;
        }

        public Task Add(Professor professor)
        {
            return _professorRepository.Add(professor);
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Professor>> GetAll()
        {
            return _professorRepository.GetAll();
        }

        public Task<Professor> GetById(long id)
        {
            return _professorRepository.GetById(id);
        }

        public Task<bool> Update(Professor professor)
        {
            throw new NotImplementedException();
        }
    }
}
