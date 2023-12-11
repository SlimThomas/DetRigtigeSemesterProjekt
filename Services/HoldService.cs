using DetRigtigeSemesterProjekt.MockData;
using DetRigtigeSemesterProjekt.Models;

namespace DetRigtigeSemesterProjekt.Services
{
    public class HoldService : IHoldService
    {
        public List<Hold> HoldListe { get; private set; }
        public HoldService()
        {
            HoldListe = MockHold.GetHoldListe();
        }

        public List<Hold> GetHoldListe()
        {
            return HoldListe;
        }

        public void AddHold(Hold hold)
        {
            HoldListe.Add(hold);
        }

        //Vi har lavet en update hold så man kan opdatere oplysningerne på hold
        public void UpdateHold(Hold hold)
        {
            if (hold != null)
            {
                foreach (Hold i in HoldListe)
                {
                    if (i.Id == hold.Id)
                    {
                        i.Træner = hold.Træner;
                        i.Hund = hold.Hund;
                        i.Location = hold.Location;
                        i.HundeEjer = hold.HundeEjer;
                    }
                }
            }
        }

        public Hold GetHold(int id)
        {
            foreach (Hold hold in HoldListe)
            {
                if (hold.Id == id)
                {
                    return hold;
                }
            }
            return null;
        }

        public Hold DeleteHold(int? holdId)
        {
           foreach (Hold hold in HoldListe)
            {
                if(hold.Id == holdId)
                {
                    HoldListe.Remove(hold);
                    return hold; 
                }
            }
            return null; 
        }

    }
}
