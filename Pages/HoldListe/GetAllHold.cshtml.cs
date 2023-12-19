using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.Pages.HoldListe
{
    // (Thomas) - Her laver vi endnu en razor page. Vi tilf�jer denne instancefield til klassen, s� klassen kan benytte vores service, og anvende listen af hold objekter.
    public class GetAllHoldModel : PageModel
    {
        //Her forbinder jeg vores service interface
        private IHoldService _holdService;
        
        public List<Hold> HoldListe { get; set; }
        // (Thomas) her anvender vi en "BindProperty", som binder denne property "public Models.Hold Hold { get; set; }, dette g�res s� det er denne property der er bundet til UI'en, alts� siden. 
        [BindProperty] public string SearchString { get; set; }
        // (Thomas) Her laver vi en dependency injection, da servicen er argument til konstruktoren. 
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
        

    }
}
