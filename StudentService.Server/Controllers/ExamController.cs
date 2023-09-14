using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentService.Model;
using StudentService.Server.DTO;
using StudentService.Server.DTO.ProfessorDtos;
using StudentService.Server.Interfaces;
using StudentService.Server.Services;

namespace StudentService.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly IExamService _examService;
        private readonly IMapper _mapper;

        public ExamController(IExamService examService, IMapper mapper)
        {
            _examService = examService;
            _mapper = mapper;
        }
        [HttpPost("createexam")]
        public async Task<IActionResult> CreateExam([FromBody] ExamDto exam)
        {

            return Ok(_examService.CreateExam(exam));
        }

    }
}
