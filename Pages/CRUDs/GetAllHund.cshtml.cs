using DetRigtigeSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
    public class GetAllHundModel : PageModel
    {
        private IHundService _hundService;
        public List<Hund> HundListe { get; set; }
        public GetAllHundModel(IHundService hundService)
        {
            _hundService = hundService;
        }
        public void OnGet()
        {
            HundListe = _hundService.GetHundListe();
        }
    }
}
