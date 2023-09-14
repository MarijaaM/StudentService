using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentService.Server.DTO;
using StudentService.Server.DTO.StudentDtos;
using StudentService.Server.Interfaces;

namespace StudentService.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginCredsDto loginCredsDto)
        {
            return Ok(_loginService.Login(loginCredsDto.Email, loginCredsDto.Password));
        }
        [HttpPost("registerStudent")]
        public async Task<IActionResult> RegisterStudent([FromBody] StudentDto addStudentDto)
        {
            return Ok(_loginService.RegisterStudent(addStudentDto));
        }
    }
}
