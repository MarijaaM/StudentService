using Model;

namespace StudentService.Server.DTO.StudentDtos;


public class StudentDto : PersonDto
{
    public string IndexNumber { get; set; } = "";
    public List<ExamResult>? PreviousExams { get; set; }
    public MethodOfFinancing methodOfFinancing { get; set; }
    public int YearOfStudy { get; set; }
    public long? StudyProgramId { get; set; }
}
