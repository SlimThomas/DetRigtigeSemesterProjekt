using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.ServiceCRUD;
using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
    //Martin Venge Skytte
    public class EditTrænerModel : PageModel
    {
        private ITrænerService _trænerService;

        [BindProperty]
        public Træner Træner { get; set; }

        public EditTrænerModel(ITrænerService trænerservice)
        {
            _trænerService = trænerservice;
        }
        public IActionResult OnGet(int id)
        {
            Træner = _trænerService.GetTræner(id);
            if (Træner == null)
            {
                return RedirectToPage("/Not Found"); //Not Found er ikke defineret endnu

                return Page();
            }
            return null;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _trænerService.UpdateTræner(Træner);
            return RedirectToPage("GetAllItems");
        }
    }
}
