using BarEventPlannerV2.Service;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BarEventPlannerV2.Service.Repositories.Interface;

namespace BarEventPlannerV2.Pages.Event;

// skrevet af Andreas, Mikkel og Tristan

public class BookEventModel : PageModel
{
    private IEventRepository _eventService;
    public BookEventModel(IEventRepository eventService)
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
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _eventService.Create(Event);
        return RedirectToPage("/Event/EventBetalt");
    }
}
