namespace Model;


public class Student : User
{

    public string IndexNumber { get; set; } = "";
    public List<ExamResult>? Exams { get; set; }
    public MethodOfFinancing methodOfFinancing { get; set; }
    public int YearOfStudy { get; set; }
    public StudyProgram? StudyProgram { get; set; }
    public long? StudyProgramId { get; set; }
}
