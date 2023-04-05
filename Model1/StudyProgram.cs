namespace Model
{
    public class StudyProgram
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Year {get;set; }
        public List<Student>? Students { get; set; }
        public List<StudyProgramExams> Exams { get; set; }
    }
}
