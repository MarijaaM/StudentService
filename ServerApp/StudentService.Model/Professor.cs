namespace Model
{
    public class Professor : User
    {
        public List<Subject> Subjects { get; set; } = new();
    }
}
