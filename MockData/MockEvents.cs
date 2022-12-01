using BarEventPlannerV2.Models;

namespace BarEventPlannerV2.MockData
{
    public class MockEvents
    {
        private static TimeSpan wholeDay = new TimeSpan (24,0,0);
        private static List<Event> _items = new List<Event>()
        {
            new Event(1, 20, "Børges Børnefødselsdag", true, "Børge har fødselsdag kom med gaver og få masser af lagkage", new TimeSpan(4,30,0)),
            new Event(2, 100, "Dorits drukfest", false, "Kom alle, kom glade. Der skal drikkes", wholeDay)
                    };
    }
}
