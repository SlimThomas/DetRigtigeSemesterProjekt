using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.Pages.HoldListe
{
    // (Thomas) Her laver vi en razorpage, som hedder GetAllHoldModel, som er den razorpage som der linkes til når der klikkes på navBar linket "Hold". 
    public class GetAllHoldModel : PageModel
    {
        //(Thomas) Her forbinder jeg vores service interface, vha i nstancefield. 
        private IHoldService _holdService;
        
        public List<Hold> HoldListe { get; set; }
        [BindProperty] public string SearchString { get; set; }
        // (Thomas) Her laver vi en dependency injection, da servicen er argument til konstruktoren. 
        public GetAllHoldModel(IHoldService holdService)
        {
            _holdService = holdService;
        }
        // (Thomas) Her laver vi en OnGet metode, som henter mockdataen via servicen (inden man rykker over på Json filerne) -- Der er så senere blevet ændret i GetHoldListe metoden
        // så den tager json filerne i stedet for vores mock data. 
        public void OnGet()
        {
            HoldListe = _holdService.GetHoldListe(); ;
        }
        public IActionResult OnPostNameSearch()
        {
            HoldListe = _holdService.NameSearch(SearchString).ToList();
            return Page();
        }
       

    }
}
