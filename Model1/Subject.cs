namespace Model
{
    public class Subject
    {
        public string Name {get;set;}
        public long Id {get;set; }
        public List<StudyProgramExams>? StudyPrograms { get; set;}
        public List<StudentListensSub>? Students { get; set; }
      
    }
}
