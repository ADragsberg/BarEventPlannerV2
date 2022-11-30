using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BarEventPlannerV2.Pages.Event
{
    public class BookEventModel : PageModel
    {
        [BindProperty]
        public Models.Kunde Kunde { get; set; }
        [BindProperty]
        public Models.Event Event { get; set; }


        public void OnGet()
        {
        }
    }
}
