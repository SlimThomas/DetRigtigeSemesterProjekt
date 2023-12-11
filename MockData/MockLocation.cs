using DetRigtigeSemesterProjekt.Models;

namespace DetRigtigeSemesterProjekt.MockData
{
    public class MockLocation
    {
        private static List<Location> ListLocation = new List<Location>()
        {
        new Location("Roskilde", "Græsvej 23", 4000, "Sjælland"),
        new Location("Svendborg", "Markvej 56", 5700, "Fyn"),
        new Location("Århus", "Fasangade 12", 8000, "Jylland"),
        };
    }
}
