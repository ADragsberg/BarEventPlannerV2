using BarEventPlannerV2.Models;

namespace BarEventPlannerV2.Service
{
    public class EventService : IEventService
    {
        private List<Event> _events;
        private JSONFileEventService JsonFileEventService { get; set; }

        public EventService(JSONFileEventService jsonFileEventService)
        {
            JsonFileEventService = jsonFileEventService;
            //_events = MockData.MockEvents.GetMockEvents();
            //JsonFileEventService.SaveJsonEvents(_events);
            _events = JsonFileEventService.GetJsonEvents().ToList();
        }

        public void CreateEvent(Event Event)
        {
             {
                _events.Add(Event);
                JsonFileEventService.SaveJsonEvents(_events);
            }

        }

    }
}
