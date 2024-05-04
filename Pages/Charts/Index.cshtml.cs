using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ynex.Pages.Charts;

public class ChartsModel : PageModel
{
    private readonly ILogger<ChartsModel> _logger;

    public ChartsModel(ILogger<ChartsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

}
