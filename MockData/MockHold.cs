using DetRigtigeSemesterProjekt.Models;

namespace DetRigtigeSemesterProjekt.MockData
{
    public class MockHold
    {
        private static List<Hold> HoldListe = new List<Hold>()
        {
            new Hold("Malthe", "James, Chihuahua", "Roskilde, Græsvej 23", "Birghitte", 1)
        };

        public static List<Hold> GetHoldListe()
        {
            if (HoldListe != null)
            {
                foreach (Hold hold in HoldListe)
                {
                    return HoldListe;
                }
            }
            return null;
        }
    }
}
