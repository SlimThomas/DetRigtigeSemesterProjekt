using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.ServiceCRUD;
using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
   
             public class DeleteLocationModel : PageModel
        {
            private ILocationService _locationService;

        // Her tilføjer vi en property
            [BindProperty]
            public Location location { get; set; }

            public DeleteLocationModel(ILocationService locationService)
            {
                _locationService = locationService;
            }
            public IActionResult OnGet(string str)
            {
                location = _locationService.GetLocation(str);
                if (location == null)
                {
                    return RedirectToPage("/NotFound");
                }
                return Page();
            }
              // Her initialisere jeg propertien med det item som skal slettes, og det gør man ved at kalde på GetLocation.

            public IActionResult OnPost(string str)
            {
                Models.Location deletedlocation = _locationService.DeleteLocation(location.Address);
                if (deletedlocation == null)
                {
                    return RedirectToPage("/NotFound");
                }
                return RedirectToPage("GetAllLocation");
            }
        }
    }         
