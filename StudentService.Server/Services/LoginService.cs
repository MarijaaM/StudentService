using AutoMapper;
using DataAccess.Infrastructure;
using Microsoft.IdentityModel.Tokens;
using Model;
using StudentService.Server.DTO;
using StudentService.Server.DTO.StudentDtos;
using StudentService.Server.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace StudentService.Server.Services
{
    public class LoginService : ILoginService
    {
        private readonly IMapper _mapper;
        private DatabaseContext _dbContext;
        private readonly IConfigurationSection _tokenAddress;
        private readonly IConfigurationSection _secretKey;

        public LoginService(IMapper mapper, DatabaseContext dbContext, IConfiguration config)
        {
            _mapper = mapper;
            _dbContext = dbContext;
            _tokenAddress = config.GetSection("tokenAddress");
            _secretKey = config.GetSection("SecretKey");
        }

        public TokenDto Login(string email, string password)
        {
            var users = _dbContext.Users.Where(x => x.Email == email && x.Password == Encryption(password)).ToList();
            if (users.Count == 0)
            {
                return null;
            }
            List<Claim> claims = new List<Claim>();

            claims.Add(new Claim("id", users[0].Id.ToString()));
            SymmetricSecurityKey secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey.Value));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            var tokeOptions = new JwtSecurityToken(
                   issuer: _tokenAddress.Value,
                   claims: claims,
                   expires: DateTime.Now.AddDays(1),
                   signingCredentials: signinCredentials
               );
            string tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
            return new TokenDto() { Token = tokenString };

        }
        private const string _pepper = "rtrtjgg";
        private string Encryption(string password)
        {
            using (var sha = SHA256.Create())
            {
                var computedHash = sha.ComputeHash(
                Encoding.Unicode.GetBytes(password + _pepper));
                return Convert.ToBase64String(computedHash);
            }
        }
        public bool RegisterStudent(StudentDto student)
        {
            if (_dbContext.Users.Where(x => x.Email == student.Email).ToList().Count == 0)
            {
                student.Password = Encryption(student.Password);
                Student s = _mapper.Map<Student>(student);
                _dbContext.Users.Add(s);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
