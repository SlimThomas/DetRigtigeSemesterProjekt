using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.ServiceCRUD;
using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
    //Nicolai Jaksland
    public class EditHundModel : PageModel
    {
        //Laver en ny instancefield
        private IHundeService _hundService;

        //Binder proprty Hund fra Models så HTML filen kan bruge den
        [BindProperty]
        public Hund hund { get; set; }


        public EditHundModel(IHundeService hundService)
        {
            _hundService = hundService;
        }

        //Vi laver en OnGet metode der sender dig til en "NotFound side", hvis hundens ID man taster ind ikke findes.
        public IActionResult OnGet(int id)
        {
            hund = _hundService.GetHund(id);
            if (hund == null)
                return RedirectToPage("/NotFound");
            return Page();
        }

        //OnPost bliver brugt for at lægge den nye information op på siden
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
