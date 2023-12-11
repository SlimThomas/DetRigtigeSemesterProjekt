using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
    public class CreateHundModel : PageModel
    {
        private IHundService _hundService;

        [BindProperty]
        public Models.Hund Hund { get; set; }

        public CreateHundModel(IHundService hundService)
        {
            _hundService = hundService;
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
            _hundService.AddHund(Hund);
            return RedirectToPage("GetAllHund");
        }
    }
}
