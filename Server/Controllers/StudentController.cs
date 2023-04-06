using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Model;
using Server.DTO;
using Server.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentController(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_mapper.Map<List<StudentDto>>(_studentService.GetAll()));
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            Student student = await _studentService.GetById(id);
            if (student != null)
            {
                StudentDto studentDto = _mapper.Map<StudentDto>(student);
                return Ok();
            }
            return NoContent();
        }

        // POST api/<StudentController>
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] StudentDto studentDto)
        {
            Student student = _mapper.Map<Student>(studentDto);
            await _studentService.Add(student);
            return Ok();
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] StudentDto studentDto)
        {
            Student student = _mapper.Map<Student>(studentDto);
            _studentService.Update(student);
            return Ok();
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _studentService.Delete(id);
            return Ok();
        }
    }
}
