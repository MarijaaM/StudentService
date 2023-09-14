namespace Model
{
    public class StudyProgram
    {
        public long Id { get; set; }
        public string Name { get; set; } = "";
        public List<Student>? Students { get; set; }
        public List<StudyProgramSubject>? Subjects { get; set; }
    }
}
