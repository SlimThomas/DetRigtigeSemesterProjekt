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
            public CreateLocationModel(ILocationService itemService)
            {
                locationService = itemService;
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
                locationService.AddLocation(Location);
                return RedirectToPage("/Item/GetAllItems");
            }
        }
    }

