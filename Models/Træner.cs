namespace DetRigtigeSemesterProjekt.Models
{
    public class Træner : Person
    {
        // (Thomas) Her opretter vi en klasse med forskellige properties, samt arver klassen fra vores base class, som er "Person"
        public double Wage { get; set; }
        public int HoursWorked { get; set; }

        public Træner() { }
        // Her laver vi en default constructor, samt en constructor med parametre fra klassen, samt parametre fra base klassen "id, name, tlf, mail". 
        public Træner(int id, double wage, int hoursWorked, string name, int tlf, string mail)
            : base(id, name, tlf, mail)
        {
            Wage = wage;
            HoursWorked = hoursWorked;

        }
    }
}
