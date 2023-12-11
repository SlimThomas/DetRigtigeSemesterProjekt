namespace DetRigtigeSemesterProjekt.Models
{
    public class Træner : Person
    {
        public double Wage { get; set; }
        public int HoursWorked { get; set; }

        public Træner() { }

        public Træner(int id, double wage, int hoursWorked, string name, int tlf, string mail)
            : base(id, name, tlf, mail)
        {
            Wage = wage;
            HoursWorked = hoursWorked;

        }
    }
}
