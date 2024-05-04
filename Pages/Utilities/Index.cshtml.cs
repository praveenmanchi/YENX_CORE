using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ynex.Pages.Utilities;

public class UtilitiesModel : PageModel
{
    private readonly ILogger<UtilitiesModel> _logger;

    public UtilitiesModel(ILogger<UtilitiesModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    
}
