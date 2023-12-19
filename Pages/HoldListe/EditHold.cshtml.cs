using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.Pages.HoldListe
{
    //Nicolai Jaksland
    public class EditHoldModel : PageModel
    {
        //Laver en ny instancefield
        private IHoldService _holdService;

        //Binder proprty Hold fra Models så HTML filen kan bruge den
        [BindProperty]
        public Hold Hold { get; set; }


        public EditHoldModel(IHoldService holdService)
        {
            _holdService = holdService;
        }


        //Vi laver en OnGet metode der sender dig til en "NotFound side", hvis holdets ID man taster ind ikke findes.
        public IActionResult OnGet(int id)
        {
            Hold = _holdService.GetHold(id);
            if (Hold == null)
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
            _holdService.UpdateHold(Hold);
            return RedirectToPage("GetAllHold");
        }
    }
}
