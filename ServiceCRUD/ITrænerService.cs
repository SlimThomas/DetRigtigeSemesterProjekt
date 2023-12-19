﻿using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.ServiceCRUD
{
    //Martin Venge Skytte
    public interface ITrænerService
    {
        List<Træner> GetTrænerListe();
        void AddTræner(Træner træner);
        IEnumerable<Træner> NameSearch(string str);
        public void UpdateTræner(Træner træner);

        public Træner GetTræner(int id);
        public Træner DeleteTræner(int? trænerId);
    }
}
