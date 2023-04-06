namespace Model
{
    public class Professor : Person
    {
        public List<ProfessorsSubjects> ProfessorSubjects { get; set; } = new();
    }
}
