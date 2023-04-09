namespace Model
{
    public class ProfessorsSubjects
    {
        public long Id { get; set; }
        public long ProfessorId { get; set; }
        public Professor Professor { get; set; } = new Professor();
        public long StudyProgramExamsId { get; set; }
        public StudyProgramExams StudyProgramExams { get; set; } = new StudyProgramExams();


    }
}
