using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Model;
using StudentService.Server.DTO.ProfessorDtos;
using StudentService.Server.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentService.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorService _professorService;
        private readonly IMapper _mapper;

        public ProfessorController(IProfessorService professorService, IMapper mapper)
        {
            _professorService = professorService;
            _mapper = mapper;
        }

        // GET: api/<ProfessorController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_mapper.Map<List<ProfessorDto>>(await _professorService.GetAll()));
        }

        // GET api/<ProfessorController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            return Ok(_mapper.Map<ProfessorDto>(await _professorService.GetById(id)));
        }

        // POST api/<ProfessorController>
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddProfessorDto professorDto)
        {
            Professor professor = _mapper.Map<Professor>(professorDto);
            await _professorService.Add(professor);
            return Ok();
        }

        // PUT api/<ProfessorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProfessorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
