namespace Model
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IndexNumber { get; set; }
        public List<Subject> PassedSubject { get; set; }
        public List<Subject> NostPassedSubject { get; set; }
    }
}
