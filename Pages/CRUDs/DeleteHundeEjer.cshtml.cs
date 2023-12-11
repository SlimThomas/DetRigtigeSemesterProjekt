using DetRigtigeSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
    public class DeleteHundeEjerModel : PageModel
    {

        private IHundeEjerService _hundeEjerService;

        [BindProperty]
        public HundeEjer hundeEjer { get; set; }

        public DeleteHundeEjerModel(IHundeEjerService hundeEjerService)
        {
            _hundeEjerService = hundeEjerService;
        }



        public IActionResult OnGet(int id)
        {
            hundeEjer = _hundeEjerService.GetHundeEjer(id);
            if (hundeEjer == null)
            {
                return RedirectToPage("/Not found");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            HundeEjer deletedhundeEjer = _hundeEjerService.DeleteHundeEjer(hundeEjer.Id);
            if (deletedhundeEjer == null)
            {
                return RedirectToPage("/Not Found");
            }
            return RedirectToPage("GetAllHundeEjer");
        }
    }
}
