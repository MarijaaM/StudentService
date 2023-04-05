namespace Model
{
    public class StudyProgram
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Year {get;set; }
        public List<Subject> Subjects { get; set; }
    }
}
