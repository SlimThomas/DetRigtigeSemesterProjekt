using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.ServiceCRUD
{
    //Martin Venge Skytte
    public interface ITrænerService
    {
        //Her bliver der tilføjet Metode signaturer i vores interface som så senere vil blive implementeret
        //i service klassen
        List<Træner> GetTrænerListe();
        void AddTræner(Træner træner);
        IEnumerable<Træner> NameSearch(string str);
        public void UpdateTræner(Træner træner);

        public Træner GetTræner(int id);
        public Træner DeleteTræner(int? trænerId);
    }
}
