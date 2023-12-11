using DetRigtigeSemesterProjekt.MockData;
using DetRigtigeSemesterProjekt.Models;

namespace DetRigtigeSemesterProjekt.Services
{
    public class HoldService : IHoldService
    {
        public List<Hold> HoldListe { get; private set; }
        private JsonFileHoldService JsonFileHoldService { get; set; }
        public HoldService()
        {
            HoldListe = MockHold.GetHoldListe();
        }

        public HoldService(JsonFileHoldService jsonFileHoldService)
        {
            JsonFileHoldService = jsonFileHoldService;
            //HoldListe = MockHold.GetHoldListe(); 
            HoldListe = JsonFileHoldService.GetJsonHold().ToList(); 
        }

        public List<Hold> GetHoldListe()
        {
            return HoldListe;
        }

        public void AddHold(Hold hold)
        {
            HoldListe.Add(hold);
            JsonFileHoldService.SaveJsonHold(HoldListe); 
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
                JsonFileHoldService.SaveJsonHold(HoldListe);
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
            Hold itemToBeDeleted = null;
            foreach (Hold item in HoldListe)
            {
                if (item.Id == holdId)
                {
                    itemToBeDeleted = item;
                    break;
                }
            }
            if (itemToBeDeleted != null)
            {
                HoldListe.Remove(itemToBeDeleted);
                JsonFileHoldService.SaveJsonHold(HoldListe);
            }
            return itemToBeDeleted;
        }

        public IEnumerable<Hold> NameSearch(string str)
        {
            List<Hold> nameSearch = new List<Hold>();
            foreach (Hold hold in HoldListe)
            {
                if (hold.HundeEjer.ToLower().Contains(str.ToLower()))
                {
                    nameSearch.Add(hold);
                }
            }
            return nameSearch;
        }

       

    }
}
