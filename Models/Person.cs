namespace DetRigtigeSemesterProjekt.Models
{
    public class Person
    {
        public static int NextId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Tlf { get; set; }
        public string Mail { get; set; }

        public Person() { }

        public Person(int id, string name, int tlf, string mail)
        {
            Id = NextId++;
            Name = name;
            Tlf = tlf;
            Mail = mail;
        }
    }
}
