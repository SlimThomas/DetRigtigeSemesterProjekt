using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.ServiceCRUD;
using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
    public class EditHundModel : PageModel
    {
        private IHundeService _hundService;


        [BindProperty]
        public Hund hund { get; set; }


        public EditHundModel(IHundeService hundService)
        {
            _hundService = hundService;
        }


        public IActionResult OnGet(int id)
        {
            hund = _hundService.GetHund(id);
            if (hund == null)
                return RedirectToPage("/NotFound");
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _hundService.UpdateHund(hund);
            return RedirectToPage("GetAllHold");
        }
    }
}
