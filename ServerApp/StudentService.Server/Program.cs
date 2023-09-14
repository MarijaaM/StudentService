using AutoMapper;
using DataAccess.Infrastructure;
using DataAccess.Repositories.ProfessorRepository;
using DataAccess.Repositories.StudentsRepository;
using DataAccess.Repositories.StudyProgramsRepository;
using DataAccess.Repositories.SubjectsRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Server.Interfaces;
using Server.Mapping;
using Server.Services;
using StudentService.DataAccess.Repositories.ExamRepository;
using StudentService.DataAccess.Repositories.StudyProgramSubjectsRepository;
using StudentService.Server.Interfaces;
using StudentService.Server.Services;

var builder = WebApplication.CreateBuilder(args);
var _cors = "cors";
// Add services to the container.
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Service", Version = "v1" });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "bearer"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type=ReferenceType.SecurityScheme,
                                Id="Bearer"
                            }
                        },
                        new string[]{}
                    }
                });
});
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

//------------CORS------------  
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: _cors, x =>
    {
        x.WithOrigins(builder.Configuration["CORSAddress"])
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials();
    });
});


builder.Services.AddScoped<IStudentsRepository, StudentRepository>();
builder.Services.AddScoped<IProfessorRepository, ProfessorRepository>();
builder.Services.AddScoped<ISubjectsRepository, SubjectsRepository>();
builder.Services.AddScoped<IExamRepository, ExamRepository>();
builder.Services.AddScoped<IStudyProgramSubjectsRepository, StudyProgramSubjectsRepository>();
builder.Services.AddScoped<IStudyProgramsRepository, StudyProgramsRepository>();
builder.Services.AddScoped<IStudentService, StudentsService>();
builder.Services.AddScoped<ISubjectService, SubjectsService>();
builder.Services.AddScoped<IProfessorService, ProfessorsService>();
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<IExamService, ExamService>();
builder.Services.AddScoped<IStudyProgramSubjectsService, StudyProgramSubjectsService>();
builder.Services.AddScoped<IStudyProgramService, StudyProgramService>();
builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("StudentServiceDatabase"), b => b.MigrationsAssembly("StudentService.Server"));

});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Server v1"));
}
app.UseCors(_cors);
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();