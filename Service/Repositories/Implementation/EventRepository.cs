using BarEventPlannerV2.Models;
using BarEventPlannerV2.Service.Repositories.Base;
using BarEventPlannerV2.Service.Repositories.Interface;
using System.Xml.Linq;
// taget fra Per Laursens Github og rettet til af Andreas Dragsberg
namespace BarEventPlannerV2.Service.Repositories.Implementation
{
    public class EventRepository : RepositoryBase<Event>, IEventRepository
    {
        public EventRepository(IWebHostEnvironment WebHostEnvironment)
    : base(new JsonFileRepositoryBase<Event>(WebHostEnvironment, "Events.json"))
        {
        }
        public void Godkend(int id, Event ev)
        {
            if (ev != null && _data.ContainsKey(id))
            {
                _data[id].Godkend();
                Save();
            }
        }

    }
}
