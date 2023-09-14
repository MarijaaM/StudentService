namespace Model
{
    public class StudyProgramSubject
    {
        public long StudyProgramId { get; set; }
        public long SubjectId { get; set; }
        public StudyProgram? StudyProgram { get; set; }
        public Subject? Subject { get; set; }
        public int Year { get; set; }
        public long Id { get; set; }

    }
}
