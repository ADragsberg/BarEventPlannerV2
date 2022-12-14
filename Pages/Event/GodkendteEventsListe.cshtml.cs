using BarEventPlannerV2.Service.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BarEventPlannerV2.Pages.Event
{ 
	//Lavet af Tristan
    public class GodkendteEventsListeModel : PageModel
    {
		// Felter
		private readonly IEventRepository _eventRepository;
		private readonly IKundeRepository _kundeRepository;

		// Konstruktør
		public GodkendteEventsListeModel(IEventRepository eventRepository, IKundeRepository kundeRepository)
		{
			_eventRepository = eventRepository;
			_kundeRepository = kundeRepository;
		}

		// Props
		[BindProperty]
		public List<@Models.Event> Events { get; set; }



		public IActionResult OnGet()
        {
			Events = _eventRepository.GetAll().ToList();

			return Page();
		}

		
		
    }
}
