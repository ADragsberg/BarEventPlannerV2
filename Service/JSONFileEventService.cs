using System.Text.Json;
using BarEventPlannerV2.Models;

namespace BarEventPlannerV2.Service
{   
    //Skrevet af Andreas Dragsberg og tyv stjålet fra Per Laursen.
    public class JSONFileEventService
    {
        public IWebHostEnvironment WebHostEnvironment { get; }

        public JSONFileEventService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Events.json"); }
        }

        public void SaveJsonEvents(List<Event> events)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<Event[]>(jsonWriter, events.ToArray());
            }
        }

        public IEnumerable<Event> GetJsonEvents()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Event[]>(jsonFileReader.ReadToEnd());
            }
        }
    }

}
