using DetRigtigeSemesterProjekt.Models;

namespace DetRigtigeSemesterProjekt.MockData
{
    //Martin Venge Skytte
    public class MockHold
    {
        private static List<Hold> HoldListe = new List<Hold>()//har laver jeg en liste af klassen <Hold> kaldet HoldListe
        {
            new Hold("Malthe", "James, Chihuahua", "Roskilde, Græsvej 23", "Birghitte", 1)
        };

        public static List<Hold> GetHoldListe()
        {
            if (HoldListe != null) //her definere jeg at metoden kun skal kunne virke hvis der eksistere en liste, altså listen skal ikke være null
            {
                foreach (Hold hold in HoldListe)
                {
                    return HoldListe;
                }
            }
            return null;
        }//her har jeg lavet en static metode, der skal returne den liste jeg lavede tidligere kaldet HoldListe.
    }
}
