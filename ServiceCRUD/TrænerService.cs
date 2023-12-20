using DetRigtigeSemesterProjekt.MockData;
using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.Services;

namespace DetRigtigeSemesterProjekt.ServiceCRUD
{
    //Martin Venge Skytte
    public class TrænerService : ITrænerService
    {
        public List<Træner> TrænerListe { get; private set; }
        //private JsonFileTrænerService JsonFileTrænerService { get; set; }

        public TrænerService()
        {
            TrænerListe = MockTræner.GetTrænerListe();
        }

        public List<Træner> GetTrænerListe()
        {
            return TrænerListe;
        }

        public void AddTræner(Træner træner)
        {
            TrænerListe.Add(træner);
            //JsonFileTrænerService.SaveJsonTræner(TrænerListe);
        }

        public IEnumerable<Træner> NameSearch(string str)
        {
            List<Træner> nameSearch = new List<Træner>();
            foreach (Træner træner in TrænerListe)
            {
                if (træner.Name.ToLower().Contains(str.ToLower()))
                {
                    nameSearch.Add(træner);
                }
            }
            return nameSearch;
        }
        public void UpdateTræner(Træner træner)
        {
            if (træner != null)
            {
                foreach (Træner t in TrænerListe)
                {
                    if (t.Id == træner.Id)
                    {
                        t.Name = træner.Name;
                        t.Tlf = træner.Tlf;
                        t.Mail = træner.Mail;
                        t.Wage = træner.Wage;
                        t.HoursWorked = træner.HoursWorked;
                    }
                    //JsonFileTrænerService.SaveJsonTræner(TrænerListe);
                }
            }
        }
        public Træner GetTræner(int id)
        {
            if (id != null)
            {
                foreach (Træner t in TrænerListe)
                {
                    return t;
                }
            }
            return null;
        }
        public Træner DeleteTræner(int? trænerId)
        {
            foreach (Træner t in TrænerListe)
            {
                if (t.Id == trænerId)
                {
                    TrænerListe.Remove(t);
                    //JsonFileTrænerService.SaveJsonTræner(TrænerListe);
                    return t;
                }
            }
            return null;
        }
        /*public TrænerService(JsonFileTrænerService jsonFileTrænerService)
        {
            JsonFileTrænerService = jsonFileTrænerService;
            //HoldListe = MockHold.GetHoldListe(); 
            TrænerListe = JsonFileTrænerService.GetJsonTræner().ToList();
        }*/

    }
}
