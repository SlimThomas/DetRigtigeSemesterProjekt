namespace DetRigtigeSemesterProjekt.Models
{
    public class Hund
    {
        public Hund()
        {
        }

        public static int NextId { get; set; }
        public int Id { get; set; }
        public string Navn { get; set; }
        public string Race { get; set; }
        public int Alder { get; set; }
        public double Vægt { get; set; }
        public double Højde { get; set; }
        public bool Handicap { get; set; }

        public Hund(string navn, string race, int alder, double vægt, double højde, bool handicap)

        //Der laves en Id der bliver sat lig med NextId, så hver hund får dens egen ID og den automatisk tæller en op,
        //da NextId har ++
        {
            Id = NextId++;
            Navn = navn;
            Race = race;
            Alder = alder;
            Vægt = vægt;
            Højde = højde;
            Handicap = handicap;
        }

    }
}

