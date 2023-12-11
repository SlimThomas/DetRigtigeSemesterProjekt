using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.ServiceCRUD;
using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
    public class GetAllHundModel : PageModel
    {
        private IHundeService _hundService;
        public List<Hund> HundListe { get; set; }
        public GetAllHundModel(IHundeService hundService)
        {
            _hundService = hundService;
        }
        public void OnGet()
        {
            HundListe = _hundService.GetHundListe();
        }
    }
}
