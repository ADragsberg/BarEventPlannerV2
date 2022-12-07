using BarEventPlannerV2.Service.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//Lavet af Tristan

namespace BarEventPlannerV2.Pages.Event
{
    public class ListOfEventCardsModel : PageModel
    {
		private IEventRepository _eventRepository;
		private IKundeRepository _kundeRepository;

		// Constructor with EventService dependency injection
		public ListOfEventCardsModel(IEventRepository eventRepository, IKundeRepository kundeRepository)
		{
			_eventRepository = eventRepository;
			_kundeRepository = kundeRepository;
		}

		[BindProperty]
		public List<@Models.Event> Events { get; set; }
		


		public void OnGet()
        {
			Events = _eventRepository.GetAll().ToList();
		}
    }
	
}
