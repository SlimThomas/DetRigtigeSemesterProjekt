using DetRigtigeSemesterProjekt.Models;

namespace DetRigtigeSemesterProjekt.Services
{
    //Martin Venge Skytte
    public interface IHoldService
    {
        //Martin Venge Skytte
        List<Hold> GetHoldListe();
        //Thomas
        void AddHold(Hold hold);
        //Nicolai
        void UpdateHold(Hold hold);

        Hold GetHold(int id);
        //Thomas
        Hold DeleteHold(int? id);
        //Martin Venge Skytte
        IEnumerable<Hold> NameSearch(string str);
    }
}
