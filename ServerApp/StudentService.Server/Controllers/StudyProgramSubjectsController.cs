using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using StudentService.Server.DTO;
using StudentService.Server.Interfaces;

namespace StudentService.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudyProgramSubjectsController : ControllerBase
    {

        private readonly IStudyProgramSubjectsService _studyProgramSubjectService;
        private readonly IMapper _mapper;

        public StudyProgramSubjectsController(IStudyProgramSubjectsService studyProgramSubjectService, IMapper mapper)
        {
            _studyProgramSubjectService = studyProgramSubjectService;
            _mapper = mapper;
        }

        [HttpGet("subjects/{studentId}")]
        public async Task<IActionResult> GetAllByStudent(long studentId)
        {
            return Ok(_mapper.Map<List<StudyProgramSubjectDto>>(_studyProgramSubjectService.GetAllByStudent(studentId)));
        }
    }
}
