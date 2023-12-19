using DetRigtigeSemesterProjekt.Models;
using System.Text.Json;

namespace DetRigtigeSemesterProjekt.Services
{//Thomas
    public class JsonFileHoldService
    {
        
        public IWebHostEnvironment WebHostEnvironment { get; }
        // (Thomas) WebHostEvironment er en service der bl.a benyttes til at få stien til placeringen af vores Json fil (Hold.Json) 
        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Hold.json"); }
        }
        // (Thomas) Her er der en property, som returnerer filnavnet, ved at tage stien til RootPath, Data, også ligge dem sammen

        public JsonFileHoldService(IWebHostEnvironment webHostEnvironment) 
        {
            WebHostEnvironment = webHostEnvironment;
        }

        // (Thomas) Her bruges der JsonSerializer, som konverterer vores data til et Array med objekter. 
        
        public void SaveJsonHold(List<Hold>holdliste)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<Hold[]>(jsonWriter, holdliste.ToArray()); 
            }
        }
        // (Thomas) Ligeledes anvendes "Deserialize", som tager data i et Array, og "pakker" dem ud til deres originale stand
        public IEnumerable<Hold> GetJsonHold()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Hold[]>(jsonFileReader.ReadToEnd()); 
            }
        }
       

    }
}
