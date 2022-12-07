using BarEventPlannerV2.Models;
using BarEventPlannerV2.Service.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BarEventPlannerV2.Pages.Event
{
    public class SletEventModel : PageModel
    {
		// Felter for the EventRepository and KundeRepository
		private IEventRepository _eventRepository;
		private IKundeRepository _kundeRepository;

		// Konstruktør med EventRepository og KundeRepository som dependency injection
		public SletEventModel(IEventRepository eventRepository, IKundeRepository kundeRepository)
		{
			_eventRepository = eventRepository;
			_kundeRepository = kundeRepository;
		}

		// Props
		[BindProperty]
		public Models.Event Event { get; set; }

		[BindProperty]
		public Models.Kunde Kunde { get; set; }
		

		// Metoder
		public IActionResult OnGet(int id)
		{
			Event = _eventRepository.Read(id);
			if (Event == null)
			{
				RedirectToPage("/NotFound"); // Redirect til NotFound siden hvis Event ikke findes
			}

			return Page();
		}
		
		public IActionResult OnPost()
		{
			Models.Event deletedEvent = _eventRepository.Delete(Event.Id);
			Models.Kunde deletedKunde = _kundeRepository.Delete(Kunde.Id);
			if (deletedEvent == null && deletedKunde == null)
			{
				RedirectToPage("/NotFound"); // Redirect til NotFound siden hvis Event ikke findes
			}

			return RedirectToPage("/Event/ListOfEventCards");
		}


	}
	
}
