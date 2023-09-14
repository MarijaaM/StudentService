using Model;

namespace StudentService.Server.DTO.SubjectDtos
{
    public class SubjectDto
    {
        public string Name { get; set; }
        public long Id { get; set; }
        public long ProfessorId { get; set; }
    }
}
