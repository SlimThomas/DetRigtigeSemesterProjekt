using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.ServiceCRUD;
using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
    public class DeleteHundModel : PageModel
    {
        private IHundeService _hundService;

        [BindProperty]
        public Hund hund { get; set; }

        public DeleteHundModel(IHundeService hundService)
        {
            _hundService = hundService;
        }

        public IActionResult OnGet(int id)
        {
            hund = _hundService.GetHund(id);
            if (hund == null)
            {
                return RedirectToPage("/Not found");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            Hund deletedhund = _hundService.DeleteHund(hund.Id);
            if (deletedhund == null)
            {
                return RedirectToPage("/Not Found");
            }
            return RedirectToPage("GetAllHundeEjer");
        }
    }
}
