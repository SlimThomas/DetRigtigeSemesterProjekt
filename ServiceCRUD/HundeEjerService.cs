using DetRigtigeSemesterProjekt.MockData;
using DetRigtigeSemesterProjekt.Models;

namespace DetRigtigeSemesterProjekt.ServiceCRUD
{
    public class HundeEjerService : IHundeEjerService
    {
        private List<HundeEjer> hundeEjere;

        public HundeEjerService()
        {
            hundeEjere = MockHundeEjer.GetMockHundeEjer();
        }

        public List<HundeEjer> GetHundeEjere()
        {
            return hundeEjere;
        }

        public void AddHundeEjer(HundeEjer hundeejer)
        {
            hundeEjere.Add(hundeejer);
        }

        public IEnumerable<HundeEjer> NameSearch(string str)
        {
            List<HundeEjer> nameSearch = new List<HundeEjer>();
            {
                foreach (HundeEjer hundeEjer in hundeEjere)
                {
                    if (hundeEjer.Name.ToLower().Contains(str.ToLower()))
                    {
                        nameSearch.Add(hundeEjer);
                    }
                }
                return nameSearch;
            }
        }

        public void UpdateHundeEjer(HundeEjer hundeEjer)
        {
            if (hundeEjer != null)
            {
                foreach (HundeEjer i in hundeEjere)
                {
                    if (i.Id == hundeEjer.Id)
                    {
                        i.Name = hundeEjer.Name;
                        i.Address = hundeEjer.Address;
                        i.Tlf = hundeEjer.Tlf;
                        i.Mail = hundeEjer.Mail;
                    }
                }
            }
        }

        public HundeEjer GetHundeEjer(int id)
        {
            foreach (HundeEjer hundeEjer in hundeEjere)
            {
                if (hundeEjer.Id == id)
                {
                    return hundeEjer;
                }
            }

            return null;
        }

        public HundeEjer DeleteHundeEjer(int? id)
        {
            foreach (HundeEjer hundeEjer in hundeEjere)
            {
                if (hundeEjer.Id == id)
                {
                    hundeEjere.Remove(hundeEjer);
                    return hundeEjer;
                }
            }
            return null;
        }
    }
}
