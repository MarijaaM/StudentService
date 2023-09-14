using Model;
using StudentService.Server.DTO.SubjectDtos;

namespace StudentService.Server.DTO
{
    public class StudyProgramSubjectDto
    {
        public long StudyProgramId { get; set; }
        public long SubjectId { get; set; }
        public SubjectDto Subject { get; set; }
        public int Year { get; set; }
        public long Id { get; set; }
    }
}
