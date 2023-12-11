using DetRigtigeSemesterProjekt.Models;

namespace DetRigtigeSemesterProjekt.MockData
{
    public class MockHund
    {
        private static List<Hund> HundListe = new List<Hund>()
        {
         new Hund ("James", "Chihuahua", 2, 2.1, 12.3, true),
         new Hund ("Fiffi", "Puddel", 3, 10.4, 40.1, false),
         new Hund ("Futte", "Labrador", 7, 30.7,61.5,false),
         new Hund ("Bella", "Golden Retriever", 7, 31.3, 55.2,true),
         new Hund ("Molly", "Shih Tzu", 4, 5.1,23.3, false)
        };
        public static List<Hund> GetHundListe()
        {
            if (HundListe != null)
            {
                foreach (Hund hund in HundListe)
                {
                    return HundListe;
                }
            }
            return null;
        }
    }
}
