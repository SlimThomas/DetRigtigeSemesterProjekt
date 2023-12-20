using DetRigtigeSemesterProjekt.MockData;
using DetRigtigeSemesterProjekt.Models;
using System.Text.Json;

namespace DetRigtigeSemesterProjekt.ServiceCRUD
{
    //Martin Venge Skytte
    public class JsonFileTrænerService
    {
        public IWebHostEnvironment WebHostEnvironment { get; }

        public JsonFileTrænerService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        //WebHostEnvironment er en service der kan bruges til at hjælpe vores JsonFile med at finde vej til vores Data mappe og Træner.json fil.
        //Derfor laver vi en dependency injection i vores konstruktor

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Træner.json"); }
            //her benytter vi servicen så vi kan få en fil samt en sti til dens placering
        }

        public void SaveJsonTræner(List<Træner> trænerliste)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<Træner[]>(jsonWriter, trænerliste.ToArray());
            }
        }
        
        public IEnumerable<Træner> GetJsonTræner()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Træner[]>(jsonFileReader.ReadToEnd());
            }
        }
    }
}
