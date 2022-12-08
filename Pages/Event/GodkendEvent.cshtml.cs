using BarEventPlannerV2.Models;
using BarEventPlannerV2.Service.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
//Lavet af Mikkel og Andreas

namespace BarEventPlannerV2.Pages.Event
{
    public class GodkendEventModel : PageModel
    {
        private IEventRepository _eventRepository;
        private IKundeRepository _kundeRepository;

        public GodkendEventModel(IEventRepository eventRepository, IKundeRepository kundeRepository)
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

        public IActionResult OnPost()
        {

            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}
            //else
            _eventRepository.Godkend(Event.Id, Event);

            
            return RedirectToPage("/Event/ListOfEventCards");
        }


    }
}
