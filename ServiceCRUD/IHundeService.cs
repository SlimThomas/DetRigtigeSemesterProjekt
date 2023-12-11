using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.ServiceCRUD
{
    public interface IHundeService
    {
        List<Hund> GetHundListe();

        void AddHund(Hund hund);

        void UpdateHund(Hund hund);

        Hund GetHund(int id);

        Hund DeleteHund(int? id);
    }
}
