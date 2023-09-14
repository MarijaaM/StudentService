using AutoMapper;
using DataAccess.Repositories.StudyProgramsRepository;
using Model;
using StudentService.Server.DTO;
using StudentService.Server.Interfaces;

namespace StudentService.Server.Services
{
    public class StudyProgramService : IStudyProgramService
    {
        private readonly IStudyProgramsRepository _studyProgramRepository;
        private readonly IMapper _mapper;

        public StudyProgramService(IStudyProgramsRepository studyProgramRepository, IMapper mapper)
        {
            _studyProgramRepository = studyProgramRepository;
            _mapper = mapper;
        }

        public async Task<List<StudyProgramDto>> GetAll()
        {
            List<StudyProgram> studyPrograms = await _studyProgramRepository.GetAll();
            var studyprograms = _mapper.Map<List<StudyProgramDto>>(studyPrograms);
            return studyprograms;
        }
    }
}
