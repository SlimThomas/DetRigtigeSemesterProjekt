using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.ServiceCRUD;
using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
    //Nicolai Jaksland
    public class CreateHundModel : PageModel
    {
        //Laver en ny instancefield
        private IHundeService _hundService;

        //Binder proprty Hund fra Models s� HTML filen kan bruge den
        [BindProperty]
        public Models.Hund Hund { get; set; }

        //Giver metoden v�rdier som den skal bruge
        public CreateHundModel(IHundeService hundService)
        {
            _hundService = hundService;
        }

        //Vi laver en OnGet metode der sender dig til en "NotFound side", hvis hundens ID man taster ind ikke findes.
        public IActionResult OnGet()
        {
            return Page();
        }

        //OnPost fjerner den nuv�rnde hund, og hvis man pr�ver at edit den redireter den til "Not Found"
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
