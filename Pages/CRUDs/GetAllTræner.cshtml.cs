using DetRigtigeSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
    public class GetAllTrænerModel : PageModel
    {
        private ITrænerService _trænerService;
        public List<Træner> TrænerListe { get; private set; }
        [BindProperty] public string SearchString { get; set; }
        public GetAllTrænerModel(ITrænerService trænerservice)
        {
            _trænerService = trænerservice;
        }
        public void OnGet()
        {
            TrænerListe = _trænerService.GetTrænerListe(); ;
        }
        public IActionResult OnPostNameSearch()
        {
            TrænerListe = _trænerService.NameSearch(SearchString).ToList();
            return Page();
        }
    }
}
