using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SampleWebAppForAzure.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Greeting"] = _configuration["Greeting"];
        }
    }
}
