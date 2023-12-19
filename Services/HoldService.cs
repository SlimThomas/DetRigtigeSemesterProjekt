using DetRigtigeSemesterProjekt.MockData;
using DetRigtigeSemesterProjekt.Models;

namespace DetRigtigeSemesterProjekt.Services
{
    //Martin Venge Skytte
    public class HoldService : IHoldService
    {
        //Martin Venge Skytte
        public List<Hold> HoldListe { get; private set; }
        //Thomas
        private JsonFileHoldService JsonFileHoldService { get; set; }
        //Martin Venge Skytte
        public HoldService()
        {
            HoldListe = MockHold.GetHoldListe();
        }
        //Thomas
        public HoldService(JsonFileHoldService jsonFileHoldService)
        {
            JsonFileHoldService = jsonFileHoldService;
            //HoldListe = MockHold.GetHoldListe(); 
            HoldListe = JsonFileHoldService.GetJsonHold().ToList(); 
        }
        //Martin Venge Skytte
        public List<Hold> GetHoldListe()
        {
            return HoldListe;
        }
        //Thomas
        public void AddHold(Hold hold)
        {
            HoldListe.Add(hold);
            JsonFileHoldService.SaveJsonHold(HoldListe); 
        }

        //Nicolai
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
        //Thomas
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

        //Martin Venge Skytte
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
