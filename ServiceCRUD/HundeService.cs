using DetRigtigeSemesterProjekt.MockData;
using DetRigtigeSemesterProjekt.Models;

namespace DetRigtigeSemesterProjekt.ServiceCRUD
{
    public class HundeService : IHundeService
    {
        public List<Hund> HundListe { get; private set; }
        public HundeService()
        {
            HundListe = MockHund.GetHundListe();
        }

        public List<Hund> GetHundListe()
        {
            return HundListe;
        }

        public void AddHund(Hund hund)
        {
            HundListe.Add(hund);
        }

        //Vi har lavet en update hold så man kan opdatere oplysningerne på hold
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
