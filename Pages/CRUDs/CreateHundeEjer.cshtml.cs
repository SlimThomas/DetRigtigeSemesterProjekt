using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
    public class CreateHundeEjerModel : PageModel
    {

        private IHundeEjerService _hundeEjerService;

        [BindProperty]
        public Models.HundeEjer hundeEjer { get; set; }

        public CreateHundeEjerModel(IHundeEjerService hundeEjerService)
        {
            _hundeEjerService = hundeEjerService;
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
            _hundeEjerService.AddHundeEjer(hundeEjer);
            return RedirectToPage("GetAllHundeEjer");
        }

    }
}
