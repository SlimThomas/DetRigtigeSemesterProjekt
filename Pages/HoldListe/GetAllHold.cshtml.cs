using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.Pages.HoldListe
{
    //Martin Venge Skytte
    public class GetAllHoldModel : PageModel
    {
        //Her forbinder jeg vores service interface
        private IHoldService _holdService;
        //Her kalder jeg på den liste jeg lavede i MockHold og laver det til en property 
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
