using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.ServiceCRUD
{
    //Nicolai Jaksland
    //Her inde er alle metoderne som en bruger kan kalde
    public interface IHundeService
    {
        List<Hund> GetHundListe();

        void AddHund(Hund hund);

        void UpdateHund(Hund hund);

        Hund GetHund(int id);

        Hund DeleteHund(int? id);
    }
}
