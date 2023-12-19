using DetRigtigeSemesterProjekt.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.MockData;
using DetRigtigeSemesterProjekt.Models;

namespace DetRigtigeSemesterProjekt.Pages.HoldListe
{
    public class CreateHoldModel : PageModel
    {
        // (Thomas) - Her laver vi endnu en razor page. Vi tilf�jer denne instancefield til klassen, s� klassen kan benytte vores service, og anvende listen af hold objekter. 
        private IHoldService _holdService;

        // (Thomas) her anvender vi en "BindProperty", som binder denne property "public Models.Hold Hold { get; set; }, dette g�res s� det er denne property der er bundet til UI'en, alts� siden. 
       
        [BindProperty]
        public Models.Hold Hold { get; set; }
        // (Thomas) Her laver vi en dependency injection, da servicen er argument til konstruktoren. 
        public CreateHoldModel(IHoldService holdService)
        {
            _holdService = holdService;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _holdService.AddHold(Hold);
            return RedirectToPage("GetAllHold");
        }
    }
}
