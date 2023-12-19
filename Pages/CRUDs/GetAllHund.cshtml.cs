using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.ServiceCRUD;
using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
    //Nicolai Jaksland
    public class GetAllHundModel : PageModel
    {
        //Den kalder på metoden igennem IHundeservice
        private IHundeService _hundService;
        public List<Hund> HundListe { get; set; }
        public GetAllHundModel(IHundeService hundService)
        {
            _hundService = hundService;
        }

        //Den henter GetHundeListe
        public void OnGet()
        {
            HundListe = _hundService.GetHundListe();
        }
    }
}
