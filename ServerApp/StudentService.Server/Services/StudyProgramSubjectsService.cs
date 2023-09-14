using AutoMapper;
using Model;
using StudentService.DataAccess.Repositories.StudyProgramSubjectsRepository;
using StudentService.Server.DTO;
using StudentService.Server.Interfaces;

namespace StudentService.Server.Services
{
    public class StudyProgramSubjectsService : IStudyProgramSubjectsService

    {
        private readonly IMapper _mapper;
        private readonly IStudyProgramSubjectsRepository _studyProgramSubjectRepository;
        public StudyProgramSubjectsService(IMapper mapper, IStudyProgramSubjectsRepository studyProgramSubjectsRepository)
        {
            _mapper = mapper;
            _studyProgramSubjectRepository = studyProgramSubjectsRepository;
        }
        public List<StudyProgramSubject> GetAllByStudent(long studentId)
        {
            return _studyProgramSubjectRepository.GetAllByStudent(studentId);
        }
    }
}
