using BarEventPlannerV2.Models;
using BarEventPlannerV2.Service.Repositories.Base;
using BarEventPlannerV2.Service.Repositories.Interface;
// taget fra Per Laursens Github og rettet til af Andreas Dragsberg
namespace BarEventPlannerV2.Service.Repositories.Implementation
{
    public class KundeRepository : RepositoryBase<Kunde>, IKundeRepository
    {
            
        public KundeRepository(IWebHostEnvironment WebHostEnvironment)
    : base(new JsonFileRepositoryBase<Kunde>(WebHostEnvironment, "Kunder.json"))
        {
        }
    }
}
