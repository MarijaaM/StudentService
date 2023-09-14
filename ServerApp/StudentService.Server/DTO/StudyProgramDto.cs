using Model;
using StudentService.Server.DTO.SubjectDtos;

namespace StudentService.Server.DTO;

public class StudyProgramDto
{
    public long Id { get; set; }
    public string Name { get; set; } = "";
    public List<StudyProgramSubjectDto>? Subjects { get; set; }
}
