using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ynex.Pages.Advancedui;

public class AdvanceduiModel : PageModel
{
    private readonly ILogger<AdvanceduiModel> _logger;

    public AdvanceduiModel(ILogger<AdvanceduiModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

}
