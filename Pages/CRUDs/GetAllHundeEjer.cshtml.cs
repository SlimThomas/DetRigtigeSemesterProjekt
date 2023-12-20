using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.ServiceCRUD;
using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
    public class GetAllHundeEjerModel : PageModel
    {
        // (Thomas) - Her laver vi endnu en razor page. Vi tilføjer denne instancefield til klassen, så klassen kan benytte vores service, og anvende listen af hold objekter.
        private IHundeEjerService _hundeEjerService;

        // (Thomas) her anvender vi en "BindProperty", som binder denne property "public Models.Hold Hold { get; set; }, dette gøres så det er denne property der er bundet til UI'en,
        // altså siden. 
        [BindProperty]
        public string SearchString { get; private set; }


        public List<HundeEjer> hundeEjere { get; set; }

        // (Thomas) Her laver vi en dependency injection, da servicen er argument til konstruktoren. 
        public GetAllHundeEjerModel(IHundeEjerService hundeEjerService)
        {
            _hundeEjerService = hundeEjerService;
        }

        public void OnGet()
        {
            hundeEjere = _hundeEjerService.GetHundeEjere();
        }

        public IActionResult OnPostNameSearch()
        {
            hundeEjere = _hundeEjerService.NameSearch(SearchString).ToList();
            return Page();
        }
    }
}
