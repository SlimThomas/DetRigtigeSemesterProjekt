using DetRigtigeSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
    public class CreateTrænerModel : PageModel
    {
        private ITrænerService _trænerService;
        [BindProperty] public Træner Træner { get; set; }

        public CreateTrænerModel(ITrænerService trænerService)
        {
            _trænerService = trænerService;
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
            _trænerService.AddTræner(Træner);
            return RedirectToPage("GetAllTræner");
        }
    }
}
