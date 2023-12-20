using DetRigtigeSemesterProjekt.ServiceCRUD;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
             public class EditItemModel : PageModel
        {
            private ILocationService locationService;
            [BindProperty]
            public Models.Location Location { get; set; }

            public EditItemModel(ILocationService itemService)
            {
                locationService = itemService;
            }
        // Her tilføjer jeg en constructor, som injicere ILocationService
            public IActionResult OnGet(string id)
            {
                Location = locationService.GetLocation(id);
                if (Location == null)
                {
                    return RedirectToPage("/NotFound");
                }
                return Page();
            }
            public IActionResult OnPost()
            {
                if (!ModelState.IsValid)
                {
                    return Page();

                }
                locationService.UpdateLocation(Location);
                return RedirectToPage("GetAllItems");
            }

        // Jeg laver en OnPost metode som skal kalde på UpdateLocation
        }
    }
    

