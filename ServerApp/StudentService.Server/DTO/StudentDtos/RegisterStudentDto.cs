namespace StudentService.Server.DTO.StudentDtos

{
    public class RegisterStudentDto : PersonDto
    {
        public string IndexNumber { get; set; } = "";
        public string Password { get; set; } = "";
    }
}
