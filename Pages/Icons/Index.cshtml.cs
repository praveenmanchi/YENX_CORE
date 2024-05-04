using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ynex.Pages.Icons;

public class IconsModel : PageModel
{
    private readonly ILogger<IconsModel> _logger;

    public IconsModel(ILogger<IconsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

}
