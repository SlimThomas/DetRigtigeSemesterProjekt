using DetRigtigeSemesterProjekt.Models;
using System.Text.Json;

namespace DetRigtigeSemesterProjekt.Services
{//Thomas
    public class JsonFileHoldService
    {
        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Hold.json"); }
        }

        public JsonFileHoldService(IWebHostEnvironment webHostEnvironment) 
        {
            WebHostEnvironment = webHostEnvironment;
        }

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

        public IEnumerable<Hold> GetJsonHold()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Hold[]>(jsonFileReader.ReadToEnd()); 
            }
        }
       

    }
}
