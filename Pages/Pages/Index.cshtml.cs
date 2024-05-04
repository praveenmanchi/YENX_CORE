using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ynex.Pages.Pages;

public class PagesModel : PageModel
{
    private readonly ILogger<PagesModel> _logger;

    public PagesModel(ILogger<PagesModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

}
