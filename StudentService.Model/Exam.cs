namespace Model
{

    public class Exam
    {
        public long Id { get; set; }
        public int Mark { get; set; }
        public DateTime DateTime { get; set; }
        public Subject Subject { get; set; } = new Subject();
        public long SubjectId { get; set; }
        public long StudentId { get; set; }
        public Student Student { get; set; } = new Student();

    }
}
