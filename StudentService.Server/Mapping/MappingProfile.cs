using AutoMapper;
using Model;
using StudentService.Server.DTO.ProfessorDto;
using StudentService.Server.DTO.StudentDto;
using StudentService.Server.DTO.SubjectDto;

namespace Server.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Student, AddStudentDto>().ReverseMap();
            CreateMap<Subject, SubjectDto>().ReverseMap();
            CreateMap<Professor, ProfessorDto>().ReverseMap();
            CreateMap<Professor, AddProfessorDto>().ReverseMap();

        }
    }
}
