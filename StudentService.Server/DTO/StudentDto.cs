using Model;

namespace Server.DTO
{
    public class StudentDto : Person
    {
        public string IndexNumber { get; set; } = "";
        public List<Exam>? PreviousExams { get; set; }
        public MethodOfFinancing methodOfFinancing { get; set; }
        public int YearOfStudy { get; set; }
    }
}
