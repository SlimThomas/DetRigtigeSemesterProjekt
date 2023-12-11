using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.ServiceCRUD;
using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
    public class CreateHundModel : PageModel
    {
        private IHundeService _hundService;

        [BindProperty]
        public Models.Hund Hund { get; set; }

        public CreateHundModel(IHundeService hundService)
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
