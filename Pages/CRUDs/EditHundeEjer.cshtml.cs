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

        [BindProperty]
        public HundeEjer hundeEjer { get; set; }

        public EditHundeEjerModel(IHundeEjerService hundeEjerService)
        {
            _hundeEjerService = hundeEjerService;
        }



        public IActionResult OnGet(int id)
        {
            hundeEjer = _hundeEjerService.GetHundeEjer(id);
            if (hundeEjer == null)
            {
                return RedirectToPage("/Not Found");
            }
            return Page();

        }

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
