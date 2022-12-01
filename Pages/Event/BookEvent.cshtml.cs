using BarEventPlannerV2.Service;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BarEventPlannerV2.Pages.Event
    // skrevet af Andreas, Mikkel og Tristan
{
    public class BookEventModel : PageModel
    {
        private IEventService _eventService;
        public BookEventModel(IEventService eventService)
        {
            _eventService = eventService;
        }

        [BindProperty]
        public Models.Kunde Kunde { get; set; }
        [BindProperty]
        public Models.Event Event { get; set; }



        public IActionResult OnGet()
        {
            return Page();
;
        }

        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
