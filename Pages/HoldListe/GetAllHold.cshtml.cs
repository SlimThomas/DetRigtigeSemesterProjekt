using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.Pages.HoldListe
{
    public class GetAllHoldModel : PageModel
    {
        private IHoldService _holdService;
        public List<Hold> HoldListe { get; set; }
        [BindProperty] public string SearchString { get; set; }
        public GetAllHoldModel(IHoldService holdService)
        {
            _holdService = holdService;
        }
        public void OnGet()
        {
            HoldListe = _holdService.GetHoldListe(); ;
        }
        public IActionResult OnPostNameSearch()
        {
            HoldListe = _holdService.NameSearch(SearchString).ToList();
            return Page();
        }
        /*public IActionResult OnPostIdSearch()
        {

        }*/

    }
}
