using Model;

namespace StudentService.Server.DTO.StudentDto
{
    public class StudentDto : PersonDto
    {
        public string IndexNumber { get; set; } = "";
        public List<Exam>? PreviousExams { get; set; }
        public MethodOfFinancing methodOfFinancing { get; set; }
        public int YearOfStudy { get; set; }
    }
}
