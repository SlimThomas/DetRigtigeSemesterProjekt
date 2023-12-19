using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.ServiceCRUD;
using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
    //Nicolai Jaksland
    public class DeleteHundModel : PageModel
    {
        //Laver en ny instancefield
        private IHundeService _hundService;

        //Binder proprty Hund fra Models så HTML filen kan bruge den
        [BindProperty]
        public Hund hund { get; set; }

        //Giver metoden værdier
        public DeleteHundModel(IHundeService hundService)
        {
            _hundService = hundService;
        }

        //Vi laver en OnGet metode der sender dig til en "NotFound side", hvis hundens ID man taster ind ikke findes.
        public IActionResult OnGet(int id)
        {
            hund = _hundService.GetHund(id);
            if (hund == null)
            {
                return RedirectToPage("/Not found");
            }
            return Page();
        }

        //OnPost fjerner den nuværnde hund, og hvis man prøver at edit den redireter den til "Not Found"
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
