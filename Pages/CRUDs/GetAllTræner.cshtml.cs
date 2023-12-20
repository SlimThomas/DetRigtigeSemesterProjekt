using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DetRigtigeSemesterProjekt.ServiceCRUD;
using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.MockData;

namespace DetRigtigeSemesterProjekt.Pages.CRUDs
{
    //Martin Venge Skytte
    public class GetAllTrænerModel : PageModel
    {
        //her bliver der sørget for at der er en forbindelse til serviceklasserne
        private ITrænerService _trænerService;
        public List<Træner> TrænerListe { get; private set; }
        [BindProperty] public string SearchString { get; set; }
        public GetAllTrænerModel(ITrænerService trænerservice)
        {
            _trænerService = trænerservice;
        }

        //Vores OnGet() Metode går i gang når vi kommer ind på Pagen
        public void OnGet()
        {
            TrænerListe = _trænerService.GetTrænerListe(); ;
        }
        //mens vores OnPost() Metode går i gang nå vi trykker på knappen
        public IActionResult OnPostNameSearch()
        {
            TrænerListe = _trænerService.NameSearch(SearchString).ToList();
            return Page();
        }
    }
}
