using AutoMapper;
using DataAccess.Infrastructure;
using DataAccess.Repositories.ProfessorRepository;
using DataAccess.Repositories.StudentsRepository;
using DataAccess.Repositories.SubjectsRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Server.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "StudentService",
        Version = "v1"
    });
});
// Add services to the container.

builder.Services.AddScoped<IStudentsRepository, StudentRepository>();
builder.Services.AddScoped<IProfessorRepository, ProfessorRepository>();
builder.Services.AddScoped<IStudentsRepository, StudentRepository>();
builder.Services.AddScoped<ISubjectsRepository, SubjectsRepository>();


var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.AddRazorPages();


builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("StudentServiceDatabase"), b => b.MigrationsAssembly("Server"));

});

builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<DatabaseContext>();
    context.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
