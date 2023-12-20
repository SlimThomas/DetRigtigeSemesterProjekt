using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.ServiceCRUD;
using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
    //Martin Venge Skytte
    public class CreateTrænerModel : PageModel
    {
        private ITrænerService _trænerService;

        [BindProperty] public Træner Træner { get; set; }
        //Vi bruger BindProperty her så vi kan binde vores property til htmlsiden
        //Så man i UI'en kan overføre data fra inputfields til propertyen.

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
        //Vores OnPost metode får os tilbage efter at vi har lavet en ny træner.
    }
}
