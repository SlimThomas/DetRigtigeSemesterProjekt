using DetRigtigeSemesterProjekt.Models;

namespace DetRigtigeSemesterProjekt.Services
{
    public interface IHoldService
    {
        List<Hold> GetHoldListe();

        void AddHold(Hold hold);

        void UpdateHold(Hold hold);

        Hold GetHold(int id);
    }
}
