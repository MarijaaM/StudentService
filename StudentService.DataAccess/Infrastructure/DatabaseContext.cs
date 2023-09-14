using Microsoft.EntityFrameworkCore;
using Model;
using StudentService.Model;
using System.Diagnostics.Contracts;

namespace DataAccess.Infrastructure
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudyProgram> StudyPrograms { get; set; }
        public DbSet<ExamResult> ExamResults { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<StudyProgramSubject> StudyProgramSubjects { get; set; }
        public DbSet<Professor> Professors { get; set; }


        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);

        }
    }
}
