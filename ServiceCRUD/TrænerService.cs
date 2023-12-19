using DetRigtigeSemesterProjekt.MockData;
using DetRigtigeSemesterProjekt.Models;

namespace DetRigtigeSemesterProjekt.ServiceCRUD
{
    //Martin Venge Skytte
    public class TrænerService : ITrænerService
    {
        public List<Træner> TrænerListe { get; private set; }

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
                    return t;
                }
            }
            return null;
        }

    }
}
