using DetRigtigeSemesterProjekt.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.MockData;
using DetRigtigeSemesterProjekt.Models;

namespace DetRigtigeSemesterProjekt.Pages.HoldListe
{
    public class CreateHoldModel : PageModel
    {
        private IHoldService _holdService;

        [BindProperty]
        public Models.Hold Hold { get; set; }

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
