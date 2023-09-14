namespace Model
{
    public class StudyProgramExams
    {
        public long StudyProgramId { get; set; }
        public long SubjectId { get; set; }
        public StudyProgram StudyProgram { get; set; } = new StudyProgram();
        public Subject Subject { get; set; } = new Subject();
        public int Year { get; set; }
        public long Id { get; set; }

    }
}
