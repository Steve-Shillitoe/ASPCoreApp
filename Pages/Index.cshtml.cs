using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPCoreApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        private DayOfWeek returnDayOfTheWeek()
        {
            DateTime today = DateTime.Now;
            return today.DayOfWeek; 
        }

        public void OnGet()
        {
            string salutation;

            DateTime currentTime = DateTime.Now;

            int currentHour = currentTime.Hour;

            if (currentHour >= 6 && currentHour < 12)
            {
                salutation = "Good morning!";
            }
            else if (currentHour >= 12 && currentHour < 18)
            {
                salutation = "Good afternoon!";
            }
            else
            {
                salutation = "Good evening!";
            }
            ViewData["Salutation"] = salutation;
            ViewData["DayOfWeek"] = returnDayOfTheWeek();
        }
    }
}