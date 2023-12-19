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
            private ILocationService locationService;
            public GetAllLocationModel(ILocationService locationService)
            {
                locationService = locationService;
            }
            public void OnGet()
            {
                Items = locationService.GetLocation();
            }
        }
    }
    

