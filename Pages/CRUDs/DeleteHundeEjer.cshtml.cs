using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.ServiceCRUD;
using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
    public class DeleteHundeEjerModel : PageModel
    {
        // (Thomas) - Her laver vi endnu en razor page. Vi tilføjer denne instancefield til klassen, så klassen kan benytte vores service, og anvende listen af hold objekter. 
        private IHundeEjerService _hundeEjerService;

        // (Thomas) her anvender vi en "BindProperty", som binder denne property "public Models.Hold Hold { get; set; }, dette gøres så det er denne property der er bundet til UI'en,
        // altså siden. 
        [BindProperty]
        public HundeEjer hundeEjer { get; set; }

        // (Thomas) Her laver vi en dependency injection, da servicen er argument til konstruktoren. 
        public DeleteHundeEjerModel(IHundeEjerService hundeEjerService)
        {
            _hundeEjerService = hundeEjerService;
        }



        public IActionResult OnGet(int id)
        {
            hundeEjer = _hundeEjerService.GetHundeEjer(id);
            if (hundeEjer == null)
            {
                return RedirectToPage("/Not found");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            HundeEjer deletedhundeEjer = _hundeEjerService.DeleteHundeEjer(hundeEjer.Id);
            if (deletedhundeEjer == null)
            {
                return RedirectToPage("/Not Found");
            }
            return RedirectToPage("GetAllHundeEjer");
        }
    }
}
