using DetRigtigeSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
    public class GetAllHundeEjerModel : PageModel
    {
        private IHundeEjerService _hundeEjerService;


        [BindProperty]
        public string SearchString { get; set; }


        public List<HundeEjer> hundeEjere { get; set; }

        public GetAllHundeEjerModel(IHundeEjerService hundeEjerService)
        {
            _hundeEjerService = hundeEjerService;
        }

        public void OnGet()
        {
            hundeEjere = _hundeEjerService.GetHundeEjere();
        }

        public IActionResult OnPostNameSearch()
        {
            hundeEjere = _hundeEjerService.NameSearch(SearchString).ToList();
            return Page();
        }
    }
}
