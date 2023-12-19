using DetRigtigeSemesterProjekt.MockData;
using DetRigtigeSemesterProjekt.Models;

namespace DetRigtigeSemesterProjekt.Services
{
    // (Thomas) her laver vi et Holdservice, som skal bruges til at hente data fra mockhold, og senere fra JsonFilen. 
    public class HoldService : IHoldService
    {
        
        public List<Hold> HoldListe { get; private set; }
        
        // (Thomas) Her bliver servicen injiceres ind i ItemService
        private JsonFileHoldService JsonFileHoldService { get; set; }
        
        public HoldService()
        {
            HoldListe = MockHold.GetHoldListe();
        }
       //(Thomas) vi laver en constructor der initialisere Hold med mockdata, hvorefter vi har tilføjet jsonFileHoldService til constructoren, så den initialisere med data fra Json filen
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
        // (Thomas) Der bliver kaldt AddHold() metoden, når OnPost() metoden bliver kørt i CreateHold.cs
        // (Thomas) Der er opdateret metoden "AddHold" med json, så den SaveJsonHold() metoden bliver kaldt
        public void AddHold(Hold hold)
        {
            HoldListe.Add(hold);
            JsonFileHoldService.SaveJsonHold(HoldListe); 
        }

        // (Thomas) Her bliver der lavet en metode "UpdateHold()", som bliver kaldt når OnPost() bliver anvendt i EditHoldModel.cs
        // (Thomas) Metoden gennekøber listen og finde et hold, med samme id, og sætter de andre parametre = det man har skrevet. 
        // (Thomas) Der er opdateret metoden "AddHold" med json, så den SaveJsonHold() metoden bliver kaldt
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
        // (Thomas) Der er opdateret metoden "AddHold" med json, så den SaveJsonHold() metoden bliver kaldt
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

        // (Thomas) Her tilføjes der en søge funktion, som benytter interfacet IEnumerable, som vi anvender istedet for klassen "list". Interfacet implementere Listen. 
        // (Thomas) Her laves der en funktion, som tager en string, og returnere alle hold der har samme string (name)
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
