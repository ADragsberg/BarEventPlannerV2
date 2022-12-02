using BarEventPlannerV2.Models;
using BarEventPlannerV2.Service.Repositories.Base;
using BarEventPlannerV2.Service.Repositories.Interface;
// taget fra Per Laursens Github og rettet til af Andreas Dragsberg
namespace BarEventPlannerV2.Service.Repositories.Implementation
{
    public class EventRepository : RepositoryBase<Event>, IEventRepository
    {
        public EventRepository(IWebHostEnvironment WebHostEnvironment)
    : base(new JsonFileRepositoryBase<Event>(WebHostEnvironment, "Events.json"))
        {
        }
    }
}
