using AutoMapper;
using DataAccess.Infrastructure;
using Model;
using StudentService.DataAccess.Repositories.ExamRepository;
using StudentService.Model;
using StudentService.Server.DTO;
using StudentService.Server.Interfaces;

namespace StudentService.Server.Services
{
    public class ExamService : IExamService
    {
        private readonly IExamRepository _examRepository;
        private IMapper _mapper;
        private readonly DatabaseContext _databaseContext;

        public ExamService(IExamRepository examRepository, IMapper mapper, DatabaseContext databaseContext)
        {
            _examRepository = examRepository;
            _mapper = mapper;
            _databaseContext = databaseContext;
        }

        public Task Add(Exam exam)
        {
            throw new NotImplementedException();
        }


        public async Task<bool> CreateExam(ExamDto exam)
        {
            Exam e = _mapper.Map<Exam>(exam);
            if (e != null)
            {
                if (e.Date > DateTime.Now)
                {
                    _examRepository.Add(e);
                    _databaseContext.SaveChanges();
                    return true;
                }

            }
            return false;
        }

        public Task Delete(long id)
        {
            throw new NotImplementedException();
        }



        public Task<ExamResult> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(ExamResult Exam)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Exam Exam)
        {
            throw new NotImplementedException();
        }

        Task<Exam> IExamService.GetById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
