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

        //Binder proprty Hund fra Models s� HTML filen kan bruge den
        [BindProperty]
        public Hund hund { get; set; }

        //Giver metoden v�rdier
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

        //OnPost fjerner den nuv�rnde hund, og hvis man pr�ver at edit den redireter den til "Not Found"
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
