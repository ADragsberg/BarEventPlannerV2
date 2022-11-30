using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BarEventPlannerV1.Pages.Event
{
    public class BookEventModel : PageModel
    {
        [BindProperty]
        public Models.Kunde Kunde { get; set; }


        public void OnGet()
        {
        }
    }
}
