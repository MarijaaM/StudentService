using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Model;
using StudentService.Server.DTO.SubjectDto;
using StudentService.Server.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentService.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectService _subjectService;
        private readonly IMapper _mapper;

        public SubjectController(ISubjectService subjectService, IMapper mapper)
        {
            _subjectService = subjectService;
            _mapper = mapper;
        }

        // GET: api/<SubjectController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_mapper.Map<List<SubjectDto>>(await _subjectService.GetAll()));
        }

        // GET api/<SubjectController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            return Ok(_mapper.Map<SubjectDto>(await _subjectService.GetById(id)));
        }

        // POST api/<SubjectController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SubjectDto subjectDto)
        {
            Subject subject = _mapper.Map<Subject>(subjectDto);
            await _subjectService.Add(subject);
            return Ok();
        }

        // PUT api/<SubjectController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] SubjectDto subjectDto)
        {
            Subject subject = _mapper.Map<Subject>(subjectDto);
            if (await _subjectService.Update(subject))
                return Ok();
            return BadRequest();
        }

        // DELETE api/<SubjectController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
