using BarEventPlannerV2.Models;
using BarEventPlannerV2.Service.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BarEventPlannerV2.Pages.Event
{ //skrevet af Andreas Dragsberg
    public class GetEventModel : PageModel
    {
        private IEventRepository _eventRepository;
        private IKundeRepository _kundeRepository;

        public GetEventModel(IEventRepository eventRepository, IKundeRepository kundeRepository)
        {
            _eventRepository = eventRepository;
            _kundeRepository = kundeRepository;

        }

        [BindProperty]
        public Models.Kunde Kunde { get; set; }
        [BindProperty]
        public Models.Event Event { get; set; }

        public IActionResult OnGet(int id)
        {
            Event = _eventRepository.Read(id);
            Kunde = _kundeRepository.Read(id);
            if (Event == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return Page();
        }
    }
}
