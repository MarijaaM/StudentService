using Model;

namespace StudentService.Server.DTO.StudentDto
{
    public class AddStudentDto : PersonDto
    {
        public string IndexNumber { get; set; } = "";

        public MethodOfFinancing methodOfFinancing { get; set; }
        public int YearOfStudy { get; set; }
        public long StudyProgramId { get; set; }
    }
}
