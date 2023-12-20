using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.ServiceCRUD;
using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
  
            public class CreateLocationModel : PageModel
        {
            private ILocationService locationService;

            [BindProperty] public Location Location { get; set; }
       // Her tilf�jer jeg et instancefield til klassen, som g�r at klassen kan bruge service og ogs� anvende listen med Location som den skal bruge.
            public CreateLocationModel(ILocationService itemService)
            {
                locationService = itemService;
            }

        // Her tilf�jer jeg en constructor som injicere ILocationService
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
                locationService.AddLocation(Location);
                return RedirectToPage("/Item/GetAllItems");
            }
        }
    // Jeg tilf�jer en OnPost metode her, s� siden kan returnere sig selv.
    }

