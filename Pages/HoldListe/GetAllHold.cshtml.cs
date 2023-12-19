using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.Pages.HoldListe
{
    // (Thomas) - Her laver vi endnu en razor page. Vi tilføjer denne instancefield til klassen, så klassen kan benytte vores service, og anvende listen af hold objekter.
    public class GetAllHoldModel : PageModel
    {
        //Her forbinder jeg vores service interface
        private IHoldService _holdService;
        
        public List<Hold> HoldListe { get; set; }
        // (Thomas) her anvender vi en "BindProperty", som binder denne property "public Models.Hold Hold { get; set; }, dette gøres så det er denne property der er bundet til UI'en, altså siden. 
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
