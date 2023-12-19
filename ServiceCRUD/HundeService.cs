using DetRigtigeSemesterProjekt.MockData;
using DetRigtigeSemesterProjekt.Models;

namespace DetRigtigeSemesterProjekt.ServiceCRUD
{
    //Nicolai Jaksland
    public class HundeService : IHundeService
    {
        public List<Hund> HundListe { get; private set; }
        public HundeService()
        {
            HundListe = MockHund.GetHundListe();
        }

        //Denne metode kalder på hele listen så man ser alle hunde
        public List<Hund> GetHundListe()
        {
            return HundListe;
        }

        //Metoden Addhund kan tilføjer en ny hund
        public void AddHund(Hund hund)
        {
            HundListe.Add(hund);
        }

        //Metoden UpdateHund der opdatere und
        public void UpdateHund(Hund hund)
        {
            if (hund != null)
            {
                foreach (Hund i in HundListe)
                {
                    if (i.Id == hund.Id)
                    {
                        i.Navn = hund.Navn;
                        i.Alder = hund.Alder;
                        i.Vægt = hund.Vægt;
                        i.Vægt = hund.Vægt;
                    }
                }
            }
        }

        //Denne metode bruger vi til at få den enkelte hund
        public Hund GetHund(int id)
        {
            foreach (Hund hund in HundListe)
            {
                if (hund.Id == id)
                {
                    return hund;
                }
            }
            return null;
        }

        //Metoden sletter en hund
        public Hund DeleteHund(int? id)
        {
            foreach (Hund hund in HundListe)
            {
                if (hund.Id == id)
                {
                    HundListe.Remove(hund);
                    return hund;
                }
            }
            return null;
        }
    }
}
