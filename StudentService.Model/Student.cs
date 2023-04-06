namespace Model;


public class Student : Person
{

    public string IndexNumber { get; set; } = "";
    public List<Exam>? PreviousExams { get; set; }
    public MethodOfFinancing methodOfFinancing { get; set; }
    public int YearOfStudy { get; set; }
    public StudyProgram? StudyProgram { get; set; }
    public long StudyProgramId { get; set; }
}
