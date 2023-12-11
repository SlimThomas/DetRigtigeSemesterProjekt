using DetRigtigeSemesterProjekt.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DetRigtigeSemesterProjekt.Pages.HoldListe
{
    public class DeleteHoldModel : PageModel
    {
        private IHoldService _holdService;

        [BindProperty]
        public Models.Hold hold { get; set; }

        public DeleteHoldModel(HoldService holdService)
        {
            _holdService = holdService;
        }

        public IActionResult OnGet(int id)
        {
            hold = _holdService.GetHold(id);
            if(hold == null)
            {
                return RedirectToPage("/Not Found");
            }
            return Page(); 
        }

        public IActionResult OnPost()
        {
            Models.Hold DeletedHold = _holdService.DeleteHold(hold.Id);
            if (DeletedHold == null)
            {
                return RedirectToPage("/Not found");
            }
            return RedirectToPage("GetAllHold"); 
                
        }
        
    }
}
