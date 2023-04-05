namespace Model
{
    public class Student
    {
        public long Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName{ get; set; }
        public string? IndexNumber { get; set; }
        public List<StudentListensSub>? Subjects { get; set; }
        public MethodOfFinancing methodOfFinancing { get; set; }
        public int YearOfStudy { get; set; }
        public StudyProgram? StudyProgram { get; set; }
        public long StudyProgramId { get; set; }
    }
}
