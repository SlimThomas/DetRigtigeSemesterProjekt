using DetRigtigeSemesterProjekt.Models;

namespace DetRigtigeSemesterProjekt.MockData
{
    public class MockTræner
    {
        private static List<Træner> TrænerListe = new List<Træner>()
        {
        new Træner(101, 180.5, 40, "Malthe", 85965263, "MaltheEbert@gmail.com"),
        new Træner(102, 180.5, 40, "Hans", 74415241, "HansHinterseer@gmail.com")
        };

        public static List<Træner> GetTrænerListe()
        {
            if (TrænerListe != null)
            {
                foreach (Træner træner in TrænerListe)
                {
                    return TrænerListe;
                }
            }
            return null;
        }
    }
}
