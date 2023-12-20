using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.ServiceCRUD;
using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
    public class EditHundeEjerModel : PageModel
    {
        private IHundeEjerService _hundeEjerService;

        // (Thomas) Binder proprty Hold fra Models så propertien bliver bundet til HTML'en 
        [BindProperty]
        public HundeEjer hundeEjer { get; set; }

        public EditHundeEjerModel(IHundeEjerService hundeEjerService)
        {
            _hundeEjerService = hundeEjerService;
        }


        // (Thomas) Vi laver en OnGet metode der sender dig til en "NotFound side", hvis holdets ID man taster ind ikke findes.
        public IActionResult OnGet(int id)
        {
            hundeEjer = _hundeEjerService.GetHundeEjer(id);
            if (hundeEjer == null)
            {
                return RedirectToPage("/Not Found");
            }
            return Page();

        }

        //OnPost bliver brugt for at lægge den nye information op på siden
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _hundeEjerService.UpdateHundeEjer(hundeEjer);
            return RedirectToPage("GetAllHundeEjere");
        }

    }
}
