using Microsoft.EntityFrameworkCore;
using Model;

namespace DataAccess.Infrastructure
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudyProgram> StudyPrograms { get; set; }
        public DbSet<Exam> StudentListensSubs { get; set; }
        public DbSet<StudyProgramExams> StudyProgramExams { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<ProfessorsSubjects> ProfessorsSubjects { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
        }
    }
}
