using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.ServiceCRUD;
using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
    public class GetAllLocationModel : PageModel
    {
            public List<Models.Location> Items { get; set; }
        public List<Location> Location { get; private set; }

        private ILocationService locationService;
            public GetAllLocationModel(ILocationService locationService)
            {
                locationService = locationService;
            }

        // her refaktorer jeg metoden så den kan hente Mockdata igennem service 
            public void OnGet()
            {
                Location = locationService.GetLocation();
            }
        }
    }
    

