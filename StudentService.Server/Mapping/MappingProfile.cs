using AutoMapper;
using Model;
using StudentService.Model;
using StudentService.Server.DTO;
using StudentService.Server.DTO.ProfessorDtos;
using StudentService.Server.DTO.StudentDtos;
using StudentService.Server.DTO.SubjectDtos;

namespace Server.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Student, RegisterStudentDto>().ReverseMap();
            CreateMap<Professor, ProfessorDto>().ReverseMap();
            CreateMap<Professor, AddProfessorDto>().ReverseMap();
            CreateMap<StudyProgramSubject, StudyProgramSubjectDto>().ReverseMap();
            CreateMap<StudyProgram, StudyProgramDto>().ReverseMap();
            CreateMap<Subject, SubjectDto>().ReverseMap();
            CreateMap<Exam, ExamDto>().ReverseMap();

        }
    }
}
