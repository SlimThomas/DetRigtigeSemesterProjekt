using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.ServiceCRUD
{
    public interface IHundeEjerService
    {

        List<HundeEjer> GetHundeEjere();

        void AddHundeEjer(HundeEjer hundeEjer);

        IEnumerable<HundeEjer> NameSearch(string str);

        void UpdateHundeEjer(HundeEjer hundeEjer);

        HundeEjer GetHundeEjer(int id);

        HundeEjer DeleteHundeEjer(int? id);


    }
}
