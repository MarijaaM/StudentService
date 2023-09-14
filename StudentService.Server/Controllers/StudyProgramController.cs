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
    public class StudyProgramController : ControllerBase
    {
        private readonly IStudyProgramService _studyProgramService;
        private readonly IMapper _mapper;

        public StudyProgramController(IStudyProgramService studyProgramService, IMapper mapper)
        {
            _studyProgramService = studyProgramService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _studyProgramService.GetAll());
        }
    }
}
