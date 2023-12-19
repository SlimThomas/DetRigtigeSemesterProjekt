namespace DetRigtigeSemesterProjekt.Models
{
    public class Person
    {
        // (Thomas) Person klassen bliver oprettet med forskellige properties. Person klassen bruger vi som vores "super class/ base class", som andre klasser arver fra
        // Derfor er der mange properties i denne klasse, fremfor de andre. 
        public static int NextId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Tlf { get; set; }
        public string Mail { get; set; }

        public Person() { }

        // her laver vi en default constructor, samt en constructor med properties)
        public Person(int id, string name, int tlf, string mail)
        {
            Id = NextId++;
            Name = name;
            Tlf = tlf;
            Mail = mail;
        }
    }
}
