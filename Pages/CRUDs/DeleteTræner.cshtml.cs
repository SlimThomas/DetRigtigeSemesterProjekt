using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.ServiceCRUD;
using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
    //Martin Venge Skytte
    public class DeleteTrænerModel : PageModel
    {
        private ITrænerService _trænerService;
        [BindProperty] public Træner Træner { get; set; }

        public DeleteTrænerModel(ITrænerService trænerService)
        {
            _trænerService = trænerService;
        }
        public IActionResult OnGet(int id)
        {
            Træner = _trænerService.GetTræner(id);
            if (Træner == null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }
        public IActionResult OnPost(int id)
        {
            Træner deletedItem = _trænerService.DeleteTræner(id);
            if (deletedItem == null)
            {
                return RedirectToPage("/NotFound");
            }
            return RedirectToPage();
        }
    }
}
