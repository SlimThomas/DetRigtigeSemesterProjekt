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
       // Her tilføjer jeg et instancefield til klassen, som gør at klassen kan bruge service og også anvende listen med Location som den skal bruge.
            public CreateLocationModel(ILocationService itemService)
            {
                locationService = itemService;
            }

        // Her tilføjer jeg en constructor som injicere ILocationService
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
    // Jeg tilføjer en OnPost metode her, så siden kan returnere sig selv.
    }

