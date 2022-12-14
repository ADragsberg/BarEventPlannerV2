using BarEventPlannerV2.Service.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BarEventPlannerV2.Pages.Event
{
	//Lavet af Tristan, Mikkel og Andreas
    public class OpretEventModel : PageModel
    {
		// Felter
		private readonly IEventRepository _eventRepository;
        private readonly IKundeRepository _kundeRepository;

        // KonstruktÝr
        public OpretEventModel(IEventRepository eventRepository, IKundeRepository kundeRepository)
        {
            _eventRepository = eventRepository;
            _kundeRepository = kundeRepository;
        }

		// Props
		[BindProperty]
		public Models.Event Event { get; set; }
        [BindProperty]
        public Models.Kunde Kunde { get; set; }


        public IActionResult OnGet()
        {
			return Page();
		}

		public IActionResult OnPost()
		{
			Event.Kunde = Kunde;
			if (!ModelState.IsValid)
			{
				return Page();
			}
			Event.Godkendt = true;

            _kundeRepository.Create(Kunde);
            _eventRepository.Create(Event);
			return RedirectToPage("/Event/ListOfEventCards");
		}

	}
}
