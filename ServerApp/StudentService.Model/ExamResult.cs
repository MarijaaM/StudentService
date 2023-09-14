using StudentService.Model;

namespace Model
{

    public class ExamResult
    {
        public long Id { get; set; }
        public int Mark { get; set; }

        public Exam Exam { get; set; }
        public long ExamId { get; set; }
        public long StudentId { get; set; }
        public Student Student { get; set; } = new Student();
        public ExamState Results { get; set; }
        public PassedOrNot PassedOrNot { get; set; }

    }
}
