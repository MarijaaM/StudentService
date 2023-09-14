using Model;

namespace StudentService.Server.DTO
{
    public class ExamDto
    {
        public long Id { get; set; }
        public string ClassRoom { get; set; }
        public long SubjectId { get; set; }
        public DateTime Date { get; set; }
        public string ExaminationPeriod { get; set; }
    }
}
