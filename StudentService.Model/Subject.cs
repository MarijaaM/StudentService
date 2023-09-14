using StudentService.Model;

namespace Model
{
    public class Subject
    {
        public string Name { get; set; } = "";
        public long Id { get; set; }

        public Professor Professor { get; set; } = new Professor();
        public long ProfessorId { get; set; }
        public List<Exam> Exams { get; set; } = new List<Exam>();
    }
}
